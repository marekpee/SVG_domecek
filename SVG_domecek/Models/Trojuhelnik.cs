using System.Drawing;

namespace SVG_domecek.Models
{
    public class Trojuhelnik : Obrazec
    {
        public Trojuhelnik(int pozX, int pozY, Color barva, int typObrazce, int points) : base(pozX, pozY, barva, typObrazce)
        {
            Points = points;
        }
        public int Points { get; set; }
    }
}
