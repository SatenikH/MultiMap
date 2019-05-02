using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Generic.Dictionary<TKey, TValue>;

internal class TKey
{
}
internal class TValue
{
}
namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, List<string>> dictionary = new MyDictionary<int, List<string>>();

            List<string> student1 = new List<string>();
            student1.Add("Anna");
            student1.Add("27");
            student1.Add("099556625");
            dictionary.Add(1, student1);

            List<string> student2 = new List<string>();
            student2.Add("Aram");
            student2.Add("20");
            dictionary.Add(2, student2);

            List<string> student3 = new List<string>();
            student3.Add("Karen");
            student3.Add("18");
            student3.Add("095662266");
            student3.Add("Yerevan");
            dictionary.Add(3, student3);

            List<string> student4 = new List<string>();
            student4.Add("Ani");
            student4.Add("23");
            student4.Add("Gavar");
            dictionary.Add(4, student4);

            foreach (var item in dictionary)
            {
                foreach (var str in item.Value)
                {
                    Console.WriteLine("{0}, {1}", item.Key, str);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }

    public class MyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private IDictionary<TKey, TValue> dict = new Dictionary<TKey, TValue>();

        public TValue this[TKey key]
        {
            get
            {
                TValue val;
                if (!TryGetValue(key, out val))
                    return default(TValue);
                return val;
            }

            set { dict[key] = value; }
        }

        public ICollection<TKey> Keys => dict.Keys;

        public ICollection<TValue> Values => dict.Values;

        public int Count => dict.Count;

        public bool IsReadOnly => dict.IsReadOnly;

        public void Add(TKey key, TValue value)
        {
            dict.Add(key, value);
        }

        public void Add(KeyValuePair<TKey, TValue> item)
        {
            dict.Add(item);
        }

        public void Clear()
        {
            dict.Clear();
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return dict.Contains(item);
        }

        public bool ContainsKey(TKey key)
        {
            return dict.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            dict.CopyTo(array, arrayIndex);
        }

        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return dict.GetEnumerator();
        }

        public bool Remove(TKey key)
        {
            return dict.Remove(key);
        }

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return dict.Remove(item);
        }

        public bool TryGetValue(TKey key, out TValue value)
        {
            return dict.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return dict.GetEnumerator();
        }
    }
}

