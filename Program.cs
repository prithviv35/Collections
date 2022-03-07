using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating a dictionary
            // using Dictionary<TKey,TValue> class
            Dictionary<int, string> My_dict1 =new Dictionary<int, string>();

            // Adding key/value pairs 
            // in the Dictionary
            // Using Add() method
            My_dict1.Add(1123, "Welcome");
            My_dict1.Add(1124, "to");
            My_dict1.Add(1125, "GeeksforGeeks");

            foreach (KeyValuePair<int, string> ele1 in My_dict1)
            {
                Console.WriteLine("{0} and {1}",ele1.Key, ele1.Value);
            }

            My_dict1.Remove(1123);

            foreach (KeyValuePair<int, string> ele in My_dict1)
            {
                Console.WriteLine("{0} and {1}",ele.Key, ele.Value);
            }


            //******************************//

            // Creating a Stack
            Stack myStack = new Stack();

            // Inserting the elements into the Stack
            myStack.Push("1st Element");
            myStack.Push("2nd Element");
            myStack.Push("3rd Element");
            myStack.Push("4th Element");
            myStack.Push("5th Element");
            myStack.Push("6th Element");

            // Displaying the count of elements
            // contained in the Stack
            Console.Write("Total number of elements in the Stack are : ");
            Console.WriteLine(myStack.Count);

            // Displaying the top element of Stack
            // without removing it from the Stack
            Console.WriteLine("Element at the top is : " + myStack.Peek());

            myStack.Pop();

            Console.Write("Total number of elements in the Stack are : ");
            Console.WriteLine(myStack.Count);
            
            Console.WriteLine("Element at the top is : " + myStack.Peek());

            myStack.Clear();
            Console.Write("Total number of elements in the Stack are : ");
            Console.WriteLine(myStack.Count);

            //Console.WriteLine("Element at the top is : " + myStack.Peek());// Internal Error

            //********************************************//
            Queue myQueue = new Queue();

            myQueue.Enqueue("Chandigarh");
            myQueue.Enqueue("Delhi");
            myQueue.Enqueue("Noida");
            myQueue.Enqueue("Himachal");
            myQueue.Enqueue("Punjab");
            myQueue.Enqueue("Jammu");

            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);
            Console.WriteLine(myQueue.Contains("Himachal"));
            myQueue.Dequeue();
            Console.Write("Total number of elements in the Queue are : ");

            Console.WriteLine(myQueue.Count);
            Console.WriteLine("Peek Value " + myQueue.Peek());

            Hashtable myHashtable = new Hashtable();
            Hashtable my_hashtable = new Hashtable() { { 10, 2 }, { 1, "hello" }, { 2, 234 }, { 3, 230.45 },
                                            { 4, null } };

            Console.WriteLine("Key and Value pairs from my_hashtable2:");

            foreach (var ele in my_hashtable.Keys)
            {
                Console.WriteLine("{0}and {1}", ele,
                                my_hashtable[ele]);
            }

            Console.ReadLine();
        }
    }
}
