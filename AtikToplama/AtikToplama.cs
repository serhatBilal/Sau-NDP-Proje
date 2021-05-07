/****************************************************************************
**			    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				NESNEYE DAYALI PROGRAMLAMA DERSİ
**			    2019-2020 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:4(Proje)
**				ÖĞRENCİ ADI............:Serhat BİLAL
**				ÖĞRENCİ NUMARASI.......:B191210309
**              DERSİN ALINDIĞI GRUP...:1A
****************************************************************************/
using AtikToplama.Classes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace AtikToplama
{
    public partial class AtikToplama : Form
    {
        public const int MAKSDOLULUKORANI = 75;

        public Random rastgele=new Random();
        public int index;
        
        private CamKutusu _camKutusu;
        private KagitKutusu _kagitKutusu;
        private OrganikKutusu _organikKutusu;
        private MetalKutusu _metalKutusu= new MetalKutusu();
    
        private List<Atik> _atiklar;
        public AtikToplama()
        {
            InitializeComponent();
        }
        private void AtikToplama_Load(object sender, EventArgs e)
        {
            OyunBasla();
            Yenile();
            PasifEt();
        }

        private void OyunBasla()
        {
            _camKutusu = new CamKutusu();
            _kagitKutusu = new KagitKutusu();
            _organikKutusu = new OrganikKutusu();
            _metalKutusu = new MetalKutusu();

            _atiklar = new List<Atik>()
            {
                new Atik(600, Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\1-cam-sise.png"), "Cam Şişe", Tur.Cam),
                new Atik(250, Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\2-bardak.png"), "Bardak", Tur.Cam),
                new Atik(250, Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\3-gazete.png"), "Gazete", Tur.Kagit),
                new Atik(200, Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\4-dergi.png"), "Dergi", Tur.Kagit),
                new Atik(150, Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\5-domates.png"), "Domates", Tur.Organik),
                new Atik(120, Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\6-salatalik.png"), "Salatalık", Tur.Organik),
                new Atik(350, Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\7-kola_kutusu.png"), "Kola Kutusu", Tur.Metal),
                new Atik(550, Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\8-salca_kutusu.png"), "Salça Kutusu", Tur.Metal)
            };
        }

        private void ResimAtla()
        {
            index = RandomSayi();
            pctrboxResimler.Image = _atiklar[index].Image;
        }

        private int RandomSayi()
        {
            if (_atiklar != null)
            {
                return rastgele.Next(0, _atiklar.Count - 1);
            }
            else
            {
                return 0;
            }

        }
        private void PasifEt()
        {
            pnlCam.Enabled = false;
            pnlKagit.Enabled = false;
            pnlMetal.Enabled = false;
            pnlOrganikAtik.Enabled = false;
            pctrboxResimler.Image = Image.FromFile(System.IO.Directory.GetCurrentDirectory() + "\\Images\\0-beyaz.png");
        }
        private void AktifEt()
        {
            pnlCam.Enabled = true;
            pnlKagit.Enabled = true;
            pnlMetal.Enabled = true;
            pnlOrganikAtik.Enabled = true;
        }
        private void Yenile()
        {
            lstCam.Items.Clear();
            lstKagit.Items.Clear();
            lstMetal.Items.Clear();
            lstOrganikAtik.Items.Clear();
            progresCam.Value = 0;
            progresKagit.Value = 0;
            progresMetal.Value = 0;
            progresOrganikAtik.Value = 0;
        }
        private void RenkAta()
        {
            txtSure.BackColor = Color.Teal;
            txtPuan.BackColor = Color.Teal;
            txtPuan.ForeColor = Color.White;
            txtSure.ForeColor = Color.White;
        }

        private void zaman_Tick(object sender, EventArgs e)
        {
            int zamanAzalt = Convert.ToInt32(txtSure.Text);
            zamanAzalt--;
            txtSure.Text = zamanAzalt.ToString();
            if (zamanAzalt == 0)
            {

                PasifEt();
                zaman.Enabled = false;
            }
        }
        private void btnYeniOyun_Click(object sender, EventArgs e)
        {
            OyunBasla();
            ResimAtla();
            Yenile();
            RenkAta();
            AktifEt();
            txtPuan.Text = "0";
            
            if (txtSure.Text == "0")
            {
                txtSure.Text = "60";
            }
            zaman.Enabled = true;
            zaman.Interval = 1000;
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnCamBosalt_Click(object sender, EventArgs e)
        {
            if (_camKutusu.DolulukOrani >= MAKSDOLULUKORANI)
            {
                _camKutusu.Bosalt();
                txtSure.Text = (int.Parse(txtSure.Text) + 3).ToString();
                txtPuan.Text = (int.Parse(txtPuan.Text) + _camKutusu.BosaltmaPuani).ToString();
                lstCam.Items.Clear();
                progresCam.Value = _camKutusu.DolulukOrani;
            }
        }
        private void btnKagitBosalt_Click(object sender, EventArgs e)
        {
            if (_kagitKutusu.DolulukOrani >= MAKSDOLULUKORANI)
            {
                _kagitKutusu.Bosalt();
                txtSure.Text = (int.Parse(txtSure.Text) + 3).ToString();
                txtPuan.Text = (int.Parse(txtPuan.Text) + _kagitKutusu.BosaltmaPuani).ToString();
                lstKagit.Items.Clear();
                progresKagit.Value = _kagitKutusu.DolulukOrani;
            }
        }
        private void btnOrganikAtıkBosalt_Click(object sender, EventArgs e)
        {
            if (_organikKutusu.DolulukOrani >= MAKSDOLULUKORANI)
            {
                _organikKutusu.Bosalt();
                txtSure.Text = (int.Parse(txtSure.Text) + 3).ToString();
                txtPuan.Text = (int.Parse(txtPuan.Text) + _organikKutusu.BosaltmaPuani).ToString();
                lstOrganikAtik.Items.Clear();
                progresOrganikAtik.Value = _organikKutusu.DolulukOrani;
            }
        }
        private void btnMetalBosalt_Click(object sender, EventArgs e)
        {
            if (_metalKutusu.DolulukOrani > MAKSDOLULUKORANI)
            {
                _metalKutusu.Bosalt();
                txtSure.Text = (int.Parse(txtSure.Text) + 3).ToString();
                txtPuan.Text = (int.Parse(txtPuan.Text) + _metalKutusu.BosaltmaPuani).ToString();
                lstMetal.Items.Clear();
                progresMetal.Value = _metalKutusu.DolulukOrani;
            }
        }
        private void btnCam_Click(object sender, EventArgs e)
        {
            int hacim = _atiklar[index].Hacim;
            if (_atiklar[index].AtikTuru == Tur.Cam)
            {
                bool eklendiMi = _camKutusu.Ekle(_atiklar[index]);
                if (eklendiMi)
                {
                    progresCam.Value = _camKutusu.DolulukOrani;
                    lstCam.Items.Add(_atiklar[index].Adi + "(" + hacim + ")");
                    txtPuan.Text = (Convert.ToInt32(txtPuan.Text) + hacim).ToString();
                    ResimAtla();
                }
                
            }
            
        }
        private void btnOrganikAtik_Click(object sender, EventArgs e)
        {
            int hacim = _atiklar[index].Hacim;
            if (_atiklar[index].AtikTuru == Tur.Organik)
            {
                bool eklendiMi = _organikKutusu.Ekle(_atiklar[index]);
                if (eklendiMi)
                {    
                    progresOrganikAtik.Value = _organikKutusu.DolulukOrani;
                    lstOrganikAtik.Items.Add(_atiklar[index].Adi + "(" + hacim + ")");
                    txtPuan.Text = (Convert.ToInt32(txtPuan.Text) + hacim).ToString();
                    ResimAtla();
                }
                
            }
            
        }
        private void btnKagit_Click(object sender, EventArgs e)
        {
            int hacim = _atiklar[index].Hacim;
            if (_atiklar[index].AtikTuru == Tur.Kagit)
            {
                bool ekliMi = _kagitKutusu.Ekle(_atiklar[index]);
                if (ekliMi)
                {
                    progresKagit.Value = _kagitKutusu.DolulukOrani;
                    lstKagit.Items.Add(_atiklar[index].Adi + "(" + hacim + ")");
                    txtPuan.Text = (Convert.ToInt32(txtPuan.Text) + hacim).ToString();
                    ResimAtla();
                }
                
            }
            
        }
        private void btnMetal_Click(object sender, EventArgs e)
        {
            int hacim = _atiklar[index].Hacim;
            if (_atiklar[index].AtikTuru == Tur.Metal)
            {
                bool eklendiMi = _metalKutusu.Ekle(_atiklar[index]);
                if (eklendiMi)
                {
                    progresMetal.Value = _metalKutusu.DolulukOrani;
                    lstMetal.Items.Add(_atiklar[index].Adi + "(" + hacim + ")");
                    txtPuan.Text = (Convert.ToInt32(txtPuan.Text) + hacim).ToString();
                    ResimAtla();
                }
                
            }
            
        }
    }
}
