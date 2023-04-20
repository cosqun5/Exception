using Exception_Task.Utilites.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Task.Models
{
    public class Human
    {
        #region Metod ile yazilmis task

        //public Human()
        //{

        //}
        //public string Name { get; set; }
        //public string Surname { get; set; }
        //public int Age { get; set; }
        #endregion

        #region Get,Set ile yazilmis task

        public Human()
        {

        }
        public Human(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public string Name { get; set; }
        public string Surname { get; set; }

        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if ( value<= 0)
                {
                    throw new MyExcepition("Enter your age correctly!");
                }
                _age = value;
                Console.WriteLine("The information saved");
            }
        }
        #endregion
    }
}
