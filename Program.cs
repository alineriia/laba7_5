using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * У набір ArrayList помістити випадкові значення типу Int в діапазоні і кількості
відповідно до варіанта (див. Табл. 1) за допомогою методу add.

 Відсортувати набір в порядку зростання.
 Вивести всі елементи набору за допомогою циклу foreach.

 Значення номера варіанту занести в набір на позицію, що дорівнює номеру 
варіанта.

 Згенерувати нове значення в межах від 0 до номера варіанту +1000 і
перевірити чи існує таке значення в наборі, якщо існує визначити його індекс.
 Видалити елемент набору рівний випадковому значенню, згенерованого в
межах від 0 до максимального індексу набору.
 Видалити всі елементи набору.
*/
namespace lab7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            int number = 1830, variant = 12,newnumber;
            Random rnd = new Random();
            for (int i = 0; i < number; i++)
            {
                array.Add((int)(rnd.Next(400, 600)));
            }
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
            array.Sort();
            Console.WriteLine("--------- AFTER SORTING ---------");
            foreach(int i in array)
            {
                Console.WriteLine(i);
            }
            array[variant] = variant;
            newnumber = (int)(rnd.Next(0, variant+1000));
            bool cntn = array.Contains(newnumber);
            if(cntn == true)
            {
                Console.WriteLine("Array contains "+newnumber);
                Console.WriteLine("This number has index " + array.IndexOf(newnumber));
            }
            else
            {
                Console.WriteLine("Array doesn't contain" + newnumber);
            }
            int element = (int)(rnd.Next(0, number));
            array.Remove(element);
            array.Clear();
            Console.ReadKey();
        }
    }
}
