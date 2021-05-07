using AtikToplama.Interfaces;
using System.Collections.Generic;

namespace AtikToplama.Classes
{
    class MetalKutusu: IAtikKutusu
    {
        public const int KAPASITE = 2300;
        public const int BPUAN = 800;

        public int BosaltmaPuani { get; set; }

        public int Kapasite { get; set; }

        public int DoluHacim { get; set; }

        public int DolulukOrani { get; set; }

        public bool Bosalt()
        {
            this.DolulukOrani = 0;
            this.DoluHacim = 0;
            this.BosaltmaPuani = BPUAN;
            this.Atik.Clear();
            return true;
        }

        public bool Ekle(Atik atik)
        {
            if (this.Kapasite > atik.Hacim && this.Kapasite - atik.Hacim >= 0)
            {
                this.DoluHacim += atik.Hacim;
                float oran = this.DoluHacim;
                oran /= this.Kapasite;
                oran *= 100;
                if (oran > 100)
                {
                    return false;
                }
                this.DolulukOrani = (int)oran;
                this.BosaltmaPuani += atik.Hacim;
                this.Atik.Add(atik);
               
                return true;
            }
            return false;
        }

        private List<Atik> _atik;
        public List<Atik> Atik
        {
            get { return _atik; }
            set { _atik = value; }
        }

        public MetalKutusu()
        {
            this.BosaltmaPuani = BPUAN;
            this.Kapasite = KAPASITE;
            this.Atik = new List<Atik>();
        }
    }
}
