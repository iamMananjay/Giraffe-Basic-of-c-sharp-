using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe1
{
    class Book  //class is like a template 
    {

        public string BookName; //attribute of class
        public string AurthorName;
        public int PageNumber;


        //constructor 
        //It is create with same class name 
        //It is a special type of method that create inside the class and call automatically 
        //when object is created


        public Book( string aBookName ,string aAurthName , int aPageNumber )
        {
            BookName = aBookName;
            AurthorName = aAurthName;
            PageNumber = aPageNumber;
        }
    }
}
