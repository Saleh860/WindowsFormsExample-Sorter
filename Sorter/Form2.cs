using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] s = Program.getData().getItems();
            for(int i = 0;i<s.Length;i++)
            {
                Button button1 = new Button();
                button1.Text = s[i];
                button1.Location = new Point(10, 25 * i);
                Controls.Add(button1);
            }
        }
    }
}
