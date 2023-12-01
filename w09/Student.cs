using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace w09
{
    public class Student : INotifyPropertyChanged,IComparable,IComparable<Student>,IEquatable<Student>
    {

        private string _name;
        private int _age;

        public string Name
        {
            set
            {
                _name = value;
                OnPropertyChanged(nameof(Name));
            }
            get { return _name; }
        }

        public int Age
        {
            set
            {
                _age = value;
                OnPropertyChanged(nameof(Age));
            }
            get { return _age; }
        }


        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public int CompareTo(object? obj)
        {
            var incoming = obj as Student;
            return this.Name.CompareTo(incoming.Name);
        }

        public int CompareTo(Student? incoming)
        {
            return this.Name.CompareTo(incoming.Name);
        }

        public bool Equals(Student? incoming)
        {
            return incoming.Age==this.Age && incoming.Name == this.Name;

        }
    }


    public class StudentComparer : IComparer<Student>,IEqualityComparer<Student>
    {
        public int Compare(Student? x, Student? y)
        {
            return x.Name.CompareTo(y.Name);
        }

        public bool Equals(Student? first, Student? second)
        {
            return GetHashCode(first) == second.Name.GetHashCode();
        }

        public int GetHashCode(Student first)
        {
           return first.Name.GetHashCode() ;
        }
    }
}
