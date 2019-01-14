using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpDownMonitor
{
    internal sealed partial class Settings
    {
        [UserScopedSetting]
        [SettingsSerializeAs(SettingsSerializeAs.Binary)]

        public string LastNic { get; set; }
        public Rectangle Bounds { get; set; }

        public bool Topmost { get; set; }

        public bool Transparent { get; set; }
        public bool Tooltips { get; set; }
        public bool Docking { get; set; }

        public bool LoadHidden { get; set; }

        public Dictionary<string, ulong> NicSpeeds { get; set; }
       
    }

}
