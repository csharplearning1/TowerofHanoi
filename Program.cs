using System;

namespace TowerofHanoi
{

    class Program
    {
        int disk_number;
        public Program()
        {
            disk_number = 0;
        }
        public Program(int number)
        {
            disk_number = number;
        }

        public void move_disk(int n, string src, string helper, string dist)
        {
            if (n > 0)
            {
                move_disk(n - 1, src, dist, helper);
                int nt = n;

                //  while (nt > 0)
                {

                    switch (dist)
                    {

                        case "A":

                            Console.WriteLine("\t\t from: " + src + "   ");
                            break;

                        case "B":

                            Console.WriteLine("\t\t\t from: " + src + "   ");
                            break;
                        case "C":

                            Console.WriteLine("\t\t\t\t from:" + src + "   ");
                            break;

                    }
                    nt--;
                }

                move_disk(n - 1, helper, src, dist);
            }
        }

        public static void Main()
        {

            Program p = new Program();
            Console.Write("Enter disk numbers\n ");
            p.disk_number = int.Parse(Console.ReadLine());
            Program hanoi = new Program(p.disk_number);
            hanoi.move_disk(hanoi.disk_number, "A", "B", "C");
            Console.WriteLine("\n destination:" + "\t " + "TowerA" + "\t" + "TowerB" + "\t" + "Towerc");
            Console.ReadLine();

        }

    }
}
