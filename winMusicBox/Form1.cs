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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Müzik Seç mp3/wav";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Multiselect = true;
            ofd.RestoreDirectory = true;
            ofd.Filter = "Muzik Dosyaları(*.mp3;*.wav)|*.mp3;*.wav";
            ofd.FilterIndex = 1;

            // if içinde ilk metot çalışır(ShowDialog) ardından koşul kontrol edilir.
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string[] dosyalar = ofd.FileNames;

                foreach (string dosyaKonum in dosyalar)
                {
                    System.IO.FileInfo dosya = new System.IO.FileInfo(dosyaKonum);
                    Muzik muzik = new Muzik(dosya.Name, dosya.FullName, dosya.Extension);

                    lstMuzikler.Items.Add(muzik);
                }

            }

        }

        private void mnuAyarlar_Click(object sender, EventArgs e)
        {
            Form2 ayarlarForm = new Form2();
            ayarlarForm.ShowDialog();

            string secilenKonum = ayarlarForm.SecilenResimDosyasiKonumu;

            this.BackgroundImage = Image.FromFile(secilenKonum);
            this.BackgroundImageLayout = ImageLayout.Stretch;    
        }
    }
}
