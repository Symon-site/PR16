using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp38
{
    public class Score
    {
        private Dictionary<string, int> scores;
        public Score()
        {
            scores = new Dictionary<string, int>
        {
            { "Математика", 0 },
            { "Русский", 0 },
            { "Физика", 0 }
        };
            }

             public int this[string subject]
        {
            get
            {
                if (scores.ContainsKey(subject))
                {
                    return scores[subject];
                }
                Console.WriteLine("Предмет не найден!");
                return 0;
            }
            set
            {
                if (scores.ContainsKey(subject))
                {
                    scores[subject] = value;
                }
                else
                {
                    Console.WriteLine("Предмет не найден!");
                }
            }
        }

        public override string ToString()
        {
            return string.Join(", ", scores.Select(s => $"{s.Key}: {s.Value}"));
        }
    }
    }

