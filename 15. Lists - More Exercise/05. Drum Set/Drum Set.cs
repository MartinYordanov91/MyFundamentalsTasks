// Gabsy is Orgolt's Final Revenge charming drummer. She has a drum set but the different drums have different
// origins – some she bought, some are gifts, so they are all of different quality. Every day she practices on each of
// them, so she does damage and reduces the drum`s quality. Sometimes a drum breaks, so she needs to buy a new
// one. Help her keep her drum set organized.
// You will receive Gabsy's savings, the money she can spend on new drums. Next, you will receive a sequence of
// integers, which represents the initial quality of each drum in Gabsy's drum set.
// Until you receive the command "Hit it again, Gabsy!", you will be receiving an integer: the hit power Gabsy
// applies on each drum while practicing. When the power is applied, you should decrease the value of the drum's
// quality with the current power.
// When a certain drum reaches 0 quality, it breaks. Then Gabsy should buy a replacement. She needs to buy the same
// model. Therefore, its quality will be the same as the initial quality of the broken drum. The price is calculated by the
// formula: {initialQuality} * 3. Gabsy will always replace her broken drums until the moment she can no
// longer afford them. If she doesn't have enough money for a replacement, the broken drum is removed from the
// drum set.
// When you receive the command "Hit it again, Gabsy!", the program ends and you should print the current
// state of the drum set. On the second line you should print the remaining money in Gabsy's savings account.
// Input
// • On the first line, you will receive the savings – a floating-point number.
// • On the second line, you will receive the drum set: a sequence of integers, separated by spaces.
// • Until you receive the command "Hit it again, Gabsy!", you will be receiving integers – the hit power
// Gabsy applies on each drum.
// Output
// • On the first line, you should print each drum in the drum set, separated by space.
// • Then you must print the money that is left on the second line in the format "Gabsy has {money
// left}lv.", formatted with two digits after the decimal point.
// Constraints
// • The savings – a floating-point number in the range [0.00…10000.00].
// • The quality of each drum in the drum set – an integer in the range [1…1000].
// • The hit power will be in the range [0…1000].
// • Allowed working time / memory: 100ms / 16MB.


using System;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main()
        {
            decimal gabsyMoney = decimal.Parse(Console.ReadLine());

            List<int> startDrumList = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse).ToList();

            List<int> copyDrumlist = startDrumList.ToList();

            string comand = "";

            while ((comand = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                int gabsyDamage = int.Parse(comand);

                for (int i = 0; i < copyDrumlist.Count; i++)
                {
                    copyDrumlist[i] -= gabsyDamage;
                }

                for (int m = 0; m < copyDrumlist.Count; m++)
                {
                    if (copyDrumlist[m] <= 0)
                    {
                        int negativeNumber = copyDrumlist[m];
                        int indexNum = m;
                        decimal moneyNeedForDrum = startDrumList[indexNum] * 3;

                        if (moneyNeedForDrum <= gabsyMoney)
                        {
                            gabsyMoney -= moneyNeedForDrum;
                            copyDrumlist[indexNum] = startDrumList[indexNum];
                        }

                    }
                }
                //Console.WriteLine(string.Join(" ", copyDrumlist));
                //Console.WriteLine($"Gabsy has {gabsyMoney:f2}lv.");
            }

            copyDrumlist.RemoveAll(x => x <= 0);
            Console.WriteLine(string.Join(" ", copyDrumlist));
            Console.WriteLine($"Gabsy has {gabsyMoney:f2}lv.");

        }
    }
}