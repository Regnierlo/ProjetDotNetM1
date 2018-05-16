using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDotNetM1
{
    public partial class Aide : Form
    {
        public Aide()
        {
            InitializeComponent();
        }

        private void OkAideBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
