using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProcessCmdKey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.W:
                    button2.Location = new Point(button2.Location.X, button2.Location.Y - 5);
                    break;
                case Keys.S:
                    button2.Location = new Point(button2.Location.X, button2.Location.Y + 5);
                    break;
                case Keys.Up:
                    button1.Location = new Point(button1.Location.X, button1.Location.Y - 5);
                    break;
                case Keys.Down:
                    button1.Location = new Point(button1.Location.X, button1.Location.Y + 5);
                    break;
                default:
                    break;
            }
            return true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                MessageBox.Show("Test");
            }
        }
    }
}
