using System.Drawing;

namespace SVG_domecek.Models
{
    public class Obdelnik : Ctverec
    {
        public Obdelnik(int pozX, int pozY, Color barva, int typObrazce, int stranaA, int stranaB) : base(pozX, pozY, barva, typObrazce, stranaA)
        {
            StranaB = stranaB;
        }
        public int StranaB { get; set; }
    }
}
