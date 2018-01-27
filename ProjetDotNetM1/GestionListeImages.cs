using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProjetDotNetM1
{
    class GestionListeImages
    {
        ArrayList listeImg;
        /*
         * creer une liste de gestionImage a partir du dossier d'importation
         */ 
        public GestionListeImages(ProgressBar bar, DataGridView grid)
        {
            bar.Visible = true;
            listeImg = new ArrayList();
            string url = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            url = Path.Combine(url, "FHRImages");
            System.Collections.IEnumerable files = Directory.EnumerateFiles(url);
            int nb = 0;
            foreach (string img in files)
            {
                nb++;
            }
            bar.Maximum = nb-1;
            bar.Minimum = 0;
            bar.Step = 1;
            nb = 0;
            foreach (string img in files)
            {
                Char delim = '\\';
                string[] name = img.Split(delim);
                if(name[name.Count()-1] != "Thumbs.db")
                {
                    listeImg.Add(new GestionImage(img));
                    bar.PerformStep();
                }
                
            }
            bar.Value = 0;
            bar.Visible = false;
        }
        /*
         * creer un liste de GestionImage a partir d'une array list afin de réaliser une importation par la suite
         */ 
        public GestionListeImages(ArrayList entryList)
        {
            listeImg = new ArrayList();
            foreach ( string img in entryList ) {
                listeImg.Add(new GestionImage(img));
            }
        }
        /*
         * permet d'importer les gestionImage de la liste dans le dossier d'importation
         */ 
        public void importer()
        {
            foreach (GestionImage img in listeImg)
            {
                Char delim = '\\';
                string url = img.ImgUrl;
                string[] nom = url.Split(delim);
                string name = nom[nom.Count()-1];
                string saveUrlDos = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                saveUrlDos = Path.Combine(saveUrlDos, "FHRImages");
                string saveUrl = Path.Combine(saveUrlDos, name);
                try
                {
                    System.IO.File.Copy(img.ImgUrl, saveUrl, false);
                }
                catch (Exception ex)
                {
                    System.IO.Directory.CreateDirectory(saveUrlDos);
                    System.IO.File.Copy(img.ImgUrl, saveUrl, false);    //possible exception si le fchier deja present a voir comment on le gere ;)
                }


            }
        }
    }
}
