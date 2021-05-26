using System;
using System.Collections.Generic;

class Example
{
    // TERNARY
    static string ternaryAdv(double temp)
    {
        return temp < 20.0 ? "Cold." : "Perfect!";
    }

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
    static void lambdaAdv(string name)
    {
        Action<string> foo = (s) =>
        {
            string greeting = "Hello " + s + "!";
            Console.WriteLine(greeting);
        };

        foo(name);
    }

    static void lambdaPlain(string name)
    {
        string greeting = "Hello " + name + "!";
        Console.WriteLine(greeting);
    }

    // NULL-COALESCE
    static void nullCoalesceAdv()
    {
        int? a = null;
        //setup
        int? b;
        b = a ?? -1;

        Console.WriteLine(b);
    }

    static void nullCoalescePlain()
    {
        int? a = null;
        //setup
        int? b;
        if (a != null)
        {
            b = a;
        }
        else
        {
            b = -1;
        }

        Console.WriteLine(b);
    }
    

    // NULL-CONDITIONAL
    static void nullConditionalAdv()
    {
        Person p = new Person();
        //setup
        var name = "p is null, no name";
        
        name = p?.firstName;

        Console.WriteLine(name);
    }

    static void nullConditionalPlain()
    {
        Person p = new Person();
        //setup
        var name = "p is null, no name";

        if (p != null)
        {
            name = p.firstName;
        }

        Console.WriteLine(name);
    }
    

    // UNARY INC/DECR.
    static void incrDecrAdv()
    {
        int x = 0;
        int y = 0;
        int z = 0;
        //setup
        x = 3;
        y = x++;
        z = ++x;

        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }

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
    static void compoundAssignAdv()
    {
        int x = 2;
        //setup
        x += 3;
        Console.WriteLine(x);
    }

    static void compoundAssignPlain()
    {
        int x = 2;
        //setup
        x = x + 3;
        Console.WriteLine(x);
    }

    // FOREACH
    static void foreachAdv()
    {
        List<int> nums = new List<int> {10, 99, 4, 65, 38, 42};
        int total = 0;
        //setup
        foreach (int i in nums)
        {
            total += i;
        }

        Console.WriteLine(total);
    }

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
        ternaryAdv(10);
        ternaryPlain(10);
        lambdaAdv("Alice");
        lambdaPlain("Bob");
        nullCoalesceAdv();
        nullCoalescePlain();
        nullConditionalAdv();
        nullConditionalPlain();
        incrDecrAdv();
        incrDecrPlain();
        compoundAssignAdv();
        compoundAssignPlain();
        foreachAdv();
        foreachPlain();
    }
}
    
class Person
{
    public string firstName { get; set; }
}