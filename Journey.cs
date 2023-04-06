using System;
using System.Collections.Generic;
using System.Linq;

namespace Quest
{
    public class Journey
    {
        public List<Challenge> Challenges { get; }

        public Journey(List<Challenge> allChallenges)
        {
            Random rnd = new Random();
            Challenges = allChallenges.OrderBy(x => rnd.Next()).Take(5).ToList();
        }       
    }
}