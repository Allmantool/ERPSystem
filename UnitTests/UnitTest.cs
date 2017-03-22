using ERP.Domain.Entities;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Dynamic;

namespace UnitTests {
    [TestClass]
    public class UnitTest {
        [TestMethod]
        public void initMethod() {
            //assets
            var defaults = new List<MeauseUnit>() {
                new MeauseUnit  { Id = 1, CLRType = typeof(int), IsSystem = true, Abbreviation = "FactoryShop", Description = "Цех, производство" },
                new MeauseUnit  { Id = 1, CLRType = typeof(int), IsSystem = true, Abbreviation = "Plant", Description = "Установка" },
            };

            dynamic expando = new ExpandoObject() as IDictionary<string, Object>;

            expando.Add("Shout", new Action(() => { Console.WriteLine("Hellooo!!!"); }));
            expando.Add("Id", 1);

            //dynamic root;
            var root = new GeneralHierarchyUnit() { Id = 1, Description = "My root" };


            dynamic p = new ExpandoObject();
            p["firstNam"] = "John";



            defaults.ForEach(item => expando.Add(item.Abbreviation, 0));

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
