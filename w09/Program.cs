
namespace w09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student student = new Student();
            //// student.PropertyChanged += Student_PropertyChanged;

            // student.Name = "Aydın";
            // student.Age = 42;

            // Student student1 = new Student();
            // // student.PropertyChanged += Student_PropertyChanged;

            // student1.Name = "Aydın";
            // student1.Age = 99;

            // //event, change

            // List<Student> studentList = new List<Student>();
            // studentList.Add(student);
            // studentList.Add(new Student(){Age = 23,Name = "Zeynep"});
            // studentList.Add(new Student() { Age = 34, Name = "Şaziye" });


            // //studentList.Sort();

            // StudentComparer studentComparer = new StudentComparer();

            // //foreach (var item in studentList)
            // //{
            // //    //Console.WriteLine(item.Name);
            // //    Console.WriteLine($"{student.Name}?= {item.Name}: " + studentComparer.Compare( student, item));
            // //}


            // Console.WriteLine(student.Equals(student1));
            // Console.WriteLine(studentComparer.Equals(student,student1));

            //BookCollection books = new BookCollection();
            //books.Add(new Book() { Author = "Aydın", Title = "Java" });
            //books.Add(new Book() { Author = "Murtaza", Title = "Language" });
            //books.Add(new Book() { Author = "Memnune", Title = "Real life" });

            //foreach (var book in books)
            //{
            //    Console.WriteLine(book.Author);
            //}


            var myToys = new ToyCollection();
            myToys.Add(new Toy("Teddy Bear"));
            myToys.Add(new Toy("Lego Set"));
            myToys.Add(new Toy("Rubik's Cube"));

            foreach (var toy in myToys)
            {
                Console.WriteLine(toy.Name);
            }

            Console.WriteLine($"Total toys: {myToys.Count}");


            MySpecialCollection<Toy> toys = new MySpecialCollection<Toy>();
            MySpecialCollection<Book> books = new MySpecialCollection<Book>();
            books.Add(new Book(){Author = "Aydın",Title = "aa"});
            books.Add(new Book() { Author = "Aydın", Title = "bb" });
            books.Add(new Book() { Author = "Mahmut", Title = "cc" });


            var result = books.FindAll(p =>
                p.Author == "Mahmut" //&&
               // p.Title =="aa"
                
                );




        }

        private static void Student_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            Console.WriteLine($"{e.PropertyName} has been changed, do the appropriate job as your requirements");

            //..... send email
            //..... write log
            //..... .....



        }
    }




}




