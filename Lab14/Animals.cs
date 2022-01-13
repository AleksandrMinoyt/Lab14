using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract public class Animal
    {
        public abstract string Name { get; set; }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.Write(Name + " говорит ");
            Say();
        }

        protected Animal()
        {          
                Name = "Безымянное животное";           
        }      

    }

    public class Cat:Animal
    {
        private string _name;

        public override string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if(value.Length>0)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Имя не может быть пустым");
                }
            }
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }

    }

    public class Dog : Animal
    {
        private string _name;

        public override string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (value.Length > 0)
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Имя не может быть пустым");
                }
            }
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
