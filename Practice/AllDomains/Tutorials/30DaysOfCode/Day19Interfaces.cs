using System;
public interface AdvancedArithmetic
{
    int divisorSum(int n);
}

//Write your code here
class Calculator : AdvancedArithmetic 
{
	/*	author:@shivkrthakur  */
    public int divisorSum(int n)
    {
        int sum = 0;
        for(int i = 1; i < n+1; i++)
        {
            if((n % i) == 0) sum += i;   
        }
        
        return sum;
    }
}

class Solution
{
    static void Main(string[] args)
	{
        int n = Int32.Parse(Console.ReadLine());
      	AdvancedArithmetic myCalculator = new Calculator();
        int sum = myCalculator.divisorSum(n);
        Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum); 
    }
}