using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Mision_Space
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int day = 1, credits = 100, choice = -1, succesful_operation = 0, Today_succesful_operation = 0;
            int Fuel = 60, Oxygen = 70, Energy = 65, Spaceship_health = 100, Mission_score = 0, Minerals = 0, Minerals_mercury = 0;
            string location = "Space Station";
            bool mars_exp = false, mercury_exp = false, europa_exp = false, mars_collect = false, mercury_collect = false, europa_collect = false, Lifeline = true,check_bonus_puan=false;
            while (true)
            {

                Console.WriteLine("========= SPACE MISSION SIMULATOR =========\n" +
                    "Day:" + day + "\n" +
                    "Current Location: " + location + "\n" +
                    "Credits: " + credits + " C\n" +
                    "Fuel: " + Fuel + "/ 100\n" +
                    "Oxygen: " + Oxygen + "/ 100\n" +
                    "Energy: " + Energy + "/ 100\n" +
                    "Health: " + Spaceship_health + " / 100\n" +
                    "Mission Score:" + Mission_score + "\n" +
                    "Inventory: " + Minerals + " Minerals" +
                    " \n");

                Console.Write("1. Travel to a Planet\n" +
                    "2. Explore the Planet\n" +
                    "3. Collect Minerals\n" +
                    "4. Supply Station\n" +
                    "5. Display Mission Status\n" +
                    "6. End of the Day\n" +
                    "7. Quit Mission\n" +
                    " \n" +
                    "Enter Your Choice :");
                
               
                choice = -1;
                while (choice > 8 || choice < 0)
                {
                    choice = Convert.ToInt16(Console.ReadLine());
                } 
               
                switch (choice)
                {
                    case 1:
                        
                        Console.Write("Select destination (1: Mercury, 2: Mars, 3: Europa):");
                        int move = Convert.ToInt16(Console.ReadLine());
                        switch (move)
                        {
                            case 1:

                                if (Fuel >= 10 && Oxygen >= 8)
                                {
                                    Fuel -= 10;
                                    Oxygen -= 8;
                                    Console.WriteLine("Travel successful! Welcome to Mercury\n" +
                                        "Fuel consumed:10 \n" +
                                        "Remaining:" + Fuel + "\n" +
                                        "Oxygen consumed: 8 \n" +
                                        "Remaining:" + Oxygen);
                                    location = "Mercury";
                                }
                                else
                                {
                                    Console.WriteLine("Travel not seccessful !!!! You must be to check your fuel and oxgyen");
                                }
                                break;
                            case 2:
                                if (Fuel >= 15 && Oxygen >= 12)
                                {
                                    Fuel -= 15;
                                    Oxygen -= 12;
                                    Console.WriteLine("Travel successful! Welcome to Mars\n" +
                                        "Fuel consumed:10 \n" +
                                        "Remaining:" + Fuel + "\n" +
                                        "Oxygen consumed: 8 \n" +
                                        "Remaining:" + Oxygen);
                                    location = "Mars";
                                }
                                else
                                {
                                    Console.WriteLine("Travel not seccessful !!!! You must be to check your fuel and oxgyen");
                                }
                                break;
                            case 3:
                                if (!(mars_exp == true && mercury_exp == true && Minerals_mercury >= 4))
                                {
                                    Console.WriteLine("Europa is currently locked!" +
                                        "Missing requirements:\r\n");
                                    if (mars_exp == false)
                                        Console.WriteLine("- Complete Mars exploration.");
                                    if (mercury_exp == false)
                                        Console.WriteLine("- Complete Mercury exploration.");
                                    if (!(Minerals_mercury >= 4))
                                        Console.WriteLine("- Collect at least 4 minerals from Mercury. (Current: " + Minerals_mercury + ")");
                                }
                                else if (Fuel >= 20 && Oxygen >= 16)
                                {
                                    Fuel -= 20;
                                    Oxygen -= 16;
                                    Console.WriteLine("Travel successful! Welcome to Europa\n" +
                                        "Fuel consumed:10 \n" +
                                        "Remaining:" + Fuel + "\n" +
                                        "Oxygen consumed: 8 \n" +
                                        "Remaining:" + Oxygen);
                                    location = "Europa";
                                }
                                else
                                {
                                    Console.WriteLine("Travel not seccessful !!!! You must be to check your fuel and oxgyen");
                                }
                                break;
                        }
                        
                        break;
                    case 2:
                        
                        switch (location)
                        {
                            case "Mercury":

                                if (Energy >= 12 && Spaceship_health >= 31 && mercury_exp == false)
                                {
                                    Energy -= 12;
                                    Spaceship_health -= 5;
                                    credits += 15;
                                    Mission_score += 10;
                                    ++succesful_operation;
                                    ++Today_succesful_operation;
                                    Console.WriteLine("Exploration successful!\n" +
                                        "Energy consumed:12 \n" +
                                        "Remaining:" + Energy + "\n" +
                                        "Spaceship's health consumed: 5 \n" +
                                        "Remaining:" + Spaceship_health + "\n" +
                                        "Earned 15 Credits and 10 Points.\n" +
                                        "Current successful field operations: " + succesful_operation + "\n");
                                    mercury_exp = true;
                                }
                                else if (mercury_exp == false)
                                {
                                    Console.WriteLine("Travel not seccessful !!!! You must be to check your Spaceship's health and Energy");
                                }
                                else
                                {
                                    Console.WriteLine("Each planet can be  explored only once!!!");
                                }
                                break;
                            case "Mars":
                                if (Energy >= 18 && Spaceship_health >= 50 && mars_exp == false)
                                {
                                    Energy -= 18;
                                    Spaceship_health -= 10;
                                    credits += 25;
                                    Mission_score += 20;
                                    ++succesful_operation;
                                    ++Today_succesful_operation;
                                    Console.WriteLine("Exploration successful!\n" +
                                        "Energy consumed:18 \n" +
                                        "Remaining:" + Energy + "\n" +
                                        "Spaceship's health consumed: 10 \n" +
                                        "Remaining:" + Spaceship_health + "\n" +
                                        "Earned 25 Credits and 20 Points.\n" +
                                        "Current successful field operations: " + succesful_operation + "\n");
                                    mars_exp = true;
                                }
                                else if (mars_exp == false)
                                {
                                    Console.WriteLine("Travel not seccessful !!!! You must be to check your Spaceship's health and Energy");
                                }
                                else
                                {
                                    Console.WriteLine("Each planet can be  explored only once!!!");
                                }
                                break;
                            case "Europa":
                                if (Energy >= 25 && Spaceship_health >= 60 && europa_exp == false)
                                {
                                    Energy -= 25;
                                    Spaceship_health -= 15;
                                    credits += 40;
                                    Mission_score += 30;
                                    ++succesful_operation;
                                    ++Today_succesful_operation;
                                    Console.WriteLine("Exploration successful!\n" +
                                        "Energy consumed:25 \n" +
                                        "Remaining:" + Energy + "\n" +
                                        "Spaceship's health consumed: 15 \n" +
                                        "Remaining:" + Spaceship_health + "\n" +
                                        "Earned 40 Credits and 30 Points.\n" +
                                        "Current successful field operations: " + succesful_operation + "\n");
                                    europa_exp = true;
                                }
                                else if (europa_exp == false)
                                {
                                    Console.WriteLine("Travel not seccessful !!!! You must be to check your  Spaceship's health and Energy");
                                }
                                else
                                {
                                    Console.WriteLine("Each planet can be  explored only once!!!");
                                }
                                break;
                            default:
                                Console.WriteLine("You are not on the planet so you turn  the menu");
                                break;
                        }
                        
                        break;
                    case 3:
                        
                        switch (location)
                        {
                            case "Mercury":
                                if (mercury_collect == false)
                                {
                                    Console.WriteLine("You have already collected minerals in this planet  for today");
                                }
                                else
                                {
                                    Minerals += 2;
                                    Minerals_mercury += 2;
                                    Energy -= 8;
                                    ++succesful_operation;
                                    ++Today_succesful_operation;
                                    mercury_collect = true;
                                    Console.WriteLine("Mineral  collection successful!\n" +
                                        "Energy consumed: 8. Remaining:" + Energy + "\n" +
                                        "Collected 2 minerals from Mercury.\n" +
                                        "Current successful field operations: " + succesful_operation);
                                }
                                break;
                            case "Mars":
                                if (mars_collect == false)
                                {
                                    Console.WriteLine("You have already collected minerals in this planet for today ");
                                }
                                else
                                {
                                    Minerals += 3;
                                    Energy -= 10;
                                    ++succesful_operation;
                                    ++Today_succesful_operation;
                                    mars_collect = true;
                                    Console.WriteLine("Mineral collection successful!\n" +
                                        "Energy consumed: 10. Remaining:" + Energy + "\n" +
                                        "Collected 3 minerals from Mercury.\n" +
                                        "Current successful field operations: " + succesful_operation);
                                }
                                break;
                            case "Europa":
                                if (europa_collect == false)
                                {
                                    Console.WriteLine("You have already collected minerals in this  planet for today");
                                }
                                else
                                {
                                    Minerals += 4;
                                    Energy -= 12;
                                    ++succesful_operation;
                                    ++Today_succesful_operation;
                                    europa_collect = true;
                                    Console.WriteLine("Mineral collection successful!\n" +
                                        "Energy consumed: 12. Remaining:" + Energy + "\n" +
                                        "Collected 3 minerals from Mercury.\n" +
                                        "Current  successful field operations: " + succesful_operation);
                                }
                                break;
                        }
                        
                        break;
                    case 4:
                        

                        Console.WriteLine("--- SUPPLY STATION ---\n" +
                            "1. Buy Fuel (5 fuel for 12 C)\n" +
                            "2. Buy Oxygen (5 oxygen for 10 C)\n" +
                            "3. Recharge Energy (20 energy for 10 C)\n" +
                            "4. Repair Spaceship (20 health for 15 C)\n" +
                            "5. Sell All Minerals (6 C per mineral)\n" +
                            "6. Return to Main Menu\n" +
                            " ");
                        while (true)
                        {
                            Console.Write("Enter your choice :");
                            int supply_st = Convert.ToInt16(Console.ReadLine());
                            switch (supply_st)
                            {
                                case 1:
                                    Fuel += 5;
                                    credits -= 12;
                                    if (Fuel > 100)
                                        Fuel = 100;
                                    Console.WriteLine("Purchased 5 Fuel.\n" +
                                        "Current Credits:" + credits + " C \n" +
                                        " Current Fuel: " + Fuel + "\n");
                                    break;
                                case 2:
                                    Oxygen += 5;
                                    credits -= 10;
                                    if (Oxygen > 100)
                                        Oxygen = 100;
                                    Console.WriteLine("Purchased 5 Oxygen.\n" +
                                        "Current Credits:" + credits + " C \n" +
                                        " Current Fuel: " + Oxygen + "\n");
                                    break;
                                case 3:
                                    Energy += 20;
                                    credits -= 10;
                                    if (Energy > 100)
                                        Energy = 100;
                                    Console.WriteLine("Purchased 20 Energy.\n" +
                                        "Current Credits:" + credits + " C \n" +
                                        " Current Fuel: " + Energy + "\n");
                                    break;
                                case 4:
                                    Spaceship_health += 20;
                                    credits -= 15;
                                    if (Spaceship_health > 100)
                                        Spaceship_health = 100;
                                    Console.WriteLine("Purchased 20 health.\n" +
                                        "Current Credits:" + credits + " C \n" +
                                        " Current Fuel: " + Spaceship_health + "\n");
                                    break;
                                case 5:
                                    credits += Minerals * 6;
                                    Console.WriteLine("Sold " + Minerals + " minerals for " + Minerals * 6 + "C\n" +
                                        "Current Credits:" + credits + " C \n");
                                    Minerals = 0;
                                    break;
                            }
                            if (supply_st == 6)
                            {
                                Console.WriteLine("Returning to main menu...");
                                break;
                            }
                        }
                        break;
                    case 5:
                        Console.Write("MAİN QUESTİON-(To successfully explore all three—Mercury, Mars, and Europa.):");
                        if (mars_exp == true && mercury_exp == true && europa_exp == true)
                            Console.Write("Complated");
                        else
                            Console.Write("Not Finished ");

                        Console.Write("Mars exploration mission :");
                        if (mars_exp == true)
                            Console.Write("Complated");
                        else
                            Console.Write("Not Finished ");

                        Console.Write("Mercury exploration mission :");
                        if (mercury_exp == true)
                            Console.Write("Complated");
                        else
                            Console.Write("Not Finished ");

                        Console.Write("Europa exploration mission :");
                        if (europa_exp == true)
                            Console.Write("Complated");
                        else
                            Console.Write("Not Finished ");

                        Console.Write("A total of at least 4 minerals must have been collected from Mercury :");
                        if (Minerals_mercury >= 4)
                            Console.Write("Complated");
                        else
                            Console.Write("Not Finished ");
                        break;
                    case 6:
                        if (Today_succesful_operation < 2)
                        {
                            Console.WriteLine("You must be to take action minimum two succesful operations");
                        }
                        else
                        {
                            Console.WriteLine("Day End...");
                            Oxygen -= 5;
                            Energy += 10;
                            if (Energy > 100)
                                Energy = 100;
                            if (Oxygen <= 0)
                            {
                                Console.WriteLine("Your oxygen is finished!!\n" +
                                    "------Game Over-----");
                                return;
                            }
                            ++day;
                            Today_succesful_operation = 0;
                            mars_collect = false;
                            mercury_collect = false;
                            europa_collect = false;
                            check_bonus_puan = false;
                        }
                        break;
                    case 7:
                        Console.WriteLine("Space Mission Simulator ending...");
                        return;
                        break;
                    default:
                        break;
                }
                if (mars_collect == false && mercury_collect == false && europa_collect == false && check_bonus_puan == false)
                {
                    Mission_score += 10;
                    check_bonus_puan = true;
                }
                if (Lifeline == true && Oxygen <= 15)
                {
                    Console.WriteLine("╔═══════[ LIFELINE PROTOCOL ]═══════╗\n" +
                                      "║                                   ║\n" +
                                      "║   >> OXYGEN SUPPLY ....... +20    ║\n" +
                                      "║   >> LIFE SUPPORT ........ ONLINE ║\n" +
                                      "║   >> USAGE LIMIT ......... 1 -> 0 ║\n" +
                                      "║                                   ║\n" +
                                      "║   !! NO USES REMAINING !!         ║\n" +
                                      "╚═══════════════════════════════════╝");
                    Oxygen += 20;
                    Lifeline = false;
                }
                if (Today_succesful_operation >= 5)
                {
                    Console.WriteLine("Day End...");
                    Oxygen -= 5;
                    Energy += 10;
                    if (Energy > 100)
                    if (Oxygen <= 0)
                    {
                        Console.WriteLine("Your oxygen is finished!!\n" +
                            "------Game Over-----");
                        return;
                    }
                    ++day;
                    Today_succesful_operation = 0; 
                    mars_collect = false;
                    mercury_collect = false; 
                    europa_collect = false;
                    check_bonus_puan = false;
                }
                if (mars_exp == true && mercury_exp == true && europa_exp == true)
                {
                    Console.WriteLine("----- You Win -----");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
