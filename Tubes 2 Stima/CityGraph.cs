using System;
using System.Collections.Generic;
using System.IO;

namespace Tubes_2_Stima
{
    class CityGraph
    {
        public int NNode { get; private set; }
        public int NEdge { get; private set; }
        public string StartNode { get; private set; }
        public Dictionary<string, City> CityDict { get; } = new Dictionary<string, City>();

        /// <summary>
        /// Membaca input dari file kemudian di assign ke field yang bersesuaian
        /// </summary>
        /// <param name="connectionFileName"></param>
        /// <param name="populationFileName"></param>
        public void ReadFromFile(string connectionFileName, string populationFileName)
        {
            if (CityDict.Count != 0) CityDict.Clear();
            string[] inputConnection = File.ReadAllLines(connectionFileName);
            string[] inputPopulation = File.ReadAllLines(populationFileName);

            int count = 0;
            foreach (string inputLine in inputPopulation)
            {
                string[] input = inputLine.Split(' ');
                if (count == 0)
                {
                    NNode = Int32.Parse(input[0]);
                    StartNode = input[1];
                }
                else
                {
                    CityDict[input[0]] = new City(input[0], Int32.Parse(input[1]));
                }
                ++count;
            }
            count = 0;
            foreach (string inputLine in inputConnection)
            {
                string[] input = inputLine.Split(' ');
                if (count == 0)
                {
                    NEdge = Int32.Parse(input[0]);
                }
                else
                {
                    CityDict[input[0]].AddAdj(input[1], Double.Parse(input[2]));
                }
                ++count;
            }
            foreach (KeyValuePair<string, City> kp in CityDict)
            {
                Console.WriteLine(kp.Key + ':');
                foreach (Tuple<string, double> k in kp.Value.Adj)
                {
                    Console.WriteLine(k.Item1 + ' ' + k.Item2);
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Melakukan traversal graph dengan algoritma BFS yang sesuai dengan spek tubes.
        /// Mengembalikan list tuple kota asal dan tujuan yang terinfeksi
        /// </summary>
        /// <param name="timeTotal"></param>
        /// <returns></returns>
        public List<Tuple<Tuple<string, string>, int>> BFS(int timeTotal)
        {
            Queue<Tuple<string, string>> nodeAlive = new Queue<Tuple<string, string>>();
            Dictionary<string, int> timeCityGetInfected = new Dictionary<string, int>();
            List<Tuple<Tuple<string, string>, int> > res = new List<Tuple<Tuple<string, string>, int>>();
            // Inisiasi waktu kota terinfeksi dengan tak hingga
            foreach (string cityName in CityDict.Keys)
            {
                timeCityGetInfected[cityName] = Int32.MaxValue;
            }
            timeCityGetInfected[StartNode] = 0;

            // Setiap kota yang bertetanggaan dengan kota pertama dimasukkan queue
            foreach (Tuple<string, double> adj in CityDict[StartNode].Adj)
            {
                nodeAlive.Enqueue(new Tuple<string, string>(StartNode, adj.Item1));
            }

            // mentraversal node sampai kosong
            while (nodeAlive.Count != 0)
            {
                string from = nodeAlive.Peek().Item1, to = nodeAlive.Peek().Item2;
                int timeRemain = timeTotal - timeCityGetInfected[from];
                City cityFrom = CityDict[from];

                Console.Write("Cek penyebaran {0:string} -> {1:string}\n" +
                    "T({0:string}) = {2}\n" +
                    "t({0:string}) = {3}-{2} = {4}\n" +
                    "I({0:string}, {4}) = {5}\n" +
                    "S({0:string}, {1:string}) = I({0:string}, {4}) * Tr({0:string}, {1:string}) = {5} * Trnya = {6}\n",
                    from, to, timeCityGetInfected[from], timeTotal, timeRemain, cityFrom.PopulationGetInfected(timeRemain), 
                    cityFrom.VirusSpread(to,timeRemain));
                if (cityFrom.VirusSpread(to, timeRemain) > 1.0)
                {
                    int timeSpread = (int) Math.Ceiling(cityFrom.TimeCityToGetInfected(to));

                    int timeCityToInfected = timeCityGetInfected[to];
                    int timeCityFromInfected = timeCityGetInfected[from];
                    Console.Write("Karena S({0:string}, {1:string}) > 1, virus " +
                        "berhasil tersebar dari daerah {0:string} ke {1:string}.\n" +
                        "Waktu penyebarannya virus dari daerah {0:string} ke {1:string} adalah {2} sehingga:\n" +
                        "T({1:string}) = {2} + T({0:string}) = {2} + {3} = {4}\n", from, to, timeSpread, timeCityFromInfected, timeCityFromInfected + timeSpread);
                    if (timeCityFromInfected + timeSpread < timeCityToInfected)
                    {
                        timeCityGetInfected[to] = timeCityFromInfected + timeSpread;
                        foreach (Tuple<string, double> adj in CityDict[to].Adj)
                        {
                            Console.WriteLine(to + " -> " + adj.Item1);
                            nodeAlive.Enqueue(new Tuple<string, string>(to, adj.Item1));
                        }
                    }
                    else
                    {
                        Console.Write("Karena T'({0:string}) > T({0:string}) kota yang bertetanggan dengan {0:string} tidak ditambah.\n");
                    }
                    res.Add(new Tuple<Tuple<string, string>,int>(new Tuple<string,string>(from, to),timeCityFromInfected + timeSpread));
                }
                else
                {
                    Console.Write("Karena S({0:string}, {1:string}) < 1, virus " +
                        "tidak berhasil tersebar dari daerah {0:string} ke {1:string}.\n", from, to);
                }
                nodeAlive.Dequeue();
                Console.WriteLine();
            }
            return res;
        }
    }
}
