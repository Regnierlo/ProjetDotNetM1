using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ProjetDotNetM1
{
    class GestionListeImages
    {
        public List<GestionImage> ListeImg
        {
            get;
            set;
        }
        public Boolean ActiveBar
        {
            get;
            set;
        }
        private Form1 form;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="list"></param>
        public GestionListeImages(List<GestionImage> list)
        {
            ListeImg = list;
        }

        /// <summary>
        /// creer une liste de gestionImage a partir du dossier d'importation
        /// </summary>
        /// <param name="bar"></param>
        /// <param name="grid"></param>
        public GestionListeImages(ProgressBar bar,Form1 f)
        {
            ActiveBar = false;
            form = f;
            bar.Visible = true;
            int cont = 0;
            ListeImg = new List<GestionImage>();
            string url = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            url = Path.Combine(url, "FHRImages");
            try
            {
                System.Collections.IEnumerable files = Directory.EnumerateFiles(url);
                int nb = 0;
                List<string> fichiers = new List<string>();
                foreach (string img in files)
                {
                    nb++;
                    fichiers.Add(img);
                }
                bar.Maximum = nb;// - 1;
                bar.Minimum = 0;
                bar.Step = 1;
                nb = 0;
                 /*foreach (string img in files)
                 {
                    threadGestImage(img, bar);
                }*/
                
                Parallel.ForEach(fichiers, new ParallelOptions { MaxDegreeOfParallelism = 10 }, img =>
                {
                    threadGestImage(img, bar);
                    
                });
                bar.Value = 0;
                bar.Visible = false;
            }
            catch (Exception)
            {
                System.IO.Directory.CreateDirectory(url);
                bar.Visible = false;
            }
        }
        /// <summary>
        /// Fonction qui permet le multithreading, elle sera appelé pour chaque image
        /// </summary>
        /// <param name="img">l'url de l'image</param>
        /// <param name="bar">la progressBar a faire avancer</param>
        private void threadGestImage(string img, ProgressBar bar)
        {
            Char delim = '\\';
            string[] name = img.Split(delim);
            Regex rgx = new Regex(@".*as485d7s5s.jpg");
            if (name[name.Count() - 1] != "Thumbs.db" && !rgx.IsMatch(name[name.Count() - 1]))
            {
                ListeImg.Add(new GestionImage(img));
                if (ActiveBar)
                {
                    form.Invoke(form.monDelegueBar);
                }
                //bar.PerformStep();
            }
        }
        /// <summary>
        /// permet d'obtenir les information d'une image à afficher dans le bas de la fenetre principale grace a l'url de l'image
        /// </summary>
        /// <param name="urlEntry"></param>
        /// <returns></returns>
        public string rechercheinfo(string urlEntry)
        {
            string  listInfo = "";
            
            foreach(GestionImage urlSearch in ListeImg)
            {
                if (urlSearch.ImgUrl == urlEntry)
                {
                    listInfo = "Nom : " + urlSearch.ImgUrl + "\n";
                    listInfo = listInfo + "Tags : ";
                    foreach (string tag in urlSearch.Tag)
                    {
                        listInfo = listInfo + tag;
                        if (urlSearch.Tag[urlSearch.Tag.Count - 1] != tag)
                        {
                            listInfo = listInfo + ";";
                        }
                    }
                    listInfo = listInfo + "\n";
                    listInfo = listInfo + "Hauteur : " + urlSearch.Hauteur + "\nLargeur : " + urlSearch.Largeur;
                    
                    listInfo = listInfo + "\n";
                    if (urlSearch.PoidsMo == 1)
                    {
                        listInfo = listInfo + "Poids : " + urlSearch.Poids + "Mo";
                    }
                    else
                    {
                        listInfo = listInfo + "Poids : " + urlSearch.Poids + "Ko";
                    }
                    break;
                }
            }
            return listInfo;
        }

        /// <summary>
        /// permet d'avoir l'orientation d'une image grace a l'url
        /// 
        /// </summary>
        /// <param name="urlEntry"></param>
        /// <returns></returns>
        public int rechercheOrientation(string urlEntry)
        {
            int orientation = 0;
            foreach (GestionImage urlSearch in ListeImg)
            {
                if (urlSearch.ImgUrl == urlEntry)
                {
                    orientation = urlSearch.Orientation;
                    break;
                }
            }
            return orientation;
        }

        /// <summary>
        /// permte d'obtenir la liste de stags d'une imae grace a l'url
        /// </summary>
        /// <param name="urlEntry"></param>
        /// <returns></returns>
        public List<string> rechercheTags(string urlEntry)
        {
            List<string> tags = new List<string>();
            foreach (GestionImage urlSearch in ListeImg)
            {
                if (urlSearch.ImgUrl == urlEntry)
                {
                    tags = urlSearch.Tag;
                    break;
                }
            }
            return tags;
        }
        /// <summary>
        /// Permet de modifier les tags d'une image
        /// </summary>
        /// <param name="urlEntry">l'url de l'image que l'on souhaite modifier</param>
        /// <param name="tags">la liste des tags a mettre a la place</param>
        public void modifieTags(string urlEntry, List<string> tags)
        {
            foreach (GestionImage urlSearch in ListeImg)
            {
                if (urlSearch.ImgUrl == urlEntry)
                {
                    urlSearch.AjoutTag(tags);
                    break;
                }
            }
        }
        /// <summary>
        /// change l'url d'une imae
        /// </summary>
        /// <param name="urlEntry">l'url de l'image a modifier</param>
        /// <param name="url">la nouvelle url</param>
        public void modifieURL(string urlEntry, string url)
        {
            foreach (GestionImage urlSearch in ListeImg)
            {
                if (urlSearch.ImgUrl == urlEntry)
                {
                    urlSearch.ImgUrl = url;
                    break;
                }
            }
        }
    }
}