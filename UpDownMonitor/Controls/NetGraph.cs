﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpDownMonitor.Controls
{
    public partial class NetGraph : Control
    {
        private const float HEADROOM = .1f;

        private NetworkInterfaceSampler sampler;

        private Dictionary<Sample, ulong> sampleIndexes;
        private ulong sampleCount;

        private Pen applePen, pineapplePen, ppapPen, headroomPen, periodPen, lightPeriodPen;

        private const int WARNING_MAX_OPACITY = 192;
        private byte warningOpacity = WARNING_MAX_OPACITY;
        private CancellationTokenSource cancelWarningAnimation;

        public NetGraph()
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            CreatePens();
        }

        /// <summary>
        /// Gets the rectangle that represents the graph area of the control.
        /// </summary>
        private Rectangle GraphRectangle
        {
            get
            {
                Rectangle rectangle = ClientRectangle;
                rectangle.Inflate(-1, -1);

                return rectangle;
            }
        }

        public NetworkInterfaceSampler Sampler
        {
            set
            {
                sampler = value;
                value.SampleAdded += Sampler_SampleAdded;
                value.SamplesCleared += Sampler_SamplesCleared;

                Reset();
            }
        }

        /// <summary>
        /// 创建画笔
        /// </summary>
        private void CreatePens()
        {
            const int OPACITY = 255; //192; // 75%.//透明度

            applePen = new Pen(Color.Red);//Color.FromArgb(OPACITY, 255, 76, 76));

            pineapplePen = new Pen(Color.FromArgb(OPACITY, 0, 255, 0).Desaturate(1.4f));
            ppapPen = new Pen(Color.FromArgb(OPACITY, 255, 255, 0).Desaturate(1.3f));

            headroomPen = new Pen(Color.Yellow);

            periodPen = new Pen(Color.Purple);
            lightPeriodPen = new Pen(Color.FromArgb(160, 0, 0, 0));
        }

        public void Reset()
        {
            sampleIndexes = new Dictionary<Sample, ulong>();
            sampleCount = 0;

            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // Avoid division by zero.
            if (sampler?.MaximumSpeed > 0)
            {
                StopWarningAnimation();

                // Use entire graph area regardless of clipping region.
                Bitmap bitmap = new Bitmap(400, 100);
                for (int x = 0; x < bitmap.Width; x++)
                {
                    for (int y = 0; y < bitmap.Height; y++)
                    {
                        bitmap.SetPixel(x, y, Color.Black);
                    }
                }

                e.Graphics.DrawImage(bitmap, GraphRectangle);
                PaintGraph(e.Graphics, GraphRectangle);
            }
            else
            {
                StartWarningAnimation();

                PaintWarning(e.Graphics, ClientRectangle, "Please choose an adapter");
            }

            // Paint entire border regardless of clipping region.
            ControlPaint.DrawBorder3D(e.Graphics, ClientRectangle, Border3DStyle.SunkenOuter);
        }

        private void PaintGraph(Graphics g, Rectangle surface)
        {
            // Drawing start point on x-axis.
            int x = surface.Right - 1;
            g.SmoothingMode = SmoothingMode.HighQuality;

            foreach (Sample sample in sampler)
            {
                float downstream = sample.Downstream / (float)sampler.MaximumSpeed;//下载速度
                float upstream = sample.Upstream / (float)sampler.MaximumSpeed;//上传速度
                bool downDominant = downstream > upstream;
                float hybridHeight = surface.Height * (1 - (downDominant ? upstream : downstream) * (1 - HEADROOM)) + surface.Top;
                float dominantHeight = surface.Height * (1 - (downDominant ? downstream : upstream) * (1 - HEADROOM)) + surface.Top;

                // Draw hybrid bar.
                g.DrawLine(ppapPen, x, hybridHeight, x, surface.Bottom);

                // Draw upload/download bar.
                g.DrawLine(downDominant ? applePen : pineapplePen, x, dominantHeight, x, hybridHeight);

                // Draw period separator.
                if (sampleIndexes[sample] % 30 == 0)
                {
                    for (int i = surface.Top; i < surface.Bottom; i += 4)
                    {
                        g.DrawLine((i - surface.Top) % 8 == 0 ? periodPen : lightPeriodPen, x, i, x, i + 3);
                    }
                }

                // Do not draw more samples than surface width permits.
                if (--x < surface.Left)
                {
                    break;
                }
            }

            // Draw headroom bar.
            float headroomY = surface.Height * HEADROOM;
            g.DrawLine(headroomPen, x + 1, headroomY, surface.Right, headroomY);
        }

        private void PaintWarning(Graphics g, Rectangle surface, string warning)
        {
            const int MARGIN = 2;
            SizeF indicatorSize = new SizeF(30, 30);
            SizeF warningSize = g.MeasureString(warning, Font);
            SizeF totalSize = new SizeF(indicatorSize.Width + MARGIN + warningSize.Width, indicatorSize.Height);

            g.SmoothingMode = SmoothingMode.HighQuality;

            // Draw indicator.
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(128, BackColor.Darken(.4f))))
            {
                g.FillEllipse(brush, new RectangleF(
                    new PointF(
                        (float)Math.Round(surface.Width / 2 - totalSize.Width / 2),
                        (float)Math.Round(surface.Height / 2 - indicatorSize.Height / 2)
                    ),
                    indicatorSize
                ));
            }

            // Draw indicator text.
            using (Font font = new Font("Segoe UI", 18, FontStyle.Bold))
            {
                SizeF fontSize = g.MeasureString("?", font);

                g.DrawString(
                    "?",
                    font,
                    SystemBrushes.Control,
                    (float)Math.Round(surface.Width / 2 - totalSize.Width / 2 + indicatorSize.Width / 2 - fontSize.Width / 2 + 1.5),
                    (float)Math.Round(surface.Height / 2 - fontSize.Height / 2)
                );
            }

            // Draw warning text.
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(warningOpacity, ForeColor)))
            {
                g.DrawString(
                    warning,
                    Font,
                    brush,
                    (float)Math.Round(surface.Width / 2 + indicatorSize.Width - totalSize.Width / 2 + MARGIN),
                    (float)Math.Round(surface.Height / 2 - warningSize.Height / 2 + .5)
                );
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Use entire client area regardless of clipping region.
            Rectangle surface = ClientRectangle;

            using (LinearGradientBrush backgroud = new LinearGradientBrush(surface, SystemColors.ControlLightLight, SystemColors.Control, 90))
            {
                e.Graphics.FillRectangle(backgroud, surface);
            }
        }

        private async void StartWarningAnimation()
        {
            // Avoid reentry.
            if (cancelWarningAnimation != null || DesignMode)
            {
                return;
            }

            using (cancelWarningAnimation = new CancellationTokenSource())
            {
                DateTime startTime = DateTime.Now;

                while (true)
                {
                    AnimateWarning(startTime);

                    try
                    {
                        await Task.Delay(40, cancelWarningAnimation.Token);
                    }
                    catch (TaskCanceledException)
                    {
                        break;
                    }
                }
            }
            cancelWarningAnimation = null;
        }

        private void StopWarningAnimation()
        {
            cancelWarningAnimation?.Cancel();
        }

        private void AnimateWarning(DateTime startTime)
        {
            const float ANIMATION_DURATION = 1500;

            warningOpacity = (byte)(WARNING_MAX_OPACITY - (WARNING_MAX_OPACITY *
                Ease((DateTime.Now - startTime).TotalMilliseconds % ANIMATION_DURATION / ANIMATION_DURATION)
            ));

            Invalidate();
        }

        private double Ease(double t)
        {
            t = t < .5 ? t * 2 : 2 - 2 * t;

            return t * t * t;
        }

        #region Event handlers

        private void Sampler_SampleAdded(NetworkInterfaceSampler sampler, Sample sample)
        {
            sampleIndexes.Add(sample, sampleCount++);
            Invalidate();
        }

        private void Sampler_SamplesCleared(NetworkInterfaceSampler sampler)
        {
            Reset();
        }

        #endregion
    }
}
