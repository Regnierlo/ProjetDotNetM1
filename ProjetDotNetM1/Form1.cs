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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void miseÀJourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Console.WriteLine("màj réussi");
        }

        private void cacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fichierToolStripMenuItem.Visible = false;
            editionToolStripMenuItem.Visible = false;

        }
    }
}
