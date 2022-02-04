using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe1
{
    class Program
    {
        static void Main(string[] args)  //By default method
        {

            //------------------------variable and Various Data Type in C sharp------------------------

            string PersonName = "Mananjay Shrestha";
            int PersonAge = 23;
            string PersonGender = "Male";
            bool isPersonGender = true;
            string PersonAddress;
            PersonAddress = "Gwarko";
            char PersonNameStart = 'M';  //note : - char in single quotes 
            //float it is less used and decimal is manily for money 
            double PersonGpa = 3.8;  // we can decimal as well as integer value 

            Console.WriteLine("Hey My Name is " + PersonName + ". I am " + PersonAge + 
                ". I am a " + PersonGender + " and it is " + isPersonGender +". I live in " 
                + PersonAddress + ". He got " + PersonGpa + " in SLC. " 
                + PersonNameStart + " is a first letter of my name." );

            //-----------------------working with string in c shrap-----------------------------------

            //print in new line 
            Console.WriteLine("FirstLine\nsecondline");
            //print quotes inside the line 
            Console.WriteLine("Hey\"s" );
            //print the length of the string
            Console.WriteLine(PersonName.Length);
            //print the string into uppercase
            Console.WriteLine(PersonName.ToUpper());
            //To find the word is present or not in boolean form
            Console.WriteLine(PersonName.Contains("S"));
            //To print the character each 
            Console.WriteLine(PersonName[5]);
            //To find the charcter and the index number
            Console.WriteLine(PersonName.IndexOf("Shrestha"));
            //To print from one index number to another 
            Console.WriteLine(PersonName.Substring(5,8));  //starting index and upto the length


            //-----------------------working with Number in c shrap-----------------------------------

            Console.WriteLine( (4 + 2) * 3);

            //used all math object method
            Console.WriteLine(Math.Abs(-40));  //result 40

            Console.WriteLine(Math.Pow(3,2)); //result 9

           //-----------------------Getting User Input in c shrap-----------------------------------

            Console.WriteLine("Enter You name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Your Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your GpA:");
            double gpA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Hey " + name + " and you are " + age + ". And My gpa is " + gpA + ".");
            

            //---------------------------------Array in c shrap-----------------------------------

            //intger array
            int [] IntArrayNumber = { 1,2,33,4,5,6};
            //change the array element inside 
            IntArrayNumber[2]= 3;
            Console.WriteLine(IntArrayNumber[2]);

            //string array 
            string [] FriendList = new string [10];  // if you dont know how many array element we hold there
                                                     // the just put the number of element in array
            FriendList[0]="Alina Heka";
            Console.WriteLine(FriendList[0]);

            //called a method inside main method with passing argument
            SayHi("Alisha Heka");

            //called a method which has return Type 
          Console.WriteLine(  cube(5));

            //----------------------------------If else condition-------------------------------
             bool isMale = true;
            bool isTall = false;

            if (isMale && isTall) {
                Console.WriteLine("You are tall and male");
            }
            else if (isMale && !isTall) {
                Console.WriteLine("You are male but not tall");
            }
            else if (!isMale && isTall) {
                Console.WriteLine("Your are not male but tall");
            }
            else
            {
                Console.WriteLine("You are not tall and male");
            }

            //----------------------------------for loop-------------------------------------------
            
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            };
            int[] ArrayNumbers = { 4, 6, 8, 9, 10 }; //array of integer

            for ( int i = 0; i < ArrayNumbers.Length; i++ ) {
                Console.WriteLine(ArrayNumbers[i]);

            };

            //-------------------------------------2 dimensional array----------------------------------

            int[,] TwoDimensionalArray =
            {
                {2,3 },
                {3,4 },
               {5,6 }
            };

            ////We can by default set how many row and column need 

            int [,] TwoDArray = new int  [2,3];  //two row three coulmen

            Console.WriteLine(TwoDimensionalArray[1, 0]);


           //----------------------------------Exception HAndling-------------------------------

            try
            {
               Console.WriteLine("Enter a first number:");
               int fNumber = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Enter a Second number:");
                int SNumber = Convert.ToInt32(Console.ReadLine());

               Console.WriteLine(fNumber / SNumber);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();


            //-------------------------------------------object------------------------------------------

            Book book1 = new Book("Lod","Mananjay",25);
            //book1.BookName = "Lord of ring";    
            //book1.AurthorName = "Mananjay Shrestha";
            //book1.PageNumber = 25;


            //create object 
            Student student1 = new Student("Alina Heka","bachloer", 3 ) ;
            Student student2 = new Student("Mananjay Heka", "bachloer", 2 );


            Console.WriteLine(student1.grade);
            //Console.WriteLine(student1.Rating);
            //Console.WriteLine(student2.Rating);

            Console.WriteLine(student1.hasHonor()); //calling object method

            Console.WriteLine(book1.BookName);

        }
        
        //----------------------------------Method in c shrap-----------------------------------
        //Method is a block of code where we can perform a spcific task

        //--------------------Method without return type---------------------------------------
        //void doesn't return anything
        static void SayHi( string ladyName)
        {
            Console.WriteLine("Hello " + ladyName);
        }

       //--------------------Method with return type---------------------------------------

        static int cube(int num)
        {
            int result = num * num * num;

            return result;
        }











    }
}
