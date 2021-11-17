using System.Collections;
using System.Collections.Generic;


namespace ConsoleApp1

{
    public class Transport<T> : ITranspor<T>
    {
              
        public int NumberOfBoat { get; set; }    public string Model { get; set; }

       
        public int Total => list.Count;


        public T this[int index]

        {
            get { return list[index]; }

            set { list[index] = value; }
        }

        List<T> list;

        public Transport()
        {
            list = new List<T>();

        }

       

        public void Add(T item)
        {
            list.Add(item);
        }

        public void AddRange(T [] items)
        {
            list.AddRange( items);
        }


    }


}




