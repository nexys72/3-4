using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_практика_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bEdit_TextChanged(object sender, EventArgs e)
        { try
            {
                int r, g, b;
                r = int.Parse(rEdit.Text);
                g = int.Parse(gEdit.Text);
                b = int.Parse(bEdit.Text);
                rgbPanel.BackColor = Color.FromArgb(r, g, b);
                rgbLabel.Text = "#" + r.ToString("X2")
                    + g.ToString("X2") + b.ToString("X2");
            }
            catch
            {
                rgbLabel.Text = "?";
            }
} 

        private void gEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void rEdit_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rEdit_TextChanged(rEdit, e);
        }
    }
}
