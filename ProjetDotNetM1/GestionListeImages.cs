using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace ProjetDotNetM1
{
    class GestionListeImages
    {
        public ArrayList ListeImg
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
            ListeImg = new ArrayList();
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
                        ListeImg.Add(new GestionImage(img));
                        bar.PerformStep();
                    }
                
                }
                bar.Value = 0;
                bar.Visible = false;
            }
            catch(Exception)
            {
                System.IO.Directory.CreateDirectory(url);
                bar.Visible = false;
            }
            
        }

        /*
         * creer un liste de GestionImage a partir d'une array list afin de réaliser une importation par la suite
         */ 
        public GestionListeImages(ArrayList entryList)
        {
            ListeImg = new ArrayList();
            foreach ( string img in entryList ) {
                ListeImg.Add(new GestionImage(img));
            }
        }

        /*
         * permet d'importer les gestionImage de la liste dans le dossier d'importation
         */ 
        public void importer()
        {
            foreach (GestionImage img in ListeImg)
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
                catch (System.IO.DirectoryNotFoundException)
                {
                    System.IO.Directory.CreateDirectory(saveUrlDos);
                    System.IO.File.Copy(img.ImgUrl, saveUrl, false);
                }
                catch (System.IO.IOException)
                {
                    FormImageExistante form = new FormImageExistante(img.Img,saveUrl);
                    DialogResult res = form.ShowDialog();
                    if(res == DialogResult.Cancel)
                    {
                        System.Console.WriteLine("cancel : 1");
                    }
                    else
                    {
                        if(res == DialogResult.Ignore)
                        {
                            System.Console.WriteLine("ignore : 3");
                        }
                        else
                        {
                            System.Console.WriteLine("abort : 2");
                        }
                    }
                }
            }
        }
    }
}
