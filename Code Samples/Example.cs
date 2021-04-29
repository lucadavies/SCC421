using System;
using System.Collections.Generic;

// TERNARY
    string DisplayTempA(double temp)
    {
        return temp < 20.0 ? "Cold." : "Perfect!";
    }
    //-
    string DisplayTempB(double temp)
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
    Action<string> greetA = name =>
    {
        string greeting = "Hello " + name + "!";
        Console.WriteLine(greeting);
    };
    //-
    void greetB(string name)
    {
        string greeting = $"Hello {name}!";
        Console.WriteLine(greeting);
    }

// NULL-COALESCE
    int? a = null;
    //setup
    int b = a ?? -1;
    //-
    int c = 0;
    if (a != null)
    {
        c = a.Value;
    }
    else
    {
        c = -1;
    }

// NULL-CONDITIONAL
    Person p = new Person();
    //setup
    var name = p?.firstName;
    //-
    if (p.firstName != null)
    {
        name = p.firstName;
    }
    else
    {
        name = (default(string));
    }

// UNARY INC/DECR.
    int x;
    int y;
    int z;
    //setup
    x = 3;
    y = x++;
    z = ++x;
    //-
    x = 3;
    y = x;
    x = x + 1;
    z = x + 1;
    x = x + 1;

// COMPOUND ASSIGNMENT
    int d = 2;
    //setup
    d += 3;
    //-
    d = d + 3;
// FOREACH
    List<int> nums = new List<int> {10, 99, 4, 65, 38, 42};
    int total = 0;
    //setup
    foreach (int i in nums)
    {
        total += i;
    }
    //-
    for (int i = 0; i < nums.Count; i++)
    {
        total += nums[i];
    }

//-----------
class Person
{
    public string firstName { get; set; }
}