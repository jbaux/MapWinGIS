using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace MWLite.Core.UI
{
    public abstract class CommandDispatcher<T> where T : struct, IConvertible
    {
        private readonly string[] Prefixes = new[] { "tool", "mnu", "ctx" };
        private readonly Dictionary<string, T> CommandNameToEnumValue =
            Enum.GetValues(typeof(T)).Cast<T>().ToDictionary(v => v.ToString().ToLower(), v => v);

        public bool CommandFromName(ToolStripItem item, ref T command)
        {
            string itemName = item.Name;
            itemName = itemName.ToLower();
            foreach (var prefix in Prefixes)
            {
                if (itemName.StartsWith(prefix) && itemName.Length > prefix.Length)
                {
                    itemName = itemName.Substring(prefix.Length);

                    // Allow for multiple items to use the same command by ending with different numbers.
                    // This was required as the form designer doesn't allow duplicate control names.
                    char lastChar = itemName[itemName.Length-1];
                    if (char.IsDigit(lastChar))
                    {
                        itemName = itemName.Substring(0, itemName.Length-1);
                    }

                    break;
                }
            }

            if (CommandNameToEnumValue.TryGetValue(itemName, out command))
            {
                return true;
            }

            Debug.Print("Command not found: " + itemName);

            if (item is ToolStripDropDownItem menu && menu.DropDownItems.Count > 0)
            {
                return false;
            }

            if (item is ToolStripSeparator)
            {
                return false;
            }

            CommandNotFound(item);
            return false;
        }

        public abstract void Run(T command);

        protected abstract void CommandNotFound(ToolStripItem item);

        /// <summary>
        /// Sets event handlers for menu items
        /// </summary>
        public void InitMenu(ToolStripItemCollection items)
        {
            if (items == null)
            {
                return;
            }

            foreach (ToolStripItem item in items)
            {
                if (item.Tag == null)
                {
                    item.Click += ItemClick;
                }

                if (item is ToolStripDropDownItem menuItem)
                {
                    InitMenu(menuItem.DropDownItems);
                }
            }
        }

        /// <summary>
        /// Runs menu commands
        /// </summary>
        private void ItemClick(object sender, EventArgs e)
        {
            if (sender is ToolStripItem item)
            {
                var command = Activator.CreateInstance<T>();
                if (CommandFromName(item, ref command))
                {
                    Run(command);
                }
            }
        }
    }
}
