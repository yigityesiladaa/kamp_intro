using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdevUc
{
    class MyDictionary<MyKey, MyValue>
    {
        (MyKey, MyValue)[] list;

        public MyDictionary()
        {
            list = new (MyKey, MyValue)[0];
        }

        public void add(MyKey customerId, MyValue customerName)
        {

            (MyKey, MyValue)[] tempList = list;
            list = new (MyKey, MyValue)[list.Length + 1];

            for (int i = 0; i < tempList.Length; i++)
            {
                list[i] = tempList[i];
            }
            list[list.Length - 1] = (customerId, customerName);
        }

        public int Count
        {
            get { return list.Length; }
        }

    }
}