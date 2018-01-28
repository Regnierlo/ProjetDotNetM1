﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace ProjetDotNetM1
{
    class GestionListeImport
    {
        public ArrayList ListeImg
        {
            get;
            set;
        }
        public GestionListeImages ListeImgImport
        {
            get;
            set;
        }
        /*
         * creer un liste de GestionImage a partir d'une array list afin de réaliser une importation par la suite
         */
        public GestionListeImport(ArrayList entryList, GestionListeImages images)
        {
            ListeImgImport = images;
            ListeImg = new ArrayList();
            foreach (string img in entryList)
            {
                //ListeImg.Add(new GestionImage(img));
                ListeImg.Add(img);
            }
        }
        public void importer()
        {
            Thread th = new Thread(Importation);
            th.Start();
        }
        /*
         * permet d'importer les gestionImage de la liste dans le dossier d'importation
         */
        private void Importation()
        {
            foreach (string img in ListeImg)
            {
                Char delim = '\\';
                string url = img;//.ImgUrl;
                string[] nom = url.Split(delim);
                string name = nom[nom.Count() - 1];
                string saveUrlDos = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                saveUrlDos = Path.Combine(saveUrlDos, "FHRImages");
                string saveUrl = Path.Combine(saveUrlDos, name);
                string[] decompositionName = name.Split('.');
                if (decompositionName[decompositionName.Count() - 1] == "jpg" || decompositionName[decompositionName.Count() - 1] == "JPG")
                {
                    try
                    {
                        System.IO.File.Copy(img/*.ImgUrl*/, saveUrl, false);
                    }
                    catch (System.IO.DirectoryNotFoundException)
                    {
                        System.IO.Directory.CreateDirectory(saveUrlDos);
                        System.IO.File.Copy(img/*.ImgUrl*/, saveUrl, false);
                    }
                    catch (System.IO.IOException)
                    {
                        Image image = Image.FromFile(img);
                        FormImageExistante form = new FormImageExistante(image, ListeImgImport.rechercheImage(saveUrl));
                        DialogResult res = form.ShowDialog();
                        if (res == DialogResult.Cancel)
                        {
                            System.Console.WriteLine("cancel : 1");
                        }
                        else
                        {
                            if (res == DialogResult.Ignore)
                            {
                                System.Console.WriteLine("ignore : 3");
                            }
                            else
                            {
                                System.Console.WriteLine("abort : 2");
                            }
                        }
                        image = null;
                    }
                }
            }
        }
    }
}