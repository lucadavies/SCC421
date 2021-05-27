using System;
using System.Collections.Generic;

class Adv
{
    // TERNARY
    static string ternaryAdv(double temp)
    {
        return temp < 20.0 ? "Cold." : "Perfect!";
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

    // NULL-COALESCE
    static void nullCoalesceAdv()
    {
        Person a = null;
        //setup
        Person b;
        b = a ?? new Person();

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

    // COMPOUND ASSIGNMENT
    static void compoundAssignAdv()
    {
        int x = 2;
        //setup
        x += 3;
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

    static void Main(string[] args)
    {
        ternaryAdv(10);
        lambdaAdv("Alice");
        nullCoalesceAdv();
        nullConditionalAdv();
        incrDecrAdv();
        compoundAssignAdv();
        foreachAdv();
    }
}
    
class Person
{
    public string firstName { get; set; }
}