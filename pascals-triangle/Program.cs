using System;
using System.Collections.Generic;

namespace pascalstriangle
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pascal's Triangle generator");
            Console.Write("How many lines of the trangle do you want? ");
            String lineInput = Console.ReadLine();
            Console.WriteLine("Okay, printing " + lineInput + " lines");

            int numberOfLines = int.Parse(lineInput);
            int width = 2 * numberOfLines - 1;

            List<List<int>> lines = new List<List<int>>();
            for (int counter = 0; counter < numberOfLines; counter++)
            {
                if (counter == 0)
                {
                    lines.Insert(counter, new List<int>{ 1 });
                }

                else if (counter == 1)
                {
                    lines.Insert(counter, new List<int>{ 1, 1 });
                }

                else
                {
                    List<int> newLine = new List<int>{};
                    for (int lineCounter = 0; newLine.Count <= counter; lineCounter ++)
                    {
                        newLine.Insert(lineCounter, lineCounter + 1);
                    }
                    lines.Insert(counter, newLine);
                }

                String line = format(lines[counter]);
                Console.WriteLine(line.ToString().PadLeft(numberOfLines + counter, ' '));
            }

            String format(List<int> line)
            {
                String lineString = "";

                foreach (int value in line)
                {
                    lineString += value.ToString() + " ";
                }

                return lineString.Trim();
            }
        }
    }
}
