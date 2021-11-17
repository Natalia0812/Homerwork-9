using System;
using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Transport<Venicle> transport = new Transport<Venicle>();

            Boat b1 = new Boat() { NumberOfBoat=1};
            Boat b2 = new Boat() { NumberOfBoat=2};
            Boat b3 = new Boat() { NumberOfBoat = 3 };

            Car c1 = new Car() { Model = "bmv" };
            Car c2 = new Car() { Model = "wv" };

            transport.AddRange(new Venicle[] { b1, b2, c1, c2, b3 });

            for (int i=0; i<transport.Total; i++)
            {
                if (transport[i] is Boat)
                    Console.WriteLine($"Boat: is  {(transport[i] as Boat ).NumberOfBoat  }");

                else
                    Console.WriteLine($"Car: is  {(transport[i] as Car).Model  }");

            }

            // Найдем  по индексу  какой у нас жлемент коллекцииЖ лода или машинка

            Console.WriteLine("Введите индекс элемнта, чтобы получить  его  значение");
           

            int  index = int.Parse(Console.ReadLine());

            if (index>0&&index<transport.Total)
            {
                if (transport[index - 1] is Boat)
                    Console.WriteLine($"Boat has a number  as   {(transport[index - 1] as Boat).NumberOfBoat  }");

                else
                    Console.WriteLine($"Car has a model  as   {(transport[index - 1] as Car).Model  }");
            }
            else
                Console.WriteLine("Вы ввели неверный индекс, такого элемента не существует");
          

                        
            // Определим размер нашей коллекции

            Console.WriteLine($"Our collection has size  {transport.Total} elements ");


            Console.WriteLine();

            // Дополнительно:   добавим в нашу коллекцию еще одну машинку и ее модель введем с клавиатуры
            Console.WriteLine("значение  нового элемента коллекции машинки");
            
              string newmodel = Console.ReadLine();

           
                Car c3 = new Car() { Model = newmodel };
                transport.Add(c3);


                for (int i = 0; i < transport.Total; i++)
                {
                    if (transport[i] is Boat)
                        Console.WriteLine($"Boat: is  {(transport[i] as Boat).NumberOfBoat  }");

                    else
                        Console.WriteLine($"Car: is  {(transport[i] as Car).Model  }");

                }


          



            Console.WriteLine();


           

            Console.WriteLine("Hello World!");
        }

     

    }
}

