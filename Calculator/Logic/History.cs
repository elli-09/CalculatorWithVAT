using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace History
{
    class History
    {
        private string[] records = new string[3];
        private int count = 0;
        public void AddRecord(string record)
        {
            if (count < 3)
            {
                records[count] = record;
                count++;
            }
            else
            {
                records[0] = records[1];
                records[1] = records[2];
                records[2] = record;
            }
        }
        public void ShowHistory()
        {
            if (count == 0)
            {
                Console.WriteLine("History is empty.");
            }
            else
            {
                Console.WriteLine("Last operations:");

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(records[i]);
                }
            }
        }
    }