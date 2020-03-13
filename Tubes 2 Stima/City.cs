using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_2_Stima
{

    class City
    {
        // Konstruktor kelas City
        public City(string _name, int _population)
        {
            Name = _name;
            Population = _population;
        }
        public string Name { get; set; } // Nama sebuah kota
        public int Population { get; set; } // Populasi sebuah kota
        // List tuple dari kota tetangga dan peluang orang melakakukan perpindahan
        public List<Tuple<string, double>> Adj { get; } = new List<Tuple<string, double>>();

        /// <summary>
        /// Menambahkan kota tetangga dari kota ini dengan nama kota tujuan dan peluang perpindahannya
        /// </summary>
        /// <param name="cityTo">Kota tujuan</param>
        /// <param name="tr">Peluang perpindahan ke kota tujuan</param>
        public void AddAdj(string cityTo, double tr)
        {
            Adj.Add(new Tuple<string, double>(cityTo, tr));
        }

        /// <summary>
        /// Mengembalikan banyak populasi yang terkena infeksi. Rumus yang digunakan seperti 
        /// fungsi I pada spek tubes
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        public double PopulationGetInfected(int time)
        {
            double power = Math.Pow(Math.E, (-0.25*time));
            double res = Population/(1+((Population-1)*power));

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
            double Tr = 0;
            foreach(var element in Adj)
            {
                if(element.Item1 == cityTo)
                {
                    Tr = element.Item2;
                    break;
                }
            }

            double res = PopulationGetInfected(time)*Tr;
            return res;
        }

        /// <summary>
        /// Mengembalikan waktu kapan kota tujuan terinfeksi.
        /// </summary>
        /// <param name="cityTo"></param>
        /// <returns></returns>
        public double TimeCityToGetInfected(string cityTo)
        {
            double Tr = 0;
            foreach(var element in Adj)
            {
                if(element.Item1 == cityTo)
                {
                    Tr = element.Item2;
                    break;
                }
            }

            double val = (Population*Tr-1)/(Population-1);
            double time = Math.Log(val) / -0.25;
            return time;
        }
    }
}