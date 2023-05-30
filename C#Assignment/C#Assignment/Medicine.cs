using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class Medicine
    {
    }
}
class Medicine
{
    string MedicineCode;
    string MedicineName;
    string ManufactureName;
    float UnitPrice;
    int QuantityOnHand;
    string ManufacutredDate;
    string ExpiryDate;
    int BatchNumber;

    public Medicine(string medicineCode, string medicineName, string manufactureName, float unitPrice, int quantityOnHand, string manufacutredDate, string expiryDate, int batchNumber)
    {
        MedicineCode = medicineCode;
        MedicineName = medicineName;
        ManufactureName = manufactureName;
        UnitPrice = unitPrice;
        QuantityOnHand = quantityOnHand;
        ManufacutredDate = manufacutredDate;
        ExpiryDate = expiryDate;
        BatchNumber = batchNumber;
    }

    public void print()
    {
        Console.WriteLine("Medicine Code : {0}", MedicineCode);
        Console.WriteLine("Medicine Name : {0}", MedicineName);
        Console.WriteLine("Manufacture Name: {0}", ManufactureName);
        Console.WriteLine("Unit Price : {0}", UnitPrice);
        Console.WriteLine("Quantity On Hand : {0}", QuantityOnHand);
        Console.WriteLine("Manufacutred Date : {0}", ManufacutredDate);
        Console.WriteLine("Expiry Date : {0}", ExpiryDate);
        Console.WriteLine("Batch Number : {0}", BatchNumber);
        Console.ReadLine();
    }
}


class Sales
{
    string MedicineCode;
    string QuantitySold;
    string PlannedSales;
    float ActualSales;
    string Region;


    public Sales(string medicineCode, string quantitySold, string plannedSales, float actualSales, string region)
    {
        MedicineCode = medicineCode;
        QuantitySold = quantitySold;
        PlannedSales = plannedSales;
        ActualSales = actualSales;
        Region = region;
    }

    public void Display()
    {
        Console.WriteLine("Medicine Code : {0}", MedicineCode);
        Console.WriteLine("Quantity Sold : {0}", QuantitySold);
        Console.WriteLine("Planned Sales: {0}", PlannedSales);
        Console.WriteLine("Actual Sales : {0}", ActualSales);
        Console.WriteLine("Region : {0}", Region);
        Console.ReadLine();
    }
}

class program
{
    public static void Main()
    {
        Medicine m = new Medicine("101", "Paracitamol", "ManKind", 100f, 10, "20/22/2020", "20/22/2020", 2);
        m.print();

        Sales s = new Sales("110", "1", "100", 33.3f, "North");
        s.Display();
    }
}