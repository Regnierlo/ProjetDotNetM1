using System;
using System.IO;
using System.Xml;

namespace ProjetDotNetM1
{
    public class GestionXML
    {
        #region Variables de classe
        private static GestionXML _instance;
        private String _chemin;
        private XmlDocument _doc;
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
            _doc = new XmlDocument();
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
