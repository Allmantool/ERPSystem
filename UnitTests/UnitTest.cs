using ERP.Domain.Concrete;
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
        public void DynamicTest() {
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

        [TestMethod]
        public void InitTest() {
            var sh = new FactoryShop() {
                Id = 1,
                Description = "1 Производство",
                Plants = new List<Plant>{
                    new Plant() { }
                }

            };

            var eq = new Facility() {
                Id = 1,
                DueDate = DateTime.Today,
                IsUsed = true,
                Location = "NP",
                ProducerFactory = new ProducerFactory() { Id = 1, Description = "Завод №1" },
                Mark = new Mark() { Id = 1, Description = "Bosh" },
                Shop = new FactoryShop() { Id = 1, Description = "1 Производство" },
                PhEnvironment = new PhEnvironment() { Id = 1, Description = "Серная кислота" },
                PersonalMarks = new List<Index> { new Index() { Id = 1, Description = "Свойство 1", dataType = typeof(int) } },
                Repairs = new List<Repairs> { new Repairs() { Cause = new RepairReason() { Id = 1, Description = "Авария" } } },
                WrkRegisters = new List<WrkRegister> { new WrkRegister() { Period = DateTime.Today, Value = 100 } }
            };

        }

        [TestMethod]
        public void StructureEq() {
            var tree = new Tree<GeneralHierarchyUnit>();
            var rootNode = new GeneralHierarchyUnit() { Depth = 0, Id = 1, Description = "Нафтан" };

            var node1 = new GeneralHierarchyUnit() { Depth = 1, Id = 2, Description = "Электpодвигатели (ЭД)", Parent = rootNode };
            var node2 = new GeneralHierarchyUnit() { Depth = 1, Id = 3, Description = "Насосы (НС) (НКО)", Parent = rootNode };
            var node3 = new GeneralHierarchyUnit() { Depth = 1, Id = 4, Description = "Компрессоры (К) (HКО)", Parent = rootNode };
            var node4 = new GeneralHierarchyUnit() { Depth = 1, Id = 5, Description = "Грузоподъемные механизмы", Parent = rootNode };

            var node5 = new GeneralHierarchyUnit() { Depth = 1, Id = 6, Description = "Электpодвигатели (ЭД)", Parent = rootNode };
            var node6 = new GeneralHierarchyUnit() { Depth = 1, Id = 7, Description = "Насосы (НС) (НКО)", Parent = rootNode };
        }
    }
}
