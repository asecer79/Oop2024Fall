using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w06.AnimalOperations.Abstract
{
    //an interface is a contract or a blueprint for a class. It defines a set of methods, properties, events, or indexers without implementing them. Interfaces specify what a class must do, but not how it does it. They are used to achieve abstraction, loose coupling, and multiple inheritance-like behavior
    public interface IAnimal
    {
        //we don't need access modifiers in interfaces
        //method signatures
        void Eat(); //without body
        void Sleep();//without body
        string MakeSound();//without body

        void Run();

    }
}
