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
    public partial class Form6 : Form
    {
        private static Form6 instancja;
        public static Form6 Instancja
        {
            get
            {
                if (instancja == null)
                {
                    instancja = new Form6();
                }
                return instancja;
            }
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void Form6_FornClosed(object sender, FormClosedEventArgs e)
        {
            instancja = null;
        }
    }
}
