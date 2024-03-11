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
    public partial class Form1 : Form
    {
        public Form2 form2;
        public Form3 form3;
        public Form4 form4;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void tworz(Form f, string tag)
        {
            f.MdiParent = this;
            f.Tag = tag;
            f.FormClosed += new FormClosedEventHandler(ded);
            f.Show();
            f.Activate();
        }
        private void tworzI(Form f, string tag)
        {
            f.MdiParent = this;
            f.Tag = tag;
            f.Show();
            f.Activate();
        }
        private void okno1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(form2 == null)
            {
                tworz(form2 = new Form2(), "Okno1");
            } else
            {
                form2.Activate();
            }
        }
        private void ded(object sender, FormClosedEventArgs e)
        {
            Form f = sender as Form;
            switch(f.Tag.ToString())
            {
                case "Okno1": form2 = null;
                    break;
                case "Okno2": form3 = null;
                    break;
                case "Okno3": form4 = null;
                    break;
            }
        }

        private void okno2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form3 == null)
            {
                tworz(form3 = new Form3(), "Okno2");
            }
            else
            {
                form3.Activate();
            }
        }

        private void okno3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (form4 == null)
            {
                tworz(form4 = new Form4(), "Okno3");
            }
            else
            {
                form4.Activate();
            }
        }

        private void otwórzInstancjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tworzI(Form5.Instancja, "OknoInstancji1");
            Form5.Instancja.Text = "Okno Instancji 1";
            Form5.Instancja.Width = this.Width / 2;
            Form5.Instancja.Height = this.Height / 2;
        }

        private void oknoInstancja2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tworzI(Form6.Instancja, "OknoInstancji2");
            Form6.Instancja.Text = "Okno Instancji 2";
            Form6.Instancja.Width = this.Width / 2;
            Form6.Instancja.Height = this.Height / 2;
        }

        private void oknoInstancja3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tworzI(Form7.Instancja, "OknoInstancji3");
            Form7.Instancja.Text = "Okno Instancji 3";
            Form7.Instancja.Width = this.Width / 2;
            Form7.Instancja.Height = this.Height / 2;
        }
    }
}
