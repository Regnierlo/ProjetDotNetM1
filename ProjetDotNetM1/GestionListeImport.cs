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
        /// <summary>
        /// creer un liste de GestionImage a partir d'une array list afin de réaliser une importation par la suite
        /// </summary>
        /// <param name="entryList"></param>
        /// <param name="images"></param>
        public GestionListeImport(ArrayList entryList, GestionListeImages images)
        {
            ListeImgImport = images;
            ListeImg = entryList;
        }
        public void Importer()
        {
            Thread th = new Thread(Importation);
            th.Start();
        }

        /// <summary>
        /// permet d'importer les gestionImage de la liste dans le dossier d'importation
        /// </summary>
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
                        FileStream fs = new FileStream(img, FileMode.Open);
                        Image image = Image.FromStream(fs);
                        FileStream fs2 = new FileStream(saveUrl, FileMode.Open);
                        Image image2 = Image.FromStream(fs);
                        fs.Close();
                        fs2.Close();
                        FormImageExistante form = new FormImageExistante(image, image2);
                        DialogResult res = form.ShowDialog();
                        image.Dispose();
                        image2.Dispose();
                        if (res == DialogResult.Cancel)
                        {
                            System.Console.WriteLine("Garde l'image déjà présente dans le répertoire");
                        }
                        else
                        { 
                            if (res == DialogResult.Ignore)
                            {
                                System.Console.WriteLine("Force la copie en écrasant l'image");
                                System.IO.File.Copy(img/*.ImgUrl*/, saveUrl, true);
                            }
                            else
                            {  
                                System.Console.WriteLine("Confirmation de l'image avec ajout du parenthesage " + name);
                                System.Text.RegularExpressions.Regex myRegex = new Regex(@"(\([0-9]+\).JPG)");
                                System.Text.RegularExpressions.Regex myRegex2 = new Regex(@"(\([0-9]+\))");
                                if (myRegex.IsMatch(name))
                                {
                                    string[] substrings = myRegex2.Split(name);
                                    string number = "";
                                    number = substrings[substrings.Length - 2].Substring(1, substrings[substrings.Length - 2].Length - 2);
                                    int nombre = Int32.Parse(number) + 1;
                                    number = "(" + nombre + ")";
                                    substrings[substrings.Length - 2] = number;
                                    string nouveauName = "";
                                    foreach (string tmp in substrings)
                                    {
                                        nouveauName = nouveauName + tmp;
                                    }
                                    string nouveauSaveUrl = Path.Combine(saveUrlDos, nouveauName);
                                    System.IO.File.Copy(img/*.ImgUrl*/, nouveauSaveUrl, false);
                                }
                                else //cas  zero
                                {
                                    string[] fragmentName = name.Split('.');
                                    string nouveauName = "";
                                    foreach (string str in fragmentName)
                                    {
                                        if (str == "jpg" | str == "JPG")
                                        {
                                            nouveauName = nouveauName + "(1)." + str;
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
                    image.Dispose();
                    }
                }
            }
        }
    }
}
