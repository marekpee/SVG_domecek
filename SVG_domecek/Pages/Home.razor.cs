using SVG_domecek.Models;

namespace SVG_domecek.Pages
{
    public partial class Home
    {
        protected override void OnInitialized()
        {
            base.OnInitialized();
            PridatObrazec();

        }
        public int SvgWidth { get; set; } = 1000;
        public int SvgHeight { get; set; } = 600;

        public List<Obrazec> SvgObrazceList = new List<Obrazec>();
        public int PosunKrok { get; set; } = 20;

        Obrazec obrazec = null;

        private void PridatObrazec()
        {
            obrazec = new Ctverec(100, 100, System.Drawing.Color.Blue, 1, 100);
            SvgObrazceList.Add(obrazec);
            obrazec = new Obdelnik(100, 100, System.Drawing.Color.Red, 0, 50, 150);
            SvgObrazceList.Add(obrazec);
            obrazec = new Obdelnik(400, 100, System.Drawing.Color.Red, 0, 50, 150);
            SvgObrazceList.Add(obrazec);
        }

       public void PosunL()
        {
                foreach(var item in SvgObrazceList)
                {
                    item.PosunDoleva(PosunKrok,SvgWidth,SvgHeight,80);
                }
            }
        public void PosunR()
        {
            foreach (var item in SvgObrazceList)
            {
                item.PosunDoprava(PosunKrok, SvgWidth, SvgHeight, -80);
            }
        }
   
    }
}
  


    

