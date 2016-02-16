﻿using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

using Data.Warehouse.Crawler;

namespace SatelliteTest
{
    class Program
    {
        static void Main(string[] args)
        {
            var templatesfiles = new[]
            {
                //@"..\..\App_Data\shopping\mytoys.crawl",
                //@"..\..\App_Data\chefkoch.crawl",
                @"..\..\App_Data\shopping\esprit.crawl",
                //@"..\..\App_Data\stackoverflow.crawl",
                //@"..\..\App_Data\fun\9gag.crawl"
            };
            templatesfiles.ToList().ForEach(templatefile =>
            {
                var template = File.ReadAllText(templatefile);
                //ExecuteSatelliteTest(template);
                ExecuteMockTest(template);
            });
        }

        private static void ExecuteSatelliteTest(string template)
        {
            var client = new Satellite.SatelliteClient();
            client.Process(template, null);
        }
        private static void ExecuteMockTest(string template)
        {
            var compiler = new WebcrawlerCompiler();
            var commandset = compiler.ParseCommandset(Regex.Split(template, Environment.NewLine));

            var crawler = new WebcrawlingUtility(new ProviderMock());
            crawler.ContextCommandset = compiler.ContextCommandset;
            crawler.Crawling(commandset);
        }
    }
}
