using AtikToplama.Interfaces;
using System.Drawing;

namespace AtikToplama.Classes
{

    // We use enumaration for Waste Types
    public enum Tur
    {
        Cam,
        Metal,
        Kagit,
        Organik,
        Diger
    };
    class Atik : IAtik
    {  
        
        public int Hacim { get; set; }
        public Image Image { get; set; }

        
        private string _adi;
        public string Adi
        {
            get { return _adi; }
            set { _adi = value; }
        }

        private Tur _atikTuru;
        public Tur AtikTuru
        {
            get { return _atikTuru; }
            set { _atikTuru = value; }
        }

        
        public Atik()
        {
            this.Hacim = 0;
            this.Image = null;
            this.Adi = "Belirsiz";
            this.AtikTuru = Tur.Diger;
        }

        public Atik(int hacim, Image image, string adi, Tur tur)
        {
            this.Hacim = hacim;
            this.Adi = adi;
            this.Image = image;
            this.AtikTuru = tur;
        }
    }
}
