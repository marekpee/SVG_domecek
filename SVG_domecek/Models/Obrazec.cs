using System.Drawing;

namespace SVG_domecek.Models
{
    public abstract class Obrazec
    {
        public Obrazec (int pozX, int pozY, Color barva, int typObrazce)
        {
            PozX = pozX;
            PozY = pozY;
            Barva = barva;
            TypObrazce = typObrazce;
        }
        public int TypObrazce { get; set; }
        public int PozX { get; set; }
        public int PozY { get; set;}
        public Color Barva { get; set; }

        public void PosunDoprava(int krok, int svgWidth, int svgHeight, int vychoziPozice)
        {
            PozX += krok;
            if (PozX >= svgWidth)
            {
                PozX = vychoziPozice;
            }
        }
        public void PosunDoleva(int krok, int svgWidth, int svgHeight, int vychoziPozice)
        {
            PozX -= krok;
            if (PozX <= 0)
            {
                PozX = svgWidth-20;
            }
        }

    }
}
