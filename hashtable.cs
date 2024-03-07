using System;
using System.Collections;
// using System.Collections.Generic;
namespace hash_table{
    public class test1{
        public static void Main(string [] args)
        {
            Hashtable hashTable=new Hashtable();
            hashTable.Add("name","Aakash");
            hashTable.Add("roll",1);
            hashTable.Add("faculty","bca");
            foreach(DictionaryEntry entry in hashTable)
            {
                Console.WriteLine($"key: {entry.Key} and value is {entry.Value}");
            }
        }
    }
}