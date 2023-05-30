using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class ArrayList
    {
    }
}
class Patient
{
    public static ArrayList arr_Patient = new ArrayList();
    public void Clinic()
    {
    Loop:
        Console.WriteLine("Enter your Patient name");
        string fname = Console.ReadLine();
        arr_Patient.Add(fname);

    show:
        foreach (string str in arr_Patient)
        {
            Console.WriteLine(str);
        }

        Console.WriteLine("Do you Want to Add more Names (Y/N)");
        string addname = Console.ReadLine();
        if (addname == "y")
        {
            goto Loop;
        }
        else
        {
            Console.WriteLine("Enter Your Choice");
            Console.WriteLine("1 : Sort  2: Search 3: Reverse 4:Remove 5:Exit");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:

                    arr_Patient.Sort();
                    goto show;
                    break;

                case 2:
                    Console.WriteLine("Enter Element to Search");
                    string SearchElement = Console.ReadLine();
                    if (arr_Patient.Contains(SearchElement))
                    {
                        Console.WriteLine("Yes, exists at index " + arr_Patient.IndexOf(SearchElement));
                    }
                    goto show;
                    break;
                case 3:
                    arr_Patient.Reverse();
                    goto show;
                    break;
                case 4:
                    Console.WriteLine("Enter Index to remove Element");
                    int num = Convert.ToInt32(Console.ReadLine());
                    foreach (string str in arr_Patient)
                    {
                        str.Remove(num);
                    }

                    goto show;
                    break;

                case 5:
                    //Exit(0);

                    break;
            }
        }

    }
    static public void Main()
    {
        Patient display = new Patient();

        display.Clinic();
    }

}