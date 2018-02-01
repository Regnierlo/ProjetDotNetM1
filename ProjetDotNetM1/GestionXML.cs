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
            get { return _ltag; s}
        }
        #endregion

        #region Creation fichier et objet XML
        public GestionXML()
        {
            _chemin = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            _chemin = Path.Combine(_chemin, "FHRImages");
            _chemin = String.Concat(_chemin, "\\");
            _doc = new XmlDocument();
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
        public void AjouterNoeud(String nomNoeud)
        {
            //1 - Vérifier s'il existe
            //2a - S'il existe lui ajouter un parent dans sa liste des peres
            //2b - Sinon Créer un objet tag avec ce parent
        }

        public void SupprimerNoeud()
        {
            
        }

        public void RenommerTag()
        {
            
        }
        #endregion

        #region Gestion liste des TAGS
        public void AjouterTag()
        {
            
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
