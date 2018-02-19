using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProjetDotNetM1
{
    class GestionListeImages
    {
        public List<GestionImage> ListeImg
        {
            get;
            set;
        }

        /// <summary>
        /// creer une liste de gestionImage a partir du dossier d'importation
        /// </summary>
        /// <param name="bar"></param>
        /// <param name="grid"></param>
        public GestionListeImages(ProgressBar bar)
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
        public string rechercheinfo(string urlEntry)
        {
            string  listInfo = "";
            foreach(GestionImage urlSearch in ListeImg)
            {
                if(urlSearch.ImgUrl == urlEntry)
                {
                    listInfo = "Nom : "+urlSearch.ImgUrl+"\n";
                    listInfo = listInfo + "Tags : ";
                    foreach(string tag in urlSearch.Tag)
                    {
                        listInfo = listInfo + tag;
                        if(urlSearch.Tag[urlSearch.Tag.Count-1] != tag)
                        {
                            listInfo = listInfo + ";";
                        }
                    }
                    listInfo = listInfo + "\n";
                }
            }
            return listInfo;
        }
    }
}