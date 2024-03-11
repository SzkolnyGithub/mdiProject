using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikacjaMDIBadowski4c
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void nazwa_TextChanged(object sender, EventArgs e)
        {
            if(nazwa.Text == list.Images[0].ToString())
            {
                pictureBox1.Image = list.Images[0];
            } else if(nazwa.Text == list.Images[1].ToString())
            {
                pictureBox1.Image = list.Images[1];
            } else
            {
                pictureBox1.Image = list.Images[2];
            }
        }
    }
}
