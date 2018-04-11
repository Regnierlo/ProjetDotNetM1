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
    public partial class DescendreTag : Form
    {
        public DescendreTag(TreeView tv, TreeNode node)
        {
            InitializeComponent();
            InitialisationTreeView(node, node);
        }

        private void InitialisationTreeView(TreeNode node, TreeNode currentNode)
        {
            TreeNodeCollection childsNodes = currentNode.Nodes;
            String nameNodeChild;
            String[] substring;
            int nb = childsNodes.Count;


            for (int i = 0; i < nb; i++)
            {
                substring = currentNode.Nodes[i].ToString().Split(' ');
                nameNodeChild = substring[1];

                if (currentNode == null || currentNode == node)
                {
                    treeView_SelectFils.Nodes.Add(nameNodeChild);
                }
                else
                {
                    currentNode.Nodes.Add(nameNodeChild);
                }

                if (currentNode.Nodes[i].GetNodeCount(true) > 0)
                    InitialisationTreeView(node, currentNode.Nodes[i]);
            }
        }

        private void button_Sauvegarder_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
