using System;
using System.Linq;
using System.Collections;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Text.RegularExpressions;

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
            string saveUrlDos = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            saveUrlDos = Path.Combine(saveUrlDos, "FHRImages");
            Char delim = '\\';
            foreach (string img in ListeImg)
            {
                string url = img;//.ImgUrl;
                string[] nom = url.Split(delim);
                string name = nom[nom.Count() - 1];
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
                        Image image2 = Image.FromFile(saveUrl);
                        FormImageExistante form = new FormImageExistante(image, image2);
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
                                System.IO.File.Copy(img/*.ImgUrl*/, saveUrl, true);
                            }
                            else
                            {
                                System.Console.WriteLine("abort : 2 : "+name);
                                System.Text.RegularExpressions.Regex myRegex = new Regex(@"(\([0-9]+\).JPG)");
                                System.Text.RegularExpressions.Regex myRegex2 = new Regex(@"(\([0-9]+\))");
                                if (myRegex.IsMatch(name))
                                {
                                    string[] substrings = myRegex2.Split(name);
                                    string number = "";
                                    number = substrings[substrings.Length - 2].Substring(1, substrings[substrings.Length - 2].Length-2);
                                    int nombre = Int32.Parse(number) + 1;
                                    number = "(" + nombre + ")";
                                    substrings[substrings.Length-2]= number;
                                    string nouveauName = "";
                                    foreach(string tmp in substrings)
                                    {
                                        nouveauName = nouveauName + tmp;
                                    }
                                    string nouveauSaveUrl = Path.Combine(saveUrlDos, nouveauName);
                                    System.IO.File.Copy(img/*.ImgUrl*/, nouveauSaveUrl, false);
                                }
                                else
                                {
                                    string[] fragmentName = name.Split('.');
                                    string nouveauName = "";
                                    foreach(string str in fragmentName){
                                        if(str == "jpg" | str == "JPG")
                                        {
                                            nouveauName = nouveauName + "(1)."+str;
                                        }
                                        else
                                        {
                                            nouveauName = nouveauName + str;
                                        }
                                    }
                                    string nouveauSaveUrl = Path.Combine(saveUrlDos, nouveauName);
                                    System.IO.File.Copy(img/*.ImgUrl*/, nouveauSaveUrl, false);
                                }
                            }
                        }
                        image = null;
                    }
                }
            }
        }
    }
}
