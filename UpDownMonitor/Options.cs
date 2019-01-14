﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using UpDownMonitor.Properties;

namespace UpDownMonitor
{
    internal sealed class Options
    {
        private Settings settings;

        public Options(Settings settings)
        {
            this.settings = settings;

            // Import settings from previous version.
            Load();
        }

        public NetworkInterface NetworkInterface { get; set; }

        public Dictionary<string, ulong> NicSpeeds { get; private set; }

        public Rectangle Bounds { get; set; }

        public bool Topmost { get; set; }

        public bool Transparent { get; set; }

        public bool Docking { get; set; }

        public bool LoadHidden { get; set; }

        public bool Tooltips { get; set; }

        public Options Clone()
        {
            var clone = (Options)MemberwiseClone();
            clone.NicSpeeds = new Dictionary<string, ulong>(NicSpeeds);

            return clone;
        }

        private void Load()
        {
            NetworkInterface = NetworkInterfaces.Fetch(settings.LastNic);
            NicSpeeds = settings.NicSpeeds;
            Bounds = settings.Bounds;
            Topmost = settings.Topmost;
            Transparent = settings.Transparent;
            Docking = settings.Docking;
            LoadHidden = settings.LoadHidden;
            Tooltips = settings.Tooltips;
        }

        public void Save()
        {
            settings.LastNic = NetworkInterface?.Id;
            settings.NicSpeeds = NicSpeeds;
            settings.Bounds = Bounds;
            settings.Topmost = Topmost;
            settings.Transparent = Transparent;
            settings.Docking = Docking;
            settings.LoadHidden = LoadHidden;
            settings.Tooltips = Tooltips;

            //settings.Save();
        }
    }

}
