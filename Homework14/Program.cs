using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Разработать абстрактный класс Animal, который описывает животное. Класс содержит следующие элементы:

//абстрактное свойство - название животного.
//В классе Animal нужно определить следующие методы:

//конструктор, устанавливающий значение по умолчанию для названия;
//абстрактный метод Say(), который выводит звук, который издает животное;
//неабстрактный метод ShowInfo(), который выводит на консоль последовательно название, а затем звук (вызывая метод Say()).
//Разработать классы Cat и Dog, которые реализуют абстрактный класс Animal. В классах реализовать следующие элементы:

//свойство – название животного;
//метод Say(), выводящий на экран «Мяу» либо «Гав» соответственно.
//Создайте экземпляры классов Cat и Dog и проверьте их работоспособность.


namespace Homework14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name1 = "Имя1";
            string name2 = "Имя2";
            Animal cat = new Cat(name1);
            cat.ShowInfo();
            Animal dog = new Dog(name2);
            dog.ShowInfo();
            Console.ReadKey();
        }
    }


    abstract class Animal
    {
        public abstract string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public abstract void Say();

        public void ShowInfo()
        {
            Console.WriteLine(Name);
            Say();
        }
    }

    class Cat : Animal
    {
        string name;

        public Cat(string name) 
            : base(name)
        {
        }

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
    }

    class Dog : Animal
    {
        string name;

        public Dog(string name) : base(name)
        {
        }

        public override string Name
        {
            get => name;
            set => name = value;
        }

        public override void Say()
        {
            Console.WriteLine("Гав");
        }
    }
}
