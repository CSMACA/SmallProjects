using System;
using System.Collections.Generic;
using System.Linq;

namespace Dominoes
{
    /// <summary>
    /// Determines the orientation of each tile when the dominoes stop falling.
    /// </summary>
    class DominoToppling
    {

        static string INITIAL;

        static List<Domino> dominoList = new List<Domino>();

        static void Main(string[] args)
        {
            Console.WriteLine("Enter input string: ");
            INITIAL = Console.ReadLine().ToUpper();
            if ((INITIAL.Contains('L') && INITIAL.Contains('R') && INITIAL.Contains('.')))
            {
                INITIAL.ToList().ForEach(x => dominoList.Add(new Domino(x)));

                Console.Write("Before: ");
                dominoList.ForEach(x => Console.Write(x.Direction));

                List<int> ls = new List<int>();
                List<int> rs = new List<int>();

                do
                {
                    ls = new List<int>();
                    rs = new List<int>();

                    //Get indexes of L's and R's
                    for (int k = 0; k < dominoList.Count; k++)
                    {
                        if (dominoList[k].Direction == 'L') ls.Add(k);
                        if (dominoList[k].Direction == 'R') rs.Add(k);
                    }

                    //Decrement L's
                    //ls.ForEach(x => ls[x]--);

                    for (int i = 0; i < ls.Count; i++)
                    {
                        ls[i]--;
                    }

                    //Increment R's
                    //rs.ForEach(x => ls[x]++);
                    for (int i = 0; i < rs.Count; i++)
                    {
                        rs[i]++;
                    }

                    //Find dupes
                    List<int> dupes = ls.Where(x => rs.Contains(x)).ToList();

                    //Remove dupes
                    ls.RemoveAll(x => dupes.Contains(x));
                    rs.RemoveAll(x => dupes.Contains(x));

                    //Remove out of range indeces.
                    ls.RemoveAll(x => x < 0);
                    rs.RemoveAll(x => x >= dominoList.Count);

                    //Remove fallen dominoes.
                    ls.RemoveAll(x => dominoList[x].Direction != '.');
                    rs.RemoveAll(x => dominoList[x].Direction != '.');

                    //replace
                    ls.ForEach(x => { if (dominoList[x].Direction == '.') dominoList[x].Direction = 'L'; });
                    rs.ForEach(x => { if (dominoList[x].Direction == '.') dominoList[x].Direction = 'R'; });
                } while (ls.Count != 0 || rs.Count != 0);


                Console.WriteLine();
                Console.Write("After: ");
                dominoList.ForEach(x => Console.Write(x.Direction));


                Console.ReadKey();
            }
        }
    }
}
