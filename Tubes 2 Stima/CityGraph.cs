using System;
using System.Collections.Generic;
using System.IO;

namespace Tubes_2_Stima
{
    class CityGraph
    {
        private Dictionary<string, City> cityDict = new Dictionary<string, City>();
        private string startNode;
        private int nNode, nEdge;

        /// <summary>
        /// Membaca input dari file kemudian di assign ke field yang bersesuaian
        /// </summary>
        /// <param name="connectionFileName"></param>
        /// <param name="populationFileName"></param>
        public void ReadFromFile(string connectionFileName, string populationFileName)
        {
            string[] inputConnection = File.ReadAllLines(connectionFileName);
            string[] inputPopulation = File.ReadAllLines(populationFileName);

            int count = 0;
            foreach (string inputLine in inputPopulation)
            {
                string[] input = inputLine.Split(' ');
                if (count == 0)
                {
                    nNode = Int32.Parse(input[0]);
                    startNode = input[1];
                }
                else
                {
                    cityDict[input[0]] = new City(input[0], Int32.Parse(input[1]));
                }
                ++count;
            }
            count = 0;
            foreach (string inputLine in inputConnection)
            {
                string[] input = inputLine.Split(' ');
                if (count == 0)
                {
                    nEdge = Int32.Parse(input[0]);
                }
                else
                {
                    cityDict[input[0]].AddAdj(input[1], Double.Parse(input[2]));
                }
                ++count;
            }
            foreach (KeyValuePair<string, City> kp in cityDict)
            {
                Console.WriteLine(kp.Key + ':');
                foreach (Tuple<string, double> k in kp.Value.Adj)
                {
                    Console.WriteLine(k.Item1 + ' ' + k.Item2);
                }
            }
        }

        /// <summary>
        /// Melakukan traversal graph dengan algoritma BFS yang sesuai dengan spek tubes.
        /// Mengembalikan list tuple kota asal dan tujuan yang terinfeksi
        /// </summary>
        /// <param name="timeTotal"></param>
        /// <returns></returns>
        public List<Tuple<string, string>> BFS(int timeTotal)
        {
            Queue<Tuple<string, string>> nodeAlive = new Queue<Tuple<string, string>>();
            Dictionary<string, int> timeCityGetInfected = new Dictionary<string, int>();
            List<Tuple<string, string>> res = new List<Tuple<string, string>>();
            // Inisiasi waktu kota terinfeksi dengan tak hingga
            foreach (string cityName in cityDict.Keys)
            {
                timeCityGetInfected[cityName] = Int32.MaxValue;
            }
            timeCityGetInfected[startNode] = 0;

            // Setiap kota yang bertetanggaan dengan kota pertama dimasukkan queue
            foreach (Tuple<string, double> adj in cityDict[startNode].Adj)
            {
                nodeAlive.Enqueue(new Tuple<string, string>(startNode, adj.Item1));
            }

            // mentraversal node sampai kosong
            while (nodeAlive.Count != 0)
            {
                string from = nodeAlive.Peek().Item1, to = nodeAlive.Peek().Item2;
                int timeFrom = timeTotal - timeCityGetInfected[from];
                City cityFrom = cityDict[from];
                if (cityFrom.VirusSpread(to, timeFrom) > 1.0)
                {
                    res.Add(new Tuple<string, string>(from, to));
                    int timeSpread = (int) Math.Floor(cityFrom.TimeCityToGetInfected(to));
                    int timeCityToInfected = timeCityGetInfected[to];
                    timeCityGetInfected[to] = timeFrom + timeSpread;
                    if (timeFrom + timeSpread < timeCityToInfected)
                    {
                        foreach (Tuple<string, double> adj in cityDict[to].Adj)
                        {
                            nodeAlive.Enqueue(new Tuple<string, string>(startNode, adj.Item1));
                        }
                    }
                }
                nodeAlive.Dequeue();
            }
            return res;
        }
    }
}
