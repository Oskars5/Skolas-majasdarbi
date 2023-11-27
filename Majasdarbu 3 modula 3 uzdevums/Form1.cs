using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Majasdarbu_3_modula_3_uzdevums
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butbalts_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void butzals_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void butmelns_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void butsarkans_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void butdzeltans_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }
    }
}
