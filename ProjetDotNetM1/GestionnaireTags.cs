using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ProjetDotNetM1
{
    public class GestionnaireTags
    {
        #region Variables de classe
        private static GestionnaireTags _instance;
        private String _chemin;
        private XmlDocument _doc;
        private const String _nomXML = "tags.xml";
        private String _cheminComplet;
        private XmlNode root;
        private const String string_root = "Liste_des_tags";
        private List<Tag> _ltag;

        private StreamWriter sr;
        #endregion

        #region Proprietes
        public String Chemin
        {
            get { return _chemin; }
            set { _chemin = value; }
        }

        public String NomXML
        {
            get { return _nomXML; }
        }

        public List<Tag> Ltag
        {
            get { return _ltag; }
        }

        public XmlDocument Doc
        {
            get { return _doc; }
        }
        #endregion

        #region Creation fichier et objet XML
        public GestionnaireTags()
        {
            _chemin = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            _chemin = Path.Combine(_chemin, "FHRImages");
            _chemin = String.Concat(_chemin, "\\");
            _cheminComplet = String.Concat(_chemin, _nomXML);
            _doc = new XmlDocument();
            root = _doc.CreateElement("tags");
            _ltag = new List<Tag>();
            CheckXMLFile();
        }

        /// <summary>
        /// Verifie si le fichier XML pour les tags existe. Sinon on fait une création.
        /// </summary>
        private void CheckXMLFile()
        {
            //Si le fichier n'existe pas
            if (!File.Exists(_chemin + _nomXML))
            {
                try
                {
                    String tmp = String.Concat(_chemin, "\\");
                    tmp = String.Concat(tmp, _nomXML);
                    XmlTextWriter xwriter = new XmlTextWriter(tmp, Encoding.UTF8);
                    xwriter.WriteStartDocument();
                    xwriter.Formatting = Formatting.Indented;
                    xwriter.WriteStartElement(string_root);
                    xwriter.WriteStartElement("tag");
                    xwriter.WriteEndElement();
                    xwriter.WriteEndElement();
                    xwriter.WriteEndDocument();
                    xwriter.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            else
            {
                Console.WriteLine("Fichier existe");
            }
        }

        //Singleton
        public static GestionnaireTags Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GestionnaireTags();
                return _instance;
            }
        }
        #endregion

        #region Gestion XML
        #endregion

        #region Gestion liste des TAGS
        public void AjouterTag(String nomTag, TreeNode treeNodeSelect)
        {
            Boolean tagExist = false;

            foreach (var tag in _ltag)
            {
                if (tag.Libelle == nomTag)
                    tagExist = true;
            }

            Tag ntag = null;

            //Si le tag n'existe pas alors on le créé
            if (!tagExist)
            {
                ntag = new Tag(nomTag);
                _ltag.Add(ntag);
            }
            else //sinon msgbox avec possibilité de renommer
            {

            }
        }

        public void SupprimerTag()
        {
            
        }

        public void RenommerTag()
        {
            
        }
        #endregion

        #region Gestion tree view
        public void Add_nodes(XmlNode x_node, TreeNode t_node)
        {
            XmlNode xnode;
            TreeNode tnode;
            XmlNodeList node_list;

            if(x_node.HasChildNodes)
            {
                node_list = x_node.ChildNodes;

                for(int i = 0; i <= node_list.Count-1;i++)
                {
                    xnode = x_node.ChildNodes[i];
                    t_node.Nodes.Add(new TreeNode(xnode.Name));
                    tnode = t_node.Nodes[i];
                    Add_nodes(xnode, tnode);
                }
            }
            else
            {
                t_node.Name = x_node.Name.ToString();
            }
        }

        public void AfficheTreeView(TreeView tv)
        {
            try//on tente d'ouvrir un flux
            {
                FileStream fstream = new FileStream(_chemin + _nomXML, FileMode.Open, FileAccess.Read);

                try//si c'est bon on pourra forcement le fermer a un moment donné
                {
                    XmlNode xnode;
                    _doc.Load(fstream);
                    xnode = _doc.ChildNodes[1];
                    tv.Nodes.Clear();
                    tv.Nodes.Add(new TreeNode(_doc.DocumentElement.Name));
                    TreeNode tree_node;
                    tree_node = tv.Nodes[0];
                    Add_nodes(xnode, tree_node);
                    tree_node.ExpandAll();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally //Dans tous les cas (exception levée ou non) on ferme le flux
                {
                    fstream.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #endregion


        public void exportToXml(TreeView tv, string filename)
        {
            sr = new StreamWriter(filename, false, System.Text.Encoding.UTF8);
            //Write the header
            sr.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\" ?>");
            //Write our root node
            sr.WriteLine("<" + tv.Nodes[0].Text + ">");
            foreach (TreeNode node in tv.Nodes)
            {
                saveNode(node.Nodes,1);
            }
            //Close the root node
            sr.WriteLine("</" + tv.Nodes[0].Text + ">");
            sr.Close();
        }

        private void saveNode(TreeNodeCollection tnc, int n)
        {
            foreach (TreeNode node in tnc)
            {
                for (int i = 0; i < n; i++)
                    sr.Write("  ");
                sr.WriteLine("<" + node.Text + ">");

                n++;
                saveNode(node.Nodes,n);
                n--;

                for (int i = 0; i < n; i++)
                    sr.Write("  ");
                sr.WriteLine("</" + node.Text + ">");
            }
        }
    }
}
