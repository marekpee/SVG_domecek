using System.Drawing;

namespace SVG_domecek.Models
{
    public class Ctverec : Obrazec
    {
        public Ctverec(int pozX, int pozY, Color barva, int typObrazce,int stranaA) : base(pozX, pozY, barva, typObrazce)
        {
            StranaA = stranaA;
        }
        public int StranaA { get; set; }
    }
}
