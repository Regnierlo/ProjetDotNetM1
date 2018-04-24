using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ProjetDotNetM1
{
    class Recherche
    {
        public List<GestionImage> RechercheTous(string rechercheUtilisateur, GestionListeImages images)
        {
            List<GestionImage> limage = new List<GestionImage>();

            //Nom photos
            List<GestionImage> tmp = RecherchePhotos(rechercheUtilisateur, images);
            foreach (GestionImage img in tmp)
            {
                limage.Add(img);
            }

            //Tags photos
            tmp = RechercheTags(rechercheUtilisateur, images);
            limage.AddRange(tmp);
            Boolean imagePresente;
            List<string> imagesAEnlever = new List<string>();
            for (int i = 0; i < limage.Count - 1; i++)
            {
                imagePresente = false;
                for (int j = i + 1; j < limage.Count; j++)
                {
                    if (limage[i].ImgUrl == limage[j].ImgUrl)
                    {
                        imagePresente = true;
                    }
                }

                if (imagePresente)
                    imagesAEnlever.Add(limage[i].ImgUrl);
            }

            Boolean enlever;
            int k;
            for (int i = 0; i < imagesAEnlever.Count; i++)
            {
                enlever = false;
                k = 0;
                while(!enlever)
                {
                    if (limage[k].ImgUrl == imagesAEnlever[i])
                    {
                        limage.RemoveAt(k);
                        enlever = true;
                    }
                }
            }

            return limage;
        }

        /// <summary>
        /// Permet de lister les photos avec leurs nom
        /// </summary>
        /// <param name="rechercheUtilisateur"></param>
        /// <param name="images"></param>
        /// <returns></returns>
        public List<GestionImage> RecherchePhotos(string rechercheUtilisateur, GestionListeImages images)
        {
            List<GestionImage> limage = new List<GestionImage>();
            
            string pat = @"(\w*)" + rechercheUtilisateur + @"(\w*)";//Creation du pattern de l'expression reguliere

            Regex reg = new Regex(pat, RegexOptions.IgnoreCase);//On donne le pattern au constructure et on ignore la case

            string[] decompositionNom;
            string[] tnom;

            foreach (GestionImage img in images.ListeImg)//Pour toutes les images
            {
                //On récupère le nom
                decompositionNom = img.ImgUrl.Split('\\');
                tnom = decompositionNom[decompositionNom.Length - 1].Split('.');

                //On compare le pattern avec le nom de l'image
                Match m = reg.Match(tnom[0]);
                while (m.Success)//Si c'est bon -> la chaine du pattern est présente dans le nom
                {
                    limage.Add(img);//On l'ajoute à la liste
                    m = m.NextMatch();//On passe à la suite
                }
            }

            return limage;
        }

        public List<GestionImage> RechercheTags(string rechercheUtilisateur, GestionListeImages images)
        {
            List<GestionImage> limage = new List<GestionImage>();

            string pat = @"(\w*)" + rechercheUtilisateur + @"(\w*)";

            Regex reg = new Regex(pat, RegexOptions.IgnoreCase);

            Boolean tagPresent;

            foreach (GestionImage img in images.ListeImg)
            {
                tagPresent = false;
                foreach (string tag in img.Tag)
                {
                    Match m = reg.Match(tag);
                    while (m.Success)
                    {
                        Console.WriteLine("Tag de la photo : " + m.ToString());
                        tagPresent = true;
                        m = m.NextMatch();
                    }

                    if (tagPresent)
                    {
                        limage.Add(img);
                    }
                }
            }

            Console.WriteLine("\n\n-------------------------\n\n");

            return limage;
        }

        public void expReg(string s, GestionListeImages images)
        {
            string pat = @"(\w*)" + s + @"(\w*)";

            Regex reg = new Regex(pat, RegexOptions.IgnoreCase);

            Boolean tagPresent;

            foreach (GestionImage img in images.ListeImg)
            {
                tagPresent = false;
                foreach (string tag in img.Tag)
                {
                    Match m = reg.Match(tag);
                    while (m.Success)
                    {
                        Console.WriteLine("Tag de la photo : " + m.ToString());
                        tagPresent = true;
                        m = m.NextMatch();
                    }

                    if (tagPresent)
                    {
                        Console.WriteLine("Nom de la photo : " + img.ImgUrl);
                    }
                }
            }

            Console.WriteLine("\n\n-------------------------\n\n");
        }
    }
}