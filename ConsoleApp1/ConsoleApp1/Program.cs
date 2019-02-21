using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1

{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt the user for the width, length, and price per sq foot 
            //of the room and carpet that they want to lay carpet in. 
            //then calculate the cost for carpeting that room. 

            //INPUT 
            double roomLength, roomWidth;
 
            decimal pricePerSqFt, costForRoomCarpet;

            string inputString;

            const decimal DISCOUNT_RATE = 0.10m; //declare a 10% discount for cash customers 


            // prompt the user for the lengh and the width 
            Console.Write("Please enter room length in feet:");
            roomLength = Convert.ToDouble(Console.ReadLine()); //convert the user input into double and stor ein roomlength
            // or do it the other way 

            Console.Write("Please enter room width in feet:");
            inputString = Console.ReadLine();   //reading user input                     
            roomWidth = Convert.ToDouble(inputString); // converting user intput into a double and store in roomwidth 
            roomWidth = Convert.ToDouble(inputString);

            //
            Console.Write("Please enter the Price per sq ft of the carpet you want:");
            inputString = Console.ReadLine(); //read the user input 
            pricePerSqFt = Convert.ToDecimal(inputString); //convert the user input into PricePerSqft and store it for later 


            //PROCESSING/CALCULATIONS 
            costForRoomCarpet = Convert.ToDecimal(roomWidth * roomWidth) * pricePerSqFt;
            //put () around the ones you want to conver to decimal . no need to conver the pricepersqt 
            //because it's already declared as decimal 
            //1) roomwidth and roomwith was double , use () to multiply together 
            //2) the program will then convert them to decimal 
            //3) then it will times it with price per sqFt 
            //4) then put the value int cost for room carpet 

            Console.Write("Do your want to be a cash customer for a 10% discount?(Y/N)");
            inputString = Console.ReadLine(); //readline ususlally is followed by user input code 
            
            if (inputString.CompareTo("Y")==0) // no ; for IF statement . when we are checking if "two" things are equal, we use two 
                                               //equal sign. One equal sign is assigning value. if the 0 is not equal to string , then exculte the next code) 
            {
                costForRoomCarpet = costForRoomCarpet - costForRoomCarpet * DISCOUNT_RATE;
                // Put the {} in for each line of code 
            }


            //OUTPUT 

            Console.Write($"Cost to carpet your room is {costForRoomCarpet:C}");
            //a : and C at the end of input will change it into currency , doesn't matter if it's lower or capital 





            Console.ReadKey(); 

        }
    }
}
