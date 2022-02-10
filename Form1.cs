using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        int width = 0;

        public delegate void Del();

        public Form1()
        {
            InitializeComponent();
            this.ResizeEnd += Form1_ResizeEnd;
            width = this.Size.Width;           
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Del op;

            if(width >= this.Width)
            {
                op = new Del(FormSmaller);
            }
            else if(width <= this.Width)
            {
                op = new Del(FormBigger);
            }
            else
            {
                op = new Del(Unknown);
            }

            op();

            width = this.Width;
        }

        private void FormSmaller()
        {
            MessageBox.Show("Kleiner");
        }

        private void FormBigger()
        {
            MessageBox.Show("Größer");
        }

        private void Unknown()
        {
            MessageBox.Show("Unbekannt");
        }

    }
}
