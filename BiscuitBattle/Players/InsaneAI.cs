using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Players
{
    public class InsaneAI : IPlayer
    {
        public (BiscuitAttribute Attr, int Score) DecideAttributeToPlay(IBiscuitCard m)
        {
            //this guy is insane, he'll just pick the lowest attribute possible
            
            //Gets distracted
            Console.Write("Distracted....");
            Thread.Sleep(5000);
            Console.WriteLine("Take THIS!");

            //Never worked with aggregates before, but I will modify it to pick the lowest instead of highest value
            var attr = m.Stats.Aggregate((l, r) => l.Value < r.Value ? l : r).Key;
            return (attr, m.Stats[attr]);
        }
    }
}
