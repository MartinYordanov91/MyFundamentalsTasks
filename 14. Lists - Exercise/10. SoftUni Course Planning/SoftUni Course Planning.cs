// Help planning the next Programming Fundamentals course by keeping track of the lessons that will be included in
// the course, as well as all the exercises for the lessons. On the first input line, you will receive the initial schedule of
// lessons and exercises that are going to be part of the next course, separated by a comma and a space ", ". Before
// the course starts, there are some changes to be made. Until you receive the "course start" command, you will
// be given some commands to modify the course schedule.
// The possible commands are:
// • Add:{lessonTitle} – add the lesson to the end of the schedule, if it does not exist.
// • Insert:{lessonTitle}:{index} – insert the lesson to the given index, if it does not exist.
// • Remove:{lessonTitle} – remove the lesson, if it exists.
// • Swap:{lessonTitle}:{lessonTitle} – swap the position of the two lessons, if they exist.
// Exercise:{lessonTitle} – add Exercise in the schedule right after the lesson index, if the lesson exists and
// there is no exercise already, in the following format "{lessonTitle}-Exercise". If the lesson doesn`t exist, add
// the lesson at the end of the course schedule, followed by the Exercise.
// Note: Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are
// any following the lessons.
// Input / Constraints
// • First line – the initial schedule lessons – strings, separated by comma and space ", ".
// • Until "course start" you will receive commands in the format described above.
// Output
// • Print the whole course schedule, each lesson on a new line with its number (index) in the schedule:
// "{lesson index}.{lessonTitle}".
// • Allowed working time / memory: 100ms / 16MB.

using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace _10._SoftUni_Course_Planning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> listPrograming = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            string stringComand;

            while ((stringComand = Console.ReadLine()) != "course start")
            {
                List<string> ComandList = stringComand.Split(':', StringSplitOptions.RemoveEmptyEntries).ToList();

                if (ComandList[0] == "Add")
                {
                    //• Add: { lessonTitle} – add the lesson to the end of the schedule, if it does not exist.
                    if (!listPrograming.Contains(ComandList[1]))
                    {
                        listPrograming.Add(ComandList[1]);
                    }
                }
                else if (ComandList[0] == "Insert")
                {
                    //• Insert: { lessonTitle}:{ index} – insert the lesson to the given index, if it does not exist.
                    if (!listPrograming.Contains(ComandList[1]))
                    {
                        listPrograming.Insert(int.Parse(ComandList[2]), ComandList[1]);
                    }
                }
                else if (ComandList[0] == "Remove")
                {
                    //• Remove: { lessonTitle}  – remove the lesson, if it exists.
                    if (listPrograming.Contains(ComandList[1]))
                    {
                        listPrograming.Remove(ComandList[1]);
                    }

                }
                else if (ComandList[0] == "Swap")
                {
                    //• Swap: { lessonTitle}:{ lessonTitle} – swap the position of the two lessons, if they exist.
                    if (listPrograming.Contains(ComandList[1]) && listPrograming.Contains(ComandList[2]))
                    {
                        (listPrograming[listPrograming.IndexOf(ComandList[1])], listPrograming[listPrograming.IndexOf(ComandList[2])]) = (listPrograming[listPrograming.IndexOf(ComandList[2])], listPrograming[listPrograming.IndexOf(ComandList[1])]);
                    }
                    //listPrograming = Swap(listPrograming , ComandList[1] , ComandList[2]);
                }
                else if (ComandList[0] == "Exercise")
                {
                    //                Exercise: { lessonTitle} – add Exercise in the schedule right after the lesson index, if the lesson exists and there is no exercise already, in the following format "{lessonTitle}-Exercise".If the lesson doesn`t exist, add the lesson at the end of the course schedule, followed by the Exercise.
                    //Note: Each time you Swap or Remove a lesson, you should do the same with the Exercises, if there are any following the lessons.
                    if (!listPrograming.Contains(ComandList[1]))
                    {
                        listPrograming.Add(ComandList[1]);
                    }
                    if (!listPrograming.Contains(ComandList[1] + "-Exercise"))
                    {
                        int elementIndex = listPrograming.IndexOf(ComandList[1]);
                        listPrograming.Insert(elementIndex+ 1, ComandList[1] + "-Exercise");
                    }
                }
                listPrograming = RearrangeExercises(listPrograming);

            }

            for (int i = 0; i < listPrograming.Count; i++)
            {
                Console.WriteLine("{0}.{1}", i + 1, listPrograming[i]);
            }
        }

        static List<string> RearrangeExercises(List<string> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
                if (list[i + 1].Contains("-Exercise") && list[i + 1] != list[i] + "-Exercise")
                    for (int j = 0; j < list.Count; j++)
                        if (list[i + 1] == list[j] + "-Exercise")
                        {
                            string temp = list[i + 1];
                            list.RemoveAt(i + 1);
                            list.Insert(j + 1, temp);
                        }
            return list;
        }
        
    }
}