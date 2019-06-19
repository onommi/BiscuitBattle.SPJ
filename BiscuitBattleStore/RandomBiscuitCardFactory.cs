using System;
using System.Collections.Generic;
using System.Text;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Store
{
    public class RandomBiscuitCardFactory : BaseBiscuitFactory
    {
        public override IBiscuitCard GetCard()
        {
            var ran = new Random();
            var choose = ran.Next(0, 6);
            switch (choose)
            {
                case 0:
                    return new NiceBiscuit();
                case 1:
                    return new DigestiveBiscuit();
                case 2:
                    return new PinkWaferBiscuit();
                case 3:
                    return new BalancedBiscuit();
                case 4:
                    return new GingernutBiscuit();
                case 5:
                    return new CustardCreamBiscuit();
                default:
                    return new BalancedBiscuit();
            }
        }
    }
}
