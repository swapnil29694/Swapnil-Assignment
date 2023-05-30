using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment
{
    internal class Delegate
    {
    }
}
public delegate decimal CalculateInterest(decimal principal, decimal rate, int time);

public class InterestCalculator
{
    public decimal CalculateSimpleInterest(decimal principal, decimal rate, int time)
    {
        decimal interest = principal * rate * time;
        return interest;
    }

    public decimal CalculateCompoundInterest(decimal principal, decimal rate, int time)
    {
        decimal amount = principal * (decimal)Math.Pow((double)(1 + rate), time);
        decimal interest = amount - principal;
        return interest;
    }

    public decimal CalculateRealInterest(decimal principal, decimal rate, int time)
    {
        decimal simpleInterest = CalculateSimpleInterest(principal, rate, time);
        decimal compoundInterest = CalculateCompoundInterest(principal, rate, time);
        decimal realInterest = compoundInterest - simpleInterest;
        return realInterest;
    }
}

public class Display
{
    public static void Main()
    {
        InterestCalculator calculator = new InterestCalculator();

        // Create delegates and assign methods
        CalculateInterest simpleInterestDelegate = calculator.CalculateSimpleInterest;
        CalculateInterest compoundInterestDelegate = calculator.CalculateCompoundInterest;
        CalculateInterest realInterestDelegate = calculator.CalculateRealInterest;

        // Calculate and display the results
        decimal principal = 1000;
        decimal rate = 0.05m;
        int time = 3;

        decimal simpleInterest = simpleInterestDelegate(principal, rate, time);
        Console.WriteLine("Simple Interest: " + simpleInterest);

        decimal compoundInterest = compoundInterestDelegate(principal, rate, time);
        Console.WriteLine("Compound Interest: " + compoundInterest);

        decimal realInterest = realInterestDelegate(principal, rate, time);
        Console.WriteLine("Real Interest: " + realInterest);
    }
}