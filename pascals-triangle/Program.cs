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
                        if (lineCounter == 0 || lineCounter == counter)
                        {
                            newLine.Insert(lineCounter, 1);
                        }
                        else
                        {
                            int sum = lines[counter - 1][lineCounter - 1] + lines[counter - 1][lineCounter];
                            newLine.Insert(lineCounter, sum);
                        }
                    }
                    lines.Insert(counter, newLine);
                }

                String line = format(lines[counter]);
                Console.WriteLine(line.ToString().PadLeft((numberOfLines - counter + 1) * 3 + line.Length, ' '));
            }

            String format(List<int> line)
            {
                String lineString = "";

                for (int lineCounter = 0; lineCounter < line.Count; lineCounter++)
                {
                    int value = line[lineCounter];
                    lineString += value.ToString().PadLeft(6, ' ');
                }

                return lineString.Trim();
            }
        }
    }
}
