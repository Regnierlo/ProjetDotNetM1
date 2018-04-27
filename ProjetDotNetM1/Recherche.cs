using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ProjetDotNetM1
{
    class Recherche
    {
        /// <summary>
        /// Permet de faire une recherche sur les noms des photos et les tags associés
        /// </summary>
        /// <param name="rechercheUtilisateur">Chaine entrée par l'utilisateur pour la recherche</param>
        /// <param name="images">Liste des images où on va chercher</param>
        /// <returns>Liste d'image à afficher</returns>
        public List<GestionImage> RechercheTous(string rechercheUtilisateur, GestionListeImages images)
        {
            List<GestionImage> limage = new List<GestionImage>();

            //Nom photos
            List<GestionImage> tmp = RecherchePhotos(rechercheUtilisateur, images);//On effectue une recherche sur les noms des photos
            foreach (GestionImage img in tmp)//On les ajoutes
            {
                limage.Add(img);
            }

            //Tags photos
            tmp = RechercheTags(rechercheUtilisateur, images);//on effectue une recherche sur les tags d'une photos
            limage.AddRange(tmp);//On fusionne les deux listes (noms photos + tags photos)

            limage = EnleverDoubleImageListe(limage);//On enlève les doublons

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
            limage = EnleverDoubleImageListe(limage);
            return limage;
        }

        public List<GestionImage> RechercheTags(string rechercheUtilisateur, GestionListeImages images)
        {
            List<GestionImage> limage = new List<GestionImage>();

            string pat = @"(\w*)" + rechercheUtilisateur + @"(\w*)";//Pattern pour l'expression régulière

            Regex reg = new Regex(pat, RegexOptions.IgnoreCase);//On ignore la case

            Boolean tagPresent;//Pour vérifier si le tag est présent dans la photo

            foreach (GestionImage img in images.ListeImg)
            {
                tagPresent = false;//On suppose que le tag n'est pas présent
                foreach (string tag in img.Tag)
                {
                    Match m = reg.Match(tag);//On tente de trouver des photos avec le tag
                    while (m.Success)//Si il y en a
                    {
                        tagPresent = true;//On l'indique
                        m = m.NextMatch();//Et on passe au suivant
                    }

                    if (tagPresent)//Si le tag est présent
                    {
                        limage.Add(img);//On ajoute l'image à la liste
                    }
                }
            }
            limage = EnleverDoubleImageListe(limage);
            return limage;
        }

        /// <summary>
        /// On effectue une recherche sur le tag avec le treeView
        /// </summary>
        /// <param name="selectedNode"></param>
        /// <param name="images"></param>
        /// <returns></returns>
        public List<GestionImage> RechercheTagsTreeView(TreeNode selectedNode, GestionListeImages images)
        {
            List<GestionImage> limage = new List<GestionImage>();

            foreach (TreeNode childNode in selectedNode.Nodes)//Pour tous les fils du noeud
            {
                limage.AddRange(RechercheTags(childNode.Text, images));//On fusionne la liste présente avec celle retourné après une recherche sur les fils
                if (childNode.Nodes != null)//Si le fils à des fils lui aussi
                    limage.AddRange(RechercheTagsTreeView(childNode, images));//On fait une recherche sur le fils du coup
            }

            limage = EnleverDoubleImageListe(limage);//On enlève les doublons

            return limage;
        }

        /// <summary>
        /// On supprime les doublons de la liste
        /// </summary>
        /// <param name="limage">La liste où on va enlever les doublons</param>
        /// <returns>On retourne la liste sans les doublons</returns>
        private List<GestionImage> EnleverDoubleImageListe(List<GestionImage> limage)
        {
            Boolean imagePresente;//Pour savoir si l'image est présente
            List<string> imagesAEnlever = new List<string>();//Liste des images à enlever
            for (int i = 0; i < limage.Count - 1; i++)
            {
                imagePresente = false;//On suppose qu'elle n'existe pas déjà
                for (int j = i + 1; j < limage.Count; j++)
                {
                    if (limage[i].ImgUrl == limage[j].ImgUrl)//Si l'URL est la même (donc même image)
                    {
                        imagePresente = true;//On l'indique
                    }
                }

                if (imagePresente)//Si elle est présente
                    imagesAEnlever.Add(limage[i].ImgUrl);//On indique l'url à supprimer
            }

            Boolean enlever;//Savoir si c'est enlevé
            int k;
            for (int i = 0; i < imagesAEnlever.Count; i++)//Pour toutes les images à enlever
            {
                enlever = false;//On suppose qu'elle est pas encore enlevée
                k = 0;
                while (!enlever)//Tant que c'est pas enlevé
                {
                    if (limage[k].ImgUrl == imagesAEnlever[i])//On compare les URL
                    {
                        limage.RemoveAt(k);//Si c'est les mêmes, on supprime
                        enlever = true;//On indique que c'est enlevé
                    }
                }
            }

            return limage;
        }
    }
}