using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ProjetDotNetM1
{
    public class GestionXML
    {
        #region Variables de classe
        private static GestionXML _instance;
        private String _chemin;
        private XmlDocument _doc;
        private const String _nomXML = "tags.xml";
        private String _cheminComplet;
        private XmlNode root;
        private List<Tag> _ltag;
        #endregion

        #region Proprietes
        public String Chemin
        {
            get { return _chemin; }
            set { _chemin = value; }
        }

        public List<Tag> Ltag
        {
            get { return _ltag; }
        }
        #endregion

        #region Creation fichier et objet XML
        public GestionXML()
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
                    xwriter.WriteStartElement("tags");
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
        public static GestionXML Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new GestionXML();
                return _instance;
            }
        }
        #endregion

        #region Gestion XML
        public void AjouterNoeud(Tag newTag)
        {
            _doc.Load(_cheminComplet);
            XmlNode xnode = _doc.CreateElement(newTag.Libelle);

            root.AppendChild(xnode);
            _doc.Save(_chemin + _nomXML);
        }

        public void SupprimerNoeud()
        {
            
        }

        public void RenommerNoeud()
        {
            
        }
        #endregion

        #region Gestion liste des TAGS
        public void AjouterTag(String nomTag)
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

            AjouterNoeud(ntag);
        }

        public void SupprimerTag()
        {
            
        }

        public void RenommerTag()
        {
            
        }
        #endregion
    }
}
