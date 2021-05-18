using DungeonsAndDragons.ChartEngine.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonsAndDragons.ChartEngine.Charts
{
    public class GetCharts
    {
        public Dictionary<MonsterType, List<Treasure.MonitaryTreasure>> MonetaryTreasure =
            new Dictionary<MonsterType, List<Treasure.MonitaryTreasure>>();

        public GetCharts()
        {


            //string monstertype = "A";


        }


        #region Priviate Methods

        /// <summary>
        /// Assignment 1)Fill in treaure chart. 2)Write description.
        /// </summary>
        public void GetMonetaryChart()
        {
            MonetaryTreasure.Add(MonsterType.A, PopulateMonitaryChart());

                           
        }

        public List<Treasure.MonitaryTreasure> PopulateMonitaryChart()
        { 
            //todo   Finish treasure rewards for A 
            var TreasureRewards = new List<Treasure.MonitaryTreasure>();
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Copper", Dice.D6, 1000, .25));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Silver", Dice.D6, 1000, .30));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Electrum", Dice.D4, 1000, .20));
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Gold", Dice.D6, 1000, .35));//todo  the dice amount is 2d6 not sure how to fix that
            TreasureRewards.Add(new Treasure.MonitaryTreasure("Platinum", Dice.D2, 1000, .25));

            return TreasureRewards;
        }

        private void GetGemTreasureChart()
        {

        }


        private void GetJewelryTreasureChart()
        {

        }

        private void GetMagicItemTreasureChart()
        {

        }

        #endregion Private Methods

    }
}
