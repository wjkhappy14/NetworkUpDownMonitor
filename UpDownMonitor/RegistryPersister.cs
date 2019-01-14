using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UpDownMonitor
{
    internal class RegistryPersister
    {
        private static Dictionary<OptionName, RegistryEntry> registryOptions = new Dictionary<OptionName, RegistryEntry>  {
            {
                OptionName.LoadAtSystemStartup,
                new RegistryEntry {
                    Hive = Registry.CurrentUser,
                    Key = @"Software\Microsoft\Windows\CurrentVersion\Run",
                    Name = Application.ProductName
                        #if DEBUG
                            + " DEBUG"
                        #endif
                    ,
                    Value = $"\"{Application.ExecutablePath}\"",
                    ExistsCallback = (entry, key) => key.GetValue(entry.Name)?.ToString().StartsWith(entry.Value),
                }
            },
        };

        public RegistryPersister(RegistryOptions options)
        {
            Options = options;
        }

        public RegistryOptions Options { get; set; }

        public void Save()
        {
            foreach (KeyValuePair<OptionName, RegistryEntry> registryOption in registryOptions)
            {
                OptionName option = registryOption.Key;
                RegistryEntry entry = registryOption.Value;
                using (RegistryKey key = entry.Hive.OpenSubKey(entry.Key, true))
                {
                    if ((bool)typeof(RegistryOptions).GetProperty(option.ToString()).GetValue(Options))
                    {
                        key.SetValue(entry.Name, entry.Value);
                    }
                    else
                    {
                        key.DeleteValue(entry.Name, false);
                    }
                }
            }
        }

        public void Load()
        {
            foreach (KeyValuePair<OptionName, RegistryEntry> registryOption in registryOptions)
            {
                typeof(RegistryOptions).GetProperty(registryOption.Key.ToString()).SetValue(Options, registryOption.Value.Exists());
            }
        }

        private enum OptionName
        {
            LoadAtSystemStartup,
        }

        private struct RegistryEntry
        {
            public delegate bool? EntryExistsDelegate(RegistryEntry entry, RegistryKey key);

            public RegistryKey Hive { get; set; }

            public string Key { get; set; }

            public string Name { get; set; }

            public string Value { get; set; }

            public EntryExistsDelegate ExistsCallback { get; set; }

            public bool Exists()
            {
                using (RegistryKey key = Hive.OpenSubKey(Key))
                {
                    return ExistsCallback?.Invoke(this, key) == true;
                }
            }
        }
    }

}
