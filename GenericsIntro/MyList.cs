using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    internal class MyList<T>
    {
        T[] items;
        //constructor
        public MyList()
        {
            items=new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;//items ın referans numarasını burada tutuyoruz veriler kaybolmasın diye çünkü aşağıda "new" yapınca yeni referans numarası atanınca veriler uçabilir
            items=new T[items.Length+1];  //dizinin eleman saysısı sıfırdan başladı sonra bir bir artacak
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item;//items'ın son elemanı yukarıdan gelen değere eşleniyor
        }

    }
}
