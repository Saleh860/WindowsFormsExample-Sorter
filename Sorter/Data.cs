using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorter
{
    internal class Data
    {
        private string[] items;

        public string[] getItems()
        {
            return items;
        }
        public void setItems(System.Windows.Forms.ListBox.ObjectCollection objects)
        {
            items = new string[objects.Count];
            for(int i = 0;i < objects.Count; i++)
            {
                items[i] = objects[i].ToString();
            }
        }
    }
}
