using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Math;

namespace Tubes_2_Stima
{

static class Constants
{
    public const double e = 2.71828;
}

    class City
    {
        private string name;
        private int population;
        private List<Tuple<string, double>> adj = new List<Tuple<string, double>>();
        public City(string _name, int _population)
        {
            name = _name;
            population = _population;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int Population
        {
            get
            {
                return population;
            }
            set
            {
                population = value;
            }
        }
        public List<Tuple<string, double>> Adj
        {
            get
            {
                return adj;
            }
        }

        /// <summary>
        /// Menambahkan kota tetangga dari kota ini dengan nama kota tujuan dan peluang perpindahannya
        /// </summary>
        /// <param name="cityTo">Kota tujuan</param>
        /// <param name="tr">Peluang perpindahan ke kota tujuan</param>
        public void AddAdj(string cityTo, double tr)
        {
            adj.Add(new Tuple<string, double>(cityTo, tr));
        }

        /// <summary>
        /// Mengembalikan banyak populasi yang terkena infeksi. Rumus yang digunakan seperti 
        /// fungsi I pada spek tubes
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public double PopulationGetInfected(int time)
        {
            double res = 0;
            double power = Math.Pow(Constants.e, (-0.25*time));
            res = population/(1+((population-1)*power));

            return res;
        }

        /// <summary>
        /// Mengembalikan nilai penyebaran virus dari kota ini ke kota tujuan pada suatu waktu. Kota ini dan kota tujuan 
        /// pasti bertetanggan. Rumus yang digunakan seperti fungsi S pada spek tubes
        /// </summary>
        /// <param name="cityTo"></param>
        /// <param name="time"></param>
        /// <returns></returns>
        public double VirusSpread(string cityTo, int time)
        {
            double res = 0;
            return res;
        }

        /// <summary>
        /// Mengembalikan waktu kapan kota tujuan terinfeksi.
        /// </summary>
        /// <param name="cityTo"></param>
        /// <returns></returns>
        public double TimeCityToGetInfected(string cityTo)
        {
            double time = 0;
            return time;
        }
    }
}