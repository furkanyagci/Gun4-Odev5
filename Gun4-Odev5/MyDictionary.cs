using System;
using System.Collections.Generic;
using System.Text;

namespace Gun4_Odev5
{
    public class MyDictionary<TKey, TValue>
    {
        TKey[] _key;
        TValue[] _value;
        public MyDictionary()
        {
            _key = new TKey[0];//Class ilk çağrıldığında dizinin eleman sayısını 0 yaptım yapıcı metotla
            _value = new TValue[0];
        }

        public void Add(TKey key, TValue value)
        {
            TKey[] keyTempArray = _key;//önceki değerleri kaybetmemek için Geçiçi diziye aktardım
            TValue[] valueTempArray = _value;
            _key = new TKey[_key.Length + 1];//Dizinin eleman sayısına +1 ekledim.
            _value = new TValue[_value.Length + 1];
            for (int i = 0; i < keyTempArray.Length; i++)//Dizinin eleman sayısını artırmak için newledik newlenince eski değerleri kaybolacağı için geçici diziye atmıştık bu for ile diziye tekrar ekliyoruz elemanları. Burada _key.Lengthyapma sebebim key olmada value olmaz Dictionaryde o yüzden key uzunluğu kadar for'un dönmesi iki dizi içinde aynı sayıda dönmesi demektir.
            {
                _key[i] = keyTempArray[i];
                _value[i] = valueTempArray[i];
            }

            _key[_key.Length - 1] = key;//Dizi uzunluğunun 1 eksiği olma sebebi index numarasını yakalamak index 0 dan başlar.
            _value[_value.Length - 1] = value;
        }

        public int Length
        {
            get { return _key.Length; }
        }

        public void Items()
        {
            for (int i = 0; i < _key.Length; i++)
            {
                Console.WriteLine(_key[i] + " " + _value[i]);
            }
        }


    }
}
