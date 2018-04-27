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
    public partial class Form3 : Form
    {
        public string Tag
        {
            get;
            set;
        }
        public Form3(List<string> tags)
        {
            InitializeComponent();
            foreach(string tag in tags)
            {
                comboBox1.Items.Add(tag);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Tag = comboBox1.SelectedItem.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
