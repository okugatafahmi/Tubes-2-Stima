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
        /// Melakukan traversal graph dengan algoritma BFS yang sesuai dengan spek tubes
        /// </summary>
        public void BFS()
        {

        }
    }
}
