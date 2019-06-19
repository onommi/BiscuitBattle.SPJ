using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    public class RandomBiscuit : IBiscuitCard
    {
        public string Name { get; set; }
        public Dictionary<BiscuitAttribute, int> Stats { get; set; }
        public int Quality => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public RandomBiscuit()
        {
            //random number generator for making stats
            var rand = new Random();

            //Builds the stats for this biscuit randomly
            Stats = new Dictionary<BiscuitAttribute, int>
            {
                { BiscuitAttribute.DunkIntegrity, (int)(rand.NextDouble() * 100.0) },
                { BiscuitAttribute.Moistness, (int)(rand.NextDouble() * 100.0) },
                { BiscuitAttribute.Snap, (int)(rand.NextDouble() * 100.0) },
                { BiscuitAttribute.Sweetness, (int)(rand.NextDouble() * 100.0) },
                { BiscuitAttribute.Texture, (int)(rand.NextDouble() * 100.0) }
            };

            //find out the strongest attribute
            var attr = Stats.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

            //To generate a name, let's first make a name format using the overall quality of the biscuit
            if (Quality >= 250)
            {
                Name = "M&S Deluxe {0} Biscuit";
            }
            else if (Quality >= 150 && Quality < 250)
            {
                Name = "Good Ol' {0} Bickie";
            }
            else if (Quality >= 50 && Quality < 150)
            {
                Name = "Standard {0} Biscuit";
            }
            else
            {
                Name = "Sorry {0} Biscuit";
            }

            //switch case for naming the biscuit to the strongest attribute
            switch (attr)
            {
                case BiscuitAttribute.DunkIntegrity:
                    Name = String.Format(Name, "Dunking");
                    break;
                case BiscuitAttribute.Moistness:
                    Name = String.Format(Name, "Moist");
                    break;
                case BiscuitAttribute.Snap:
                    Name = String.Format(Name, "Snappy");
                    break;
                case BiscuitAttribute.Sweetness:
                    Name = String.Format(Name, "Sweet");
                    break;
                case BiscuitAttribute.Texture:
                    Name = String.Format(Name, "Crispy");
                    break;
                default:
                    Name = "Redundant Biscuit";
                    break;
            }

            //Sets a generic biscuit description
            Description = "This biscuit was brought to you by Amazing Biscuits Industries. Please do not forward your complaints to us.";
        }
    }
}
