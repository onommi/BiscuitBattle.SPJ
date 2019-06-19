using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using BiscuitBattle.Store.Decks;

namespace BiscuitBattle.Players
{
    public class CrazyAI : IPlayer
    {
        public (BiscuitAttribute Attr, int Score) DecideAttributeToPlay(IBiscuitCard m)
        {
            //this AI is crazy, and doesn't care what attribute it plays, picks any attribute randomly
            Console.WriteLine("Who cares...");
            Thread.Sleep(500);

            //create a random number generator
            var rand = new Random();

            //gets a copy of the attributes keys in a list so we can select one at random
            var attributes = m.Stats.Keys.ToList();

            //Selects one of these attributes using a random index between 0 and the number of attributes on a list copy of the attribute dictionary keys
            var attr = attributes[rand.Next(0, attributes.Count)];

            //returns the attribute and it's score
            return (attr, m.Stats[attr]);             
        }
    }
}
