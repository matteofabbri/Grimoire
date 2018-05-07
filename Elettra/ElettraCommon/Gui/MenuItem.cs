
using System.Collections.Generic;

namespace Elettra.Gui
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Link { get; set; }

        public List<MenuItem> SubMenu { get; set; }

        public MenuItem()
        {
            SubMenu = new List<MenuItem>();
        }
    }
}
