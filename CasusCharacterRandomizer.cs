using System;

namespace CasusCharacterRandomizer
{
    class CasusCharacterRandomizer
    {
        bool isCaster = false;
        static void Main(string[] args)
        {


            CasusCharacterRandomizer ccr = new CasusCharacterRandomizer();

            while (true)
            {
                ccr.racePicker();
                ccr.classPicker();
                ccr.occupationPicker();
                ccr.karma();
                ccr.abilityStats(ccr.isCaster);
                
                Console.WriteLine("\n");
                Console.WriteLine("Press any key to reroll");
                Console.ReadKey();
                ccr.isCaster = false;
                Console.WriteLine("\n\n\n");
            }

        }

        public void racePicker()
        {
            var rand = new Random();

            string[] races =
{
                "human",
                "royal elf",
                "daich",
                "kushnar",
                "dwarf",
                "fogem",
                "maydur",
                "lunar elf",
                "marinum",
            };
            int randomNum = rand.Next(races.Length);
            Console.WriteLine("your race: {0}", races[randomNum]);
        }

        public void occupationPicker()
        {
            var rand = new Random();

            string[] occupation =
            {
                "farmer",
                "neophyte",
                "robber",
                "thief",
                "beggar",
                "con-artist",
                "guide",
                "scholar",
                "magi-scholar",
                "athlete",
                "porter",
                "retainer",
                "guardsman"
            };

            int randomNum = rand.Next(occupation.Length);
            Console.WriteLine("your occupation: {0}", occupation[randomNum]);
        }

        public void classPicker()
        {
            var rand = new Random();

            string[] classes =
            {
                "barbarian",
                "cut throat",
                "fighter",
                "hunter",
                "thief",
                "warrior",
                "rogue",
                "shaman",
                "priest",
                "mage"

            };

            string[] casterClasses = { "shaman", "priest", "mage" };


            int randomNum = rand.Next(classes.Length);
            string chosenClass = classes[randomNum];

            for (int i = 0; i < casterClasses.Length; i++)
            {
                if (chosenClass.Equals(casterClasses[i]))
                {
                    isCaster = true;
                }
            }
            

            Console.WriteLine("your class: {0}", chosenClass);
        }
        public void abilityStats(bool isCaster)
        {
            Random rand = new Random();
            //ArrayList list = new ArrayList();

            int poolTotal = 100;
            int poolDistributed = 6;
            

            int strength = 1; //0
            int agility = 1; //1
            int resilience = 1; //2
            int intelligence = 1; //3
            int wisdom = 1; //4
            int charisma = 1; //5
            int magicalOffense = 0; //6
            int magicalDefense = 0; //7

            int[] statArray = {strength, agility, resilience, intelligence, wisdom, charisma, magicalOffense, magicalDefense};
            int randomVal = statArray.Length - 2;
            if (isCaster)
            {
                statArray[6]++;
                statArray[7]++;
                poolDistributed += 2;
                randomVal += 2;
            }

            while(poolDistributed != poolTotal)
            {
                switch (rand.Next(randomVal))
                {
                    case 0:
                        if (statArray[0] != 33)
                        {
                            statArray[0]++;
                            poolDistributed++;
                        }
                        break;

                    case 1:
                        if (statArray[1] != 33)
                        {
                            statArray[1]++;
                            poolDistributed++;
                        }
                        break;

                    case 2:
                        if (statArray[2] != 33)
                        {
                            statArray[2]++;
                            poolDistributed++;
                        }
                        break;

                    case 3:
                        if (statArray[3] != 33)
                        {
                            statArray[3]++;
                            poolDistributed++;
                        }
                        break;

                    case 4:
                        if (statArray[4] != 33)
                        {
                            statArray[4]++;
                            poolDistributed++;
                        }
                        break;

                    case 5:
                        if (statArray[5] != 33)
                        {
                            statArray[5]++;
                            poolDistributed++;
                        }
                        break;
                    case 6:
                        if (statArray[6] != 33)
                        {
                            statArray[6]++;
                            poolDistributed++;
                        }
                        break;
                    case 7:
                        if (statArray[7] != 33)
                        {
                            statArray[7]++;
                            poolDistributed++;
                        }
                        break;

                }
                    
            }

            Console.WriteLine("your stats:" +
                "\n strength: {0}" +
                "\n agility: {1}" +
                "\n resilience: {2}" +
                "\n intelligence: {3}" +
                "\n wisdom: {4}" +
                "\n charisma: {5}" +
                "\n magical offense: {6}" +
                "\n magical defense: {7}"
                , statArray[0], statArray[1], statArray[2], statArray[3], statArray[4], statArray[5], statArray[6], statArray[7]);


        }

        public void karma()
        {
            Random rand = new Random();
            int karma = rand.Next(-5, 5);

            Console.WriteLine("your karma: {0}", karma);
        }
    }
}
