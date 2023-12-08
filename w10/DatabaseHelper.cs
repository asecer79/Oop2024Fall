using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace w10
{
    /*
       Events in C#,Java are a way to provide a mechanism for communication between objects. They are used in situations where an object needs to notify other objects that something has happened. In C# and .NET, Java, events are based on the delegate model, which provides a way to reference methods with a specific set of arguments and return type.     
     */

    /*
        Delegate Declaration: Before declaring an event, you need to declare a delegate that defines the signature of the event handler method. This delegate will be used to type the event.

        Event Declaration: An event is declared using the event keyword followed by the delegate type. This event can then be subscribed to by event handlers (methods) that match the delegate signature.

        Event Subscription: Other objects or classes subscribe to the event by attaching an event handler method to the event. This is usually done using the += operator.

        Raising the Event: When the event occurs (i.e., when the specific condition is met), the event is raised using the event keyword. All subscribed event handlers are then called.

        Event Unsubscription: Event handlers can be unsubscribed using the -= operator.
    */

    public class DatabaseHelper
    {
        //Step 1
        // public delegate void BackupCompletedDelegate(object sender,EventArgs e);
        public delegate void BackupCompletedDelegate();
        //Step 2
        public event BackupCompletedDelegate BackupCompleted;

        //event 2
        public delegate void BackupStartedDelegate();
        public event BackupStartedDelegate BackupStarted;
        //event 3
        public delegate void DatabaseShutDownDelegate();
        public event DatabaseShutDownDelegate DatabaseShutDownCompleted;

        public void GetBackup()
        {
            //backup processes....
            //...

            Console.WriteLine("Backup Completed");
            OnBackupCompleted();
        }

        public void StartBackup()
        {
            //backup start processes....
            //...

            Console.WriteLine("Backup Started");
            OnBackupStarted();
        }

        public void ShutDown()
        {
            //ShutDown processes....
            //...

            Console.WriteLine("ShutDown Completed");
            OnDatabaseShutDownCompleted();
        }


        protected virtual void OnBackupCompleted()
        {
            BackupCompleted?.Invoke();
        }

        protected virtual void OnBackupStarted()
        {
            BackupStarted?.Invoke();
        }

        protected virtual void OnDatabaseShutDownCompleted()
        {
            DatabaseShutDownCompleted?.Invoke();
        }
    }
}
