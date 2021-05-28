using System;
using System.Collections.Generic;

class Plain
{
    // TERNARY
    static string ternaryPlain(double temp)
    {
        if (temp < 20.0)
        {
            return "Cold.";
        }
        else
        {
            return "Perfect!";
        }
    }

    // LAMBDA EXPRESSIONS
    static void lambdaPlain(string name)
    {
        string greeting = "Hello " + name + "!";
        Console.WriteLine(greeting);
    }

    // NULL-COALESCE
    static void nullCoalescePlain()
    {
        Person a = null;
        //setup
        Person b;
        if (a != null)
        {
            b = a;
        }
        else
        {
            b = new Person();
        }

        Console.WriteLine(b);
    }
    

    // NULL-CONDITIONAL
    static void nullConditionalPlain()
    {
        Person p = new Person();
        //setup
        string name;

        if (p != null)
        {
            name = p.firstName;
        }
        else
        {
            name = null;
        }

        Console.WriteLine(name);
    }
    

    // UNARY INC/DECR.
    static void incrDecrPlain()
    {
        int x = 0;
        int y = 0;
        int z = 0;
        //setup
        x = 3;

        y = x;
        x = x + 1;

        z = x + 1;
        x = x + 1;

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }

    // COMPOUND ASSIGNMENT
    static void compoundAssignPlain()
    {
        int x = 2;
        //setup
        x = x + 3;
        Console.WriteLine(x);
    }

    // FOREACH
    static void foreachPlain()
    {
        List<int> nums = new List<int> {10, 99, 4, 65, 38, 42};
        int total = 0;
        //setup
        for (int i = 0; i < nums.Count; i++)
        {
            total += nums[i];
        }

        Console.WriteLine(total);
    }

    static void Main(string[] args)
    {
        ternaryPlain(10);
        lambdaPlain("Alice");
        nullCoalescePlain();
        nullConditionalPlain();
        incrDecrPlain();
        compoundAssignPlain();
        foreachPlain();
    }
}
    
class Person
{
    public string firstName { get; set; }
}