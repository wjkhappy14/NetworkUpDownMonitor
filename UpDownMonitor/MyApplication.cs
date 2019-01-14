using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpDownMonitor
{
   
    internal class MyApplication : ApplicationContext
    {
        // It is paramount to hide the base property because the setter forces the form to be visible.
        public new Form MainForm { get; private set; }

        public MyApplication(Form mainForm)
        {
            MainForm = mainForm;

            mainForm.FormClosed += delegate { ExitThread(); };
        }

        public static string ProductName
        {
            get { return Application.ProductName; }
        }

        public static string CanonicalProductVersion
        {
            get
            {
                return string.Join(".", Application.ProductVersion.Split('.').TakeWhile((s, i) => i < 3));
            }
        }
    }

}
