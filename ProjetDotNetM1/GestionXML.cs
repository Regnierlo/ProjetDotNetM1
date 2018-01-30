using System;
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
        #endregion

        #region Proprietes
        public String Chemin
        {
            get { return _chemin; }
            set { _chemin = value; }
        }
        #endregion

        public GestionXML()
        {
            _chemin = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            _chemin = Path.Combine(_chemin, "FHRImages");
            _chemin = String.Concat(_chemin, "\\");
            _doc = new XmlDocument();
            CheckXMLFile();
        }

        /// <summary>
        /// Verifie si le fichier XML pour les tags existe. Sinon on fait une création.
        /// </summary>
        private void CheckXMLFile()
        {
            //Si le fichier n'existe pas
            if(!File.Exists(_chemin+_nomXML))
            {
                try
                {
                    String tmp = String.Concat(_chemin,"\\");
                    tmp = String.Concat(tmp, _nomXML);
                    XmlTextWriter xwriter = new XmlTextWriter(tmp,Encoding.UTF8);
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

        /// <summary>
        /// Ajouter un noeud sans pere.
        /// </summary>
        public void AjouterNoeud()
        {
            
        }
    }
}
