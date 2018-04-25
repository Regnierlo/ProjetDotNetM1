using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetDotNetM1
{
    public partial class Form2 : Form
    {/// <summary>
    /// La fenètre Form 2 permet d'afficher une image en plein écran.
    /// </summary>
    /// <param name="urlImg"></param>
    /// <param name="orient"></param>
        public Form2(string urlImg, int orient)
        {
            InitializeComponent();
            afficheImage(urlImg, orient);
        }
        private void afficheImage(string url,int orientation) { 
            FileStream fs = new FileStream(url, FileMode.Open);
        Image image = Image.FromStream(fs);
        fs.Close();
        int larg;
        int haut;
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
                haut = pictureBox1.Height;
                largD = (double)image.Width / (double)image.Height * pictureBox1.Height;
                larg = (int)largD;
            }
            else
            {
                larg = pictureBox1.Width;
                double hautD = (double)image.Height/ (double)image.Width * pictureBox1.Height;
                haut = (int)hautD;
            }
    
            pictureBox1.Image = new Bitmap(image, new Size(larg, haut));
            image.Dispose();

        }
            private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
