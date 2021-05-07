using AtikToplama.Classes;

namespace AtikToplama.Interfaces
{
    interface IAtikKutusu : IDolabilen
    {
       
        int BosaltmaPuani { get; }
        
        bool Ekle(Atik atik);
       
        bool Bosalt();
    }
}
