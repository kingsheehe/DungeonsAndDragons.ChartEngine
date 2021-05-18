using System;
using DungeonsAndDragons.ChartEngine.Utilities;
using DungeonsAndDragons.ChartEngine.Charts.Treasure;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.ChartEngine
{
    class test
    {

         
        /// <summary>
        /// Display everything in monetary chart
        /// </summary>
        public static void Main()
        {
            Charts.GetCharts FirstTest;

           

            FirstTest = new Charts.GetCharts();

            //Arrange
            FirstTest.GetMonetaryChart();
            //Act

            //Assert
            // string name = FirstTest.MonetaryTreasure.First(x => x.Key == Utilities.MonsterType.A).Value.Select(x => x.)

            //todo  Create a loop to cw all the treasure properties of A.
            List<MonitaryTreasure> Temp = FirstTest.MonetaryTreasure.First(x => x.Key == MonsterType.A).Value;
            MonitaryTreasure Temp2 = Temp.First(x => x.TreasureName == "Silver");
            string name = Temp2.TreasureName;
            int amount = Temp2.TreasureAmount;
            //Console.WriteLine($"The first treasure is {Temp2.TreasureName} and the amount is {amount}");
            //Console.ReadLine();



            for (int i = 0; i < Temp.Count; i++)
            {
                Console.WriteLine($"Here is what is in A {Temp[i]}"); //obviously wrong, I am getting closer still
            }
            Console.ReadLine();

            //foreach (var item in Temp)
            //{
            //    Console.WriteLine($"The items in A are {Temp[item]}");
            //}

        }
    }
}
