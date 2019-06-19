using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    public class CustardCreamBiscuit : IBiscuitCard
    {
        public string Name { get; set; }
        public Dictionary<BiscuitAttribute, int> Stats { get; set; }
        public int Quality => Stats.Sum(att => att.Value);
        public string Description { get; set; }

        public CustardCreamBiscuit()
        {
            Stats = new Dictionary<BiscuitAttribute, int>
            {
                { BiscuitAttribute.DunkIntegrity, 40 },
                { BiscuitAttribute.Moistness, 50 },
                { BiscuitAttribute.Snap, 50 },
                { BiscuitAttribute.Sweetness, 80 },
                { BiscuitAttribute.Texture, 50 }
            };

            Name = "Custard Cream";
            Description = "The classic custard cream, is there any need to say more?";
        }
    }
}
