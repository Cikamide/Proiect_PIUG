using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiugTest
{
    public class BuildPredefinit
    {
        public string Nume { get; set; }
        public Procesor Procesor { get; set; }
        public Cooler Cooler { get; set; }
        public PlacaDeBaza PlacaDeBaza { get; set; }
        public RAM RAM { get; set; }
        public Storage Storage { get; set; }
        public PlacaVideo PlacaVideo { get; set; }
        public Sursa Sursa { get; set; }
        public Carcasa Carcasa { get; set; }

        public decimal TotalPret => Procesor.Pret + Cooler.Pret + PlacaDeBaza.Pret + RAM.Pret + Storage.Pret + PlacaVideo.Pret + Sursa.Pret + Carcasa.Pret;
    }
}
