using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDotNetM1
{
    public partial class Form2 : Form
    {

        /// <summary>
        /// La fenètre Form 2 permet d'afficher une image en plein écran.
        /// </summary>
        /// <param name="urlImg"></param>
        /// <param name="orient"></param>
        public Form2(string urlImg, int orient)
        {
            InitializeComponent();
            AfficheImage(urlImg, orient);
        }

        private void AfficheImage(string url, int orientation)
        {
            FileStream fs = new FileStream(url, FileMode.Open);
            Image image = Image.FromStream(fs);
            fs.Close();
            int larg;
            int haut;

            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            PictureBox1.Image = new Bitmap(image, new Size(PictureBox1.Width, PictureBox1.Height));

            switch (orientation)
            {
                case 6:
                    image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                    break;
                case 8:
                    image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                    break;
                case 2:
                    //affichage optimal non garanti 
                    image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                    break;
                case 3:
                    image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    break;
                case 4:
                    //affichage optimal non garanti 
                    image.RotateFlip(RotateFlipType.RotateNoneFlipY);
                    break;
                case 5:
                    //affichage optimal non garanti 
                    image.RotateFlip(RotateFlipType.Rotate270FlipX);
                    break;
                case 7:
                    //affichage optimal non garanti 
                    image.RotateFlip(RotateFlipType.Rotate90FlipX);
                    break;
                default:
                    break;
            }
           
             if (image.Height > image.Width)
             {
                 double largD;
                 haut = PictureBox1.Height;
                 largD = (double)image.Width / (double)image.Height * PictureBox1.Height;
                 larg = (int)largD;
             }
             else
             {
                 larg = PictureBox1.Width;
                 double hautD = (double)image.Height / (double)image.Width * PictureBox1.Width;
                 haut = (int)hautD;
             }

             PictureBox1.Image = new Bitmap(image, new Size(larg, haut));
             image.Dispose();

        }       

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
