namespace w04
{

    class Program
    {
        static void Main(string[] args)
        {
            //dataType objectName/object/instance/  = objectCreatorKeyword(new) dataType( ()=defaultConstructorMethod/object creator method) 
            Person person = new Person();
            Console.WriteLine($"The number of Object: {Person.count}");
            //class object = createNew class (creatorMethod)

            //property usage
            person.setName("Aydın");
            Console.WriteLine(person.getName());
            // person.age = 45;
            // person.lastName = "Seçer";
            person.LastName = "Seçer";//setter
            Console.WriteLine(person.LastName);//getter
            person.Age = 12;//setter
            Console.WriteLine(person.Age);//getter

            //method m
            person.IntroduceYourself();

            Person person1 = new Person();//default call opt1
            Console.WriteLine($"The number of Object: {Person.count}");

            Person person2 = new Person("Mualla");//overloaded call opt2
            Console.WriteLine($"The number of Object: {Person.count}");

            Person person3 = new Person("Ayşe","Turunç");//overloaded call opt3
            Console.WriteLine($"The number of Object: {Person.count}");

            Person person4 = new Person("Emine", "Karaca",25);//overloaded call opt4
            Console.WriteLine($"The number of Object: {Person.count}");

            person4["name"] = "Fatma";//setter

            Console.WriteLine(person4["name"]);//getter

            Console.WriteLine(person4["age"]);//getter


            //Console.WriteLine(person.count);
            //Console.WriteLine(person1.count);
            //Console.WriteLine(person2.count);
            //Console.WriteLine(person3.count);
            //Console.WriteLine(person4.count);


        }


        //compounds definition/coupled def./inner class def./not frequently used....
        //class Human
        //{
        //}
    }


    //class is definition of any real world object/entity
    //class Human
    //{
    //}

}

