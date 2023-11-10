
using System.Diagnostics;
using w06.AnimalOperations.Abstract;
using w06.AnimalOperations.Concrete;
using w06.Business;
using w06.Logging.Abstract;
using w06.Logging.Concrete;
using w06.SecurityOperations.Concrete;

namespace w06
{
    /*
     * Abstraction: The IAnimal interface provides an abstract layer. The zoo system doesn't need to know the details of how each animal eats or sleeps, just that they can perform these actions.
     * Interchangeability: Since both Lion and Elephant implement IAnimal, they can be used interchangeably wherever an IAnimal is expected.
     * Extensibility: It’s easy to introduce new animals to the system. As long as the new animal class implements IAnimal, it can be integrated seamlessly.
     * Testability: Interfaces make it easier to unit test your code as you can mock interface implementations.
     * Loose Coupling: Interfaces help in reducing the coupling between different parts of the application.
     *
     */
    class Program
    {
        static void Main(string[] args)
        {/*
            // IAnimal animal1 = new IAnimal(); //err interfaces cannot be created as an object by new keyword
            IAnimal animal1 = new Lion(); 
            
            EducateAnimal(animal1);
            EducateAnimal(new Lion());
            EducateAnimal(new Elephant());
            */

            /*
            //injection of dependency
            SecurityService securityService1 = new SecurityService(new AdvancedUserService());
            //SecurityService securityService2 = new SecurityService(new BasicSecurityService());

            securityService1.Login("Aydın", "123");


            LoggerService ls = new LoggerService(new FileLogger());


            ls.LogInfo("asd");


            ls.LogWrite("ssdf");
            */






        }


        static void EducateAnimal(IAnimal animal)
        {
            animal.Eat();
            animal.MakeSound();
            animal.Sleep();
        }

    }
}

