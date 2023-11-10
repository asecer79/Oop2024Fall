using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using w06.AnimalOperations.Abstract;

namespace w06.AnimalOperations.Concrete
{
    //concrete 
    public class Lion:IAnimal//implementation  (!= inheritance)
    {
        public void Eat() //concrete method
        {
            Console.WriteLine("The lion is eating meat.");
        }

        public void Sleep()//concrete method
        {
            Console.WriteLine("The lion is sleeping.");
        }

        public string MakeSound()//concrete method
        {
            return "Roar";
        }

        public void Run()
        {
            throw new NotImplementedException();
        }
    }
}
