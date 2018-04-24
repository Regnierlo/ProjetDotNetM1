using System;
using System.Collections.Generic;
using System.IO;

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
            Boolean imagePresente = false;
            List<int> imagesAEnlever = new List<int>();
            for (int i = 0; i < limage.Count - 1; i++)
            {
                for (int j = i + 1; j < limage.Count; j++)
                {
                    if (limage[i].ImgUrl == limage[j].ImgUrl)
                    {
                        imagePresente = true;
                    }
                }

                if (imagePresente)
                    imagesAEnlever.Add(i);
            }

            for (int i = 0; i < imagesAEnlever.Count; i++)
            {
                limage.RemoveAt(i);
            }

            return limage;
        }

        public List<GestionImage> RecherchePhotos(string rechercheUtilisateur, GestionListeImages images)
        {
            List<GestionImage> limage = new List<GestionImage>();
            string[] decompositionNom;
            string[] tnom;

            foreach (GestionImage img in images.ListeImg)
            {

                decompositionNom = img.ImgUrl.Split('\\');
                tnom = decompositionNom[decompositionNom.Length - 1].Split('.');

                if (tnom[0] == rechercheUtilisateur)
                    limage.Add(img);
            }

            return limage;
        }

        public List<GestionImage> RechercheTags(string rechercheUtilisateur, GestionListeImages images)
        {
            List<GestionImage> limage = new List<GestionImage>();

            foreach (GestionImage img in images.ListeImg)
            {
                FileStream fs = new FileStream(img.ImgUrl, FileMode.Open);
                //Image image = Image.FromStream(fs);
                fs.Close();

                Boolean tagPresent = false;
                foreach (string tag in img.Tag)
                {
                    if (tag == rechercheUtilisateur)
                    {
                        tagPresent = true;
                    }
                }

                if (tagPresent)
                {
                    limage.Add(img);
                }
            }


            return limage;
        }
    }
}