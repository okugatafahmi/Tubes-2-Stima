﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Tubes_2_Stima
{
    class CityGraph
    {
        private string startNode;

        public int NNode { get; private set; }
        public Dictionary<string, City> CityDict { get; } = new Dictionary<string, City>();
        public int NEdge { get; private set; }

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
                    NNode = Int32.Parse(input[0]);
                    startNode = input[1];
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
            timeCityGetInfected[startNode] = 0;

            // Setiap kota yang bertetanggaan dengan kota pertama dimasukkan queue
            foreach (Tuple<string, double> adj in CityDict[startNode].Adj)
            {
                nodeAlive.Enqueue(new Tuple<string, string>(startNode, adj.Item1));
            }

            // mentraversal node sampai kosong
            while (nodeAlive.Count != 0)
            {
                string from = nodeAlive.Peek().Item1, to = nodeAlive.Peek().Item2;
                int timeRemain = timeTotal - timeCityGetInfected[from];
                City cityFrom = CityDict[from];

                if (cityFrom.VirusSpread(to, timeRemain) > 1.0)
                {
                    int timeSpread = (int) Math.Ceiling(cityFrom.TimeCityToGetInfected(to));

                    int timeCityToInfected = timeCityGetInfected[to];
                    int timeCityFromInfected = timeCityGetInfected[from];
                    timeCityGetInfected[to] = timeCityFromInfected + timeSpread;
                    if (timeCityFromInfected + timeSpread < timeCityToInfected)
                    {
                        foreach (Tuple<string, double> adj in CityDict[to].Adj)
                        {
                            nodeAlive.Enqueue(new Tuple<string, string>(to, adj.Item1));
                        }
                    }
                    res.Add(new Tuple<Tuple<string, string>,int>(new Tuple<string,string>(from, to),timeCityFromInfected + timeSpread));
                }
                nodeAlive.Dequeue();
            }
            return res;
        }
    }
}
