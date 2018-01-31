using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace ProjetDotNetM1
{
    class GestionImage
    {
        public List<string> Tag
        {
            get;
            set;
        }
        public string ImgUrl
        {
            get;
            set;
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="image"></param>
        public GestionImage(string image)
        {
            this.ImgUrl = image;
            Tag = RecupTag();
        }

        /// <summary>
        /// prend une chaine de caractere en parametre et la transforme en tableau de byte pret a etre inserer dans les metadonnees  
        /// contient deja les 2 zero finaux obligatoire dans les métadonnées
        /// </summary>
        /// <param name="entry"></param>
        /// <returns></returns>
        private Byte[] String2Byte(string entry)
        {
            int longueur = entry.Length * 2 + 2;
            Byte[] res = new Byte[longueur];
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = 0;
                if (i % 2 == 0)
                {
                    if (i / 2 < entry.Length)
                    {
                        res[i] = (Byte)entry[i / 2];
                    }
                }
            }
            return res;
        }

        /// <summary>
        /// prend un tableau de byte comme ceux présent dans le metadonnée en paramètre et le transforme en string.
        /// </summary>
        /// <param name="entry"></param>
        /// <returns></returns>
        private string Byte2String(Byte[] entry)
        {
            string res = "";
            foreach (int i in entry)
            {
                if (i != 0)
                {
                    res = res + Convert.ToChar(i);
                }
            }
            return res;
        }

        /// <summary>
        /// permet de recuperer les Tag d'une image et de les retourner sous la forme d'une ArrayList
        /// 0x9C9E est le code corespondant au tag des données exif
        /// </summary>
        /// <returns></returns>
        public List<string> RecupTag()
        {
            Image img = Image.FromFile(ImgUrl);
            try
            {
                var propItem = img.GetPropertyItem(0x9C9E);
                string resS = Byte2String(propItem.Value);
                Char delim = ';';
                String[] substrings = resS.Split(delim);
                List<string> res = new List<string>();
                foreach (var substring in substrings)
                {
                    res.Add(substring);
                }
                img.Dispose();
                return res;
            }
            catch
            {
                img.Dispose();
                return new List<string>();
            }
        }

        /// <summary>
        /// permet de remplacer les tags existant de l'image par les tag contenue dans l'ArrayList en entree
        /// essaie d'ajouter un tag existant et si une exeption null est levée (donc aucun tag existant) 
        /// récupère une structure de métadonnées sur une image qui en contient et la modifie pour l'appliquer a la nouvelle image
        /// </summary>
        /// <param name="entry"></param>
        public void AjoutTag(ArrayList entry)
        {
            Image img = Image.FromFile(ImgUrl);
            try
            {
                var propItem = img.GetPropertyItem(0x9C9E);
                string tags = "";
                int cmp = 0;
                foreach (int tag in entry)
                {
                    cmp++;
                    tags = tags + tag;
                    if (cmp < entry.Count)
                    {
                        tags = tags + ";";
                    }
                }
                byte[] res = String2Byte(tags);
                propItem.Value = res;
                img.SetPropertyItem(propItem);
                img.Save(ImgUrl, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception)
            {
                Bitmap imgRe = new Bitmap(ProjetDotNetM1.Properties.Resources.remplacement_remplacement_image);
                Image imgRef = ProjetDotNetM1.Properties.Resources.remplacement_remplacement_image;
                var propItem = imgRef.GetPropertyItem(0x9C9E);
                string tags = "";
                int cmp = 0;
                foreach (string cmptag in entry)
                {
                    cmp++;
                    tags = tags + cmptag;
                    if (cmp < entry.Count)
                    {
                        tags = tags + ";";
                    }
                }
                byte[] res = String2Byte(tags);
                propItem.Value = res;
                img.SetPropertyItem(propItem);
                SaveImg(img);
            }
            img = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        /// <summary>
        /// permet de sauvegarder une image sous le meme nom que l'ancien (Image.FromFile garde le flux ouvert )
        /// </summary>
        /// <param name="img"></param>
        private void SaveImg(Image img)
        {
            string imgUrl2 = ImgUrl.Insert(ImgUrl.Length - 4, "a");
            img.Save(imgUrl2, System.Drawing.Imaging.ImageFormat.Jpeg);
            img = Image.FromFile(imgUrl2);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.IO.File.Delete(ImgUrl);
            img.Save(ImgUrl, System.Drawing.Imaging.ImageFormat.Jpeg);
            img = null;// Image.FromFile(ImgUrl);
            GC.Collect();
            GC.WaitForPendingFinalizers();
            System.IO.File.Delete(imgUrl2);
        }
    }
}
