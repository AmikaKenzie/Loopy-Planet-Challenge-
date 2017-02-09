using System;
class MainClass
{
    public static void Main(string[] args)
    {
        int Menu_Planets;  //Assigns number to planet
        double weight;     //ASSIGNS AN OUTPUT OF TWO OR MORE NUMBERS OR DECIMAL

        string myName;    //REPRESENTS A VALUE AS TEXT
        Console.WriteLine("HELLO Please enter your name\n");
        myName = Console.ReadLine();
        

        Console.Write("\n\n");
        Console.WriteLine("           Menu of Planets          ");
        Console.WriteLine("           ==== == =======          ");
        Console.WriteLine("1. Jupiter    2. Mars     3. Mercury");
        Console.WriteLine("4. Neptune    5. Pluto    6. Saturn ");
        Console.WriteLine("7. Uranus     8. Venus    9. <Quit> ");
        Console.Write("\n\n");

        do   //TELLS THE PROGRAM EXACTLY WHAT TASKS TO PERFORM
        {

            // Get user input
            Console.WriteLine("Enter weight on earth:");
            weight = Convert.ToDouble(Console.ReadLine());   // YOU HAVE STRING INPUT HERE AS A NUMBER
            Console.WriteLine();                             // CHANGED TO DOUBLE
            Console.WriteLine("\nSelect Menu Choice:\n");
            Menu_Planets = Convert.ToInt32(Console.ReadLine());

            //SWITCH STATEMENTS TO EXECUTE EACH CASE SELECTED WITH A CORRECT OUTPUT
            switch (Menu_Planets)
            {
                case 1:     //Jupiter
                    Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + 2.64 * weight + " pounds on Jupiter\n"); //Multiplies weight by
                    break;

                case 2:     //Mars
                    Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + 0.38 * weight + " pounds on Mars\n");
                    break;

                case 3:     //Mercury
                    Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + 0.37 * weight + " pounds on Mercury");
                    break;

                case 4:     //Neptune
                    Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + 1.12 * weight + " pounds on Neptune\n");
                    break;

                case 5:     //Pluto
                    Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + 0.04 * weight + " pounds on Pluto\n");
                    break;

                case 6:     //Saturn
                    Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + 1.15 * weight + " pounds on Saturn\n");
                    break;

                case 7:     //Uranus
                    Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + 1.15 * weight + " pounds on Uranus\n");
                    break;

                case 8:     //Venus
                    Console.WriteLine("Your weight of " + weight + " pounds on Earth would be " + 0.88 * weight + " pounds on Venus\n");
                    break;


                case 9:
                    Console.WriteLine("Have a Nice Day. GoodBye\n");  //EXITS LOOP AND QUITS THE PROGRAM
                    break;

                default:
                    Console.WriteLine("You entered an invalid number. Choose from 1-8 only.\n");  //DEFAULT ERROR FOR WRONG SELECTION
                    Console.WriteLine("Enter a choice from 1-9: ");
                    break;
            }
        } while (Menu_Planets != 9);  //DETERMINES HOW THE PROGRAM ENDS
    }           
}