using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w04
{
    //classes are definition of real world object.
    //classes are not object, they are definition of objects.
    class Person
    {
        #region Members

        #region A-Static Members

        //...
        //static fields
        public static int count = 0;//static members cannot be reached from instances/object
        //can only be reached from class name

        //static method
        public static void WhatIsCount()
        {
            Console.WriteLine(count);
        }

        #endregion

        #region B-Instance Members

        //01.Field members: Variables,Data//recommended to be defined private ------------------1--------------------------
        private string _name;
        private string _lastName;
        private int _age;

        //02.Property Members: can be thought as a method or a field. -------------------------2-------------------
        //02.01.java style getter and setters
        public void setName(string name)
        {
            this._name = name;
        }
        public string getName()
        {
            return this._name;
        }
        //02.02.c# long style getter and setters
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                this._lastName = value;
            }
        }
        //02.03.c# simple style getter and setters
        public int Age { get; set; }



        //03. Method Members   -----------------------3---------------------
        public void IntroduceYourself()
        {
            Console.WriteLine($"Hello, I'm {_name} and I'm {Age} years old.");
        }
        private int CalculateBirthYear()
        {
            return DateTime.Now.Year - Age;
        }



        //04. Constructor Method Members -------------------4-------------------------
        //default constructor 1
        public Person() //default constructor
        {
            count++;
            //we can do here some extra modification...
            // _lastName = "No data";
        }

        //overloaded constructor 2
        public Person(string name) //default constructor
        {
            count++;

            _name = name;
            //we can do here some extra modification...
            // _lastName = "No data";
        }
        //overloaded constructor 3
        public Person(string name,string lastName) //default constructor
        {
            count++;

            _name =name;
            _lastName=lastName;

            //we can do here some extra modification...
            // _lastName = "No data";
        }
        //overloaded constructor 4
        public Person(string name, string lastName,int age) //default constructor
        {
            count++;

            _name = name;
            _lastName = lastName;
            _age = age;
            //we can do here some extra modification...
            // _lastName = "No data";
        }


        //05.Indexer Method Members -----------------------5---------------------
        public dynamic this[string param]
        {
            get
            {
                if (param=="name")
                {
                    return _name;
                }
                else if (param == "lastName")
                {
                    return _lastName;
                }
                else if (param == "age")
                {
                    return _age;
                }
                else
                {
                    throw new Exception("Wrong param...");
                }
    

            }
            set
            {

                if (param == "name")
                {
                     _name=value;
                }
                else if (param == "lastName")
                {
                    _lastName=value;
                }
                else if (param == "age")
                {
                     _age=value;
                }
                else
                {
                    throw new Exception("Wrong param...");
                }

             
            }

        }

        //06. Destructor Methods
        ~Person()
        {
            //when deleting object from the memory you can do some extra ops here...
        }

        #endregion
        
        #endregion

    }
}
