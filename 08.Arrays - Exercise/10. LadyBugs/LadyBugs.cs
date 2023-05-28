// You are given a field size and the indexes where ladybugs can be found on the field. On every new line, until the
// "end" command is given, a ladybug changes its position either to its left or to its right by a given fly length. A
// movement description command looks like this: "0 right 1". This means that the little insect placed on index 0
// should fly one index to its right. If the ladybug lands on another ladybug, it continues to fly in the same direction
// repeating the specified flight length. If the ladybug flies out of the field, it is gone.
// For example, you are given a field of size 3, where there are ladybugs on indexes 0 and 1. If the ladybug on index 0
// needs to fly to its right by the length of 1 (0 right 1), it will attempt to land on index 1 but as there is another ladybug
// there, it will continue further to the right passing 1 index in length, landing on index 2. After that, if the same ladybug
// needs to fly to its right passing 1 index (2 right 1), it will land somewhere outside of the field, so it flies away:
// If we receive an initial index that does not contain a ladybug, nothing happens. If you are given a ladybug index that
// is outside the field, nothing happens. In the end, print all cells of the field separated by blank spaces. For each cell
// that has a ladybug in it print '1' and for each empty cell print '0'. The output of the example above should be "0 1 0".
// Input
// • On the first line, you will receive an integer - the size of the field
// • On the second line, you will receive the initial indexes of all ladybugs separated by a blank space.
// • On the next lines, until you get the "end" command, you will receive commands in the format: "{ladybug
// index} {direction} {fly length}".
// Output
// • Print all field cells in format: "{cell} {cell} … {cell}"
// o If a cell has a ladybug in it, print '1'.
// o If a cell is empty, print '0'.
// Constrains
// • The size of the field will be in the range [0…1000].
// • The ladybug indexes will be in the range [-2147483647…2147483647].
// • The number of commands will be in the range [0…100].
// • The fly length will be in the range [-2147483647…2147483647].


using System;

namespace _10._LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());// размер на полето
            int[] fildArrey = new int[fieldSize]; //самото поле

            int[] indexLadybugs = Console.ReadLine()  // позициите на калинките
                .Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < indexLadybugs.Length; i++) // нанасяне на калинките на полето
            {
                if (indexLadybugs[i] >= 0 && indexLadybugs[i] < fildArrey.Length)
                {
                    fildArrey[indexLadybugs[i]] = 1;
                }

            }

            string inputComands;  


            while ((inputComands = Console.ReadLine()) != "end") // ход на калинките или край
            {
                string[] commands = inputComands.Split(" ", StringSplitOptions.RemoveEmptyEntries); // разцепване на командата 

                int ladybugsIndex = int.Parse(commands[0]); // позиция 
                string direction = commands[1];             // посока
                int powerMulve = int.Parse(commands[2]);    //движения

                if (ladybugsIndex >= 0 && ladybugsIndex < fildArrey.Length)
                {
                    if (fildArrey[ladybugsIndex] == 1)
                    {
                        if (direction == "right") //местене на дясно
                        {
                            fildArrey[ladybugsIndex] = 0;

                            if (ladybugsIndex + powerMulve < fildArrey.Length)
                            {
                                for (int j = ladybugsIndex + powerMulve; j < fildArrey.Length; j += powerMulve)
                                {
                                    if (fildArrey[j] == 0)
                                    {
                                        fildArrey[j] = 1;
                                        break;
                                    }
                                }
                            }

                        }
                        else if (direction == "left") // местене на ляво
                        {
                            fildArrey[ladybugsIndex] = 0;

                            if (ladybugsIndex - powerMulve >= 0)
                            {
                                for (int j = ladybugsIndex - powerMulve; j >= 0; j -= powerMulve)
                                {
                                    if (fildArrey[j] == 0)
                                    {
                                        fildArrey[j] = 1;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }

                //inputComands = Console.ReadLine(); // нова команда
            }

            Console.WriteLine(string.Join(" ", fildArrey));
        }
    }
}