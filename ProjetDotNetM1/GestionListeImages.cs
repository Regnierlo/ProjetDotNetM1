using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace ProjetDotNetM1
{
    class GestionListeImages
    {
        public List<GestionImage> ListeImg
        {
            get;
            set;
        }
        /*
         * creer une liste de gestionImage a partir du dossier d'importation
         */
        public GestionListeImages(ProgressBar bar, DataGridView grid)
        {
            bar.Visible = true;
            ListeImg = new List<GestionImage>();
            string url = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            url = Path.Combine(url, "FHRImages");
            try
            {
                System.Collections.IEnumerable files = Directory.EnumerateFiles(url);
                int nb = 0;
                foreach (string img in files)
                {
                    nb++;
                }
                bar.Maximum = nb - 1;
                bar.Minimum = 0;
                bar.Step = 1;
                nb = 0;
                foreach (string img in files)
                {
                    Char delim = '\\';
                    string[] name = img.Split(delim);
                    if (name[name.Count() - 1] != "Thumbs.db")
                    {
                        ListeImg.Add(new GestionImage(img));
                        bar.PerformStep();
                    }

                }
                bar.Value = 0;
                bar.Visible = false;
            }
            catch (Exception)
            {
                System.IO.Directory.CreateDirectory(url);
                bar.Visible = false;
            }

        }
        public string rechercheImage(string url)
        {
            string res = null;
            foreach(GestionImage img in ListeImg)
            {
                
                if (img.ImgUrl == url)
                {
                    res = img.ImgUrl;
                }
            }
            return res;
        } 
    }
}
