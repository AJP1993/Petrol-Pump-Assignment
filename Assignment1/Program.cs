using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment1
{
    class Program
    {
              
        static void Main(string[] args)
        {
            double fourStarPrice = 1.15;
            double unleadedPrice = 1.20;
            double dieselPrice = 1.25;

            double Cost = 0;
            double Payment;

            int fourStarVol = 100;
            int unleadedVol = 100;
            int dieselVol = 100;
            int volRequested;

            int choice = 0;
            int paid = 0;

            while (choice != 5)
            {
                Console.WriteLine("********************");
                Console.WriteLine("*Petrol Pump Menu  *");
                Console.WriteLine("********************");
                Console.WriteLine("1. Four Star Petrol - £" + fourStarPrice + " per litre. Volume available: " + fourStarVol + " Litres");
                Console.WriteLine("2. Unleaded Petrol - £" + unleadedPrice + " per litre. Volume available: " + unleadedVol + " Litres");
                Console.WriteLine("3. Diesel - £" + dieselPrice + " per litre. Volume available: " + dieselVol + " Litres");
                Console.WriteLine("4. View bill and pay");
                Console.WriteLine("5. Exit");
                Console.WriteLine("********************");
                Console.WriteLine("Please select an option");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("********************");
                    Console.WriteLine("*Four Star Petrol  *");
                    Console.WriteLine("********************");
                    
                    Console.WriteLine("Volume available: " + fourStarVol + " Litres");
                    Console.WriteLine("Please enter the volume of petrol you want:");
                    volRequested = Convert.ToInt32(Console.ReadLine());

                    if (volRequested <= fourStarVol)
                    {
                        fourStarVol = fourStarVol - volRequested;

                        Cost = Cost + (fourStarPrice * volRequested);
                        
                        Console.WriteLine("You have ordered " + volRequested + " litres of Four Star Petrol for £" + (fourStarPrice * volRequested));
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                    }
                }

                if (choice == 2)
                {
                    Console.WriteLine("********************");
                    Console.WriteLine("*Unleaded Petrol   *");
                    Console.WriteLine("********************");
                    
                    Console.WriteLine("Volume available: " + unleadedVol + " Litres");
                    Console.WriteLine("Please enter the volume of petrol you want:");
                    volRequested = Convert.ToInt32(Console.ReadLine());

                    if (volRequested <= unleadedVol)
                    {
                        unleadedVol = unleadedVol - volRequested;

                        Cost = Cost + (unleadedPrice * volRequested);

                        Console.WriteLine("You have ordered " + volRequested + " litres of Unleaded Petrol for £" + (unleadedPrice * volRequested));
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                    }
                }

                if (choice == 3)
                {
                    Console.WriteLine("********************");
                    Console.WriteLine("*Diesel            *");
                    Console.WriteLine("********************");
                    
                    Console.WriteLine("Volume available: " + dieselVol + " Litres");
                    Console.WriteLine("Please enter the volume of diesel you want:");
                    volRequested = Convert.ToInt32(Console.ReadLine());

                    if (volRequested <= dieselVol)
                    {
                        dieselVol = dieselVol - volRequested;

                        Cost = Cost + (dieselPrice * volRequested);
                        
                        Console.WriteLine("You have ordered " + volRequested + " litres of Diesel for £" + (dieselPrice * volRequested));
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("Invalid input");
                        Console.WriteLine("Press Enter to continue...");
                        Console.ReadLine();
                    }
                }

                if (choice == 4)
                {
                    Console.WriteLine("********************");
                    Console.WriteLine("*Bill              *");
                    Console.WriteLine("********************");

                    paid = 0;

                    if (fourStarVol < 100)
                    {
                        Console.WriteLine("Four Star Petrol: " + (100 - fourStarVol) + " litres");
                        Console.WriteLine("Price: £" + ((100 - fourStarVol) * fourStarPrice));
                        Console.WriteLine();
                    }

                    if (unleadedVol < 100)
                    {
                        Console.WriteLine("Unleaded Petrol: " + (100 - unleadedVol) + " litres");
                        Console.WriteLine("Price: £" + ((100 - unleadedVol) * unleadedPrice));
                        Console.WriteLine();
                    }

                    if (dieselVol < 100)
                    {
                        Console.WriteLine("Diesel: " + (100 - dieselVol) + " litres");
                        Console.WriteLine("Price: £" + ((100 - dieselVol) * dieselPrice));
                        Console.WriteLine();
                    }

                    Console.WriteLine("Total Price = £" + Cost);
                    Console.WriteLine();
                    Console.WriteLine("Press enter to continue to payment");
                    Console.ReadLine();

                    Console.WriteLine("********************");
                    Console.WriteLine("*Payment           *");
                    Console.WriteLine("********************");

                    while (paid == 0)
                    {
                        Console.WriteLine("Please enter your payment for the goods:");
                        Payment = Convert.ToDouble(Console.ReadLine());

                        if (Payment < Cost)
                        {
                            Console.WriteLine("Insufficient payment");
                            Console.WriteLine("Please pay entire cost of the goods");
                            Console.ReadLine();

                        }

                        else
                        {
                            paid = 1;
                        }

                        if (Payment > Cost)
                        {
                            paid = 1;

                            Console.WriteLine("Change required: £" + (Payment - Cost));
                            Console.WriteLine("Press enter to complete payment");
                            Console.ReadLine();
                        }                                               
                    }
                
               
                    Console.WriteLine("Payment complete");
                    Console.WriteLine("Press enter to return to the menu");
                    Console.ReadLine();

                }

                if (fourStarVol == 0 & unleadedVol == 0 & dieselVol == 0 & paid == 1)
                {
                    break;
                }
                
                if (choice != 1 & choice != 2 & choice != 3 & choice != 4 & choice != 5)
                {
                    Console.WriteLine("Invalid input");
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }

            Console.WriteLine("Thank you for using the Petrol Payment System");
            Console.WriteLine("Have a good day!");
            Console.ReadLine();
        }
    }
}
    

