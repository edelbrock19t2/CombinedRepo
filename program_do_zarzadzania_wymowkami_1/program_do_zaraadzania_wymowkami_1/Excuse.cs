﻿using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_do_zaraadzania_wymowkami_1
{
    internal class Excuse
    {
        public string Description { get; set; }
        public string Results {  get; set; }
        public DateTime LastUsed { get; set; }
        public string ExcusePath { get; set; }

        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(string excusePath)
        {
            OpenFile(excusePath);
        }

        public Excuse(Random random, string folder)
        {
            string[] fileName = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileName[random.Next(fileName.Length)]);
        }

        private void OpenFile(string excusePath)
        {
            this.ExcusePath = excusePath;

            using (StreamReader reader = new StreamReader(excusePath))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }

        public void Save(string fileName)
        {
            using(StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(Description);
                writer.WriteLine(Results);
                writer.WriteLine(LastUsed);
            }
        }
    }
}
