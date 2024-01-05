using System;
using System.Reflection;
using System.Security.Cryptography;

namespace w12
{

    class Program
    {
        static void Main(string[] args)
        {
            //Type class
            // string info
            Type type = typeof(string);

            //Console.WriteLine(type.Namespace);
            //Console.WriteLine(type.Name);
            //Console.WriteLine(type.FullName);


            //current assembly
            //Assembly assembly = Assembly.GetExecutingAssembly();
            //Console.WriteLine(assembly.GetName().Name);
            //Console.WriteLine(assembly.GetName().Version);


            //foreach (var member in type.GetMembers())
            //{
            //    Console.WriteLine(member.Name);

            //}

            Type studentType = typeof(Student);

            //Console.WriteLine(studentType.FullName);
            //Console.WriteLine(studentType.Namespace);
            //Console.WriteLine(studentType.Name);

            //Assembly assembly = Assembly.GetAssembly(typeof(Student));

            //Console.WriteLine(assembly.GetName().Name);
            //Console.WriteLine(assembly.GetName().Version);



            //foreach (PropertyInfo property in studentType.GetProperties())
            //{
            //    Console.WriteLine(property.Name);
            //}

            //foreach (MethodInfo method in studentType.GetMethods( BindingFlags.NonPublic | BindingFlags.Instance))
            //{
            //    Console.WriteLine(method.Name);
            //}


            MethodInfo mi = studentType.GetMethod("WhoAreYou");

            object studentInstance = Activator.CreateInstance(studentType);

            mi.Invoke(studentInstance, null);


           Description classAttribute = studentType.GetCustomAttribute<Description>();

           Console.WriteLine(classAttribute.ExtraInfo);


        }
    }

   // [Log]
    [Description("This class is written for students...")]
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }


        [Description("Greeting method")]
        [Log]
        public void WhoAreYou()
        {
            Console.WriteLine($"Hello I am {FirstName} {LastName}");
            //....
        }

        private void Think(string message)
        {
            //......
        }
    }

    //aspect oriented

    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method)]
    class Description:Attribute
    {
        public string ExtraInfo { get; private set; }

        public Description(string extraInfo)
        {
            ExtraInfo = extraInfo;
        }
    }

    [AttributeUsage(AttributeTargets.Method)]
    class Log : Attribute
    {
       // public string ExtraInfo { get; private set; }

       //...
    }



}