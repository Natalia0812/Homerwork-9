using System.Collections;


namespace Venicle

{
    class Transport<T> :  IBoat, ICar
    {
       // string mode
            int id;  string model;
        public int NumberOfBoat { get { return id; } }
        public string Model { get { return model;} }

        public Transport(string model, int id)
        {
            this.model = model; this.id = id;
        }


        public void AddTransport(ArrayList items)
        {
            ArrayList array = new ArrayList();
            array.AddRange(new T [] { });
                         
        }

       










        //public T AddTransport(ArrayList items)
        //{

        //    //List<T> list1 = new List<T>();
        //    //list1.AddRange(new T[] { });

        //    //List<V> list2 = new List<V>();
        //    //list1.AddRange(new T[] { });
        //    //ArrayList array = new ArrayList();
        //    //if (items!=null)
        //    //{

        //    //    array.AddRange(new T[] { });

        //    //}
        //    //for (int i = 0; i < array.Count; i++)
        //    //{
        //    //    return (T)array[i];
        //    //}



        //}


    }


}




