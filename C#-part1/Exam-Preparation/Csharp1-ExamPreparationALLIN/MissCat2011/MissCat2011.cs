using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat2011
{
    class MissCat2011
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] cats = new int[11];
            int mostVotedCat = 0;

            // Type in votes
            for (int i = 0; i < n; i++)
            {
                int juryVote = int.Parse(Console.ReadLine());
                cats[juryVote] += 1;
            }

            // Loop array with votes to figure out the most voted cat
            int currentVotes = 0;
            for (int i = 1; i < cats.Length; i++)
            {
                if (cats[i] > currentVotes)
                {
                    mostVotedCat = i;
                    currentVotes = cats[i];
                }
            }

            Console.WriteLine(mostVotedCat);

            //int n = int.Parse(Console.ReadLine());
            //int cat1Count = 0;
            //int cat2Count = 0;
            //int cat3Count = 0;
            //int cat4Count = 0;
            //int cat5Count = 0;
            //int cat6Count = 0;
            //int cat7Count = 0;
            //int cat8Count = 0;
            //int cat9Count = 0;
            //int cat10Count = 0;

            //for (int i = 0; i < n; i++)
            //{
            //    int juryVote = int.Parse(Console.ReadLine());

            //    if (juryVote == 1)
            //    {
            //        cat1Count++;
            //    }
            //    if (juryVote == 2)
            //    {
            //        cat2Count++;
            //    }
            //    if (juryVote == 3)
            //    {
            //        cat3Count++;
            //    }
            //    if (juryVote == 4)
            //    {
            //        cat4Count++;
            //    }
            //    if (juryVote == 5)
            //    {
            //        cat5Count++;
            //    }
            //    if (juryVote == 6)
            //    {
            //        cat6Count++;
            //    }
            //    if (juryVote == 7)
            //    {
            //        cat7Count++;
            //    }
            //    if (juryVote == 8)
            //    {
            //        cat8Count++;
            //    }
            //    if (juryVote == 9)
            //    {
            //        cat9Count++;
            //    }
            //    if (juryVote == 10)
            //    {
            //        cat10Count++;
            //    }
            //}

            //int mostVotedCat = 0;
            //int mostVotes = 0;

            //if (cat1Count > mostVotes)
            //{
            //    mostVotedCat = 1;
            //    mostVotes = cat1Count;
            //}
            //if (cat2Count > mostVotes)
            //{
            //    mostVotedCat = 2;
            //    mostVotes = cat2Count;
            //}
            //if (cat3Count > mostVotes)
            //{
            //    mostVotedCat = 3;
            //    mostVotes = cat3Count;
            //}
            //if (cat4Count > mostVotes)
            //{
            //    mostVotedCat = 4;
            //    mostVotes = cat4Count;
            //}
            //if (cat5Count > mostVotes)
            //{
            //    mostVotedCat = 5;
            //    mostVotes = cat5Count;
            //}
            //if (cat6Count > mostVotes)
            //{
            //    mostVotedCat = 6;
            //    mostVotes = cat6Count;
            //}
            //if (cat7Count > mostVotes)
            //{
            //    mostVotedCat = 7;
            //    mostVotes = cat7Count;
            //}
            //if (cat8Count > mostVotes)
            //{
            //    mostVotedCat = 8;
            //    mostVotes = cat8Count;
            //}
            //if (cat9Count > mostVotes)
            //{
            //    mostVotedCat = 9;
            //    mostVotes = cat9Count;
            //}
            //if (cat10Count > mostVotes)
            //{
            //    mostVotedCat = 10;
            //}
            //Console.WriteLine(mostVotedCat);
        }
    }
}
