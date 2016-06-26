using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winMusicBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string SecilenResimDosyasiKonumu { get; set; }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Resim Seç";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Multiselect = true;
            ofd.RestoreDirectory = true;
            ofd.Filter = "Resim Dosyaları(*.jpg;*.png;*.jpeg)|*.jpg;*.png;*.jpeg";
            ofd.FilterIndex = 1;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (string dosyaKonum in ofd.FileNames)
                {
                    System.IO.FileInfo dosya = new System.IO.FileInfo(dosyaKonum);
                    Resim res = new Resim(dosya.Name, dosya.FullName);

                    lstResimler.Items.Add(res);

                    PictureBox picbox = new PictureBox();
                    picbox.Width = 75;
                    picbox.Height = 75;
                    picbox.ImageLocation = dosya.FullName;
                    picbox.BorderStyle = BorderStyle.FixedSingle;
                    picbox.SizeMode = PictureBoxSizeMode.Zoom;

                    pnlResimler.Controls.Add(picbox);
                }
            }
        }

        private void btnArkaplanYap_Click(object sender, EventArgs e)
        {
            Resim resimObj = (Resim)lstResimler.SelectedItem;

            SecilenResimDosyasiKonumu = resimObj.Konumu;

            this.Close();
        }
    }
}
