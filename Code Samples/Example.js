class Example
{
    // TERNARY
    static ternaryAdv(temp)
    {
        return temp < 20.0 ? "Cold." : "Perfect!";
    }

    static ternaryPlain(temp)
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

    // LAMBDA/ARROW FUNCTIONS
    static lambdaAdv(name)
    {
        let foo = s =>
        {
            let greeting = "Hello " + s + "!";
            console.log(greeting);
        }
        
        foo(name);
    }
    
    static lambdaPlain(name)
    {
        let greeting = "Hello " + name + "!";
        console.log(greeting);
    }

    // NULL-COALESCE
    static nullCoalesceAdv()
    {
        let a = null;
        let b = null;
        b = a ?? -1;

        console.log(b);
    }

    static nullCoalescePlain()
    {
        let a = null;
        let b = null;
        if (a != null)
        {
            b = a;
        }
        else
        {
            b = -1;
        }

        console.log(b);
    }

    // NULL-CONDITIONAL
    static nullConditionalAdv()
    {
        let p = new Person();
        //setup
        let name = "p is null, no name";
        
        name = p?.firstName;

        console.log(name);
    }

    static nullConditionalPlain()
    {
        let p = new Person();
        //setup
        let name = "p is null, no name";

        if (p != null)
        {
            name = p.firstName;
        }

        console.log(name);
    }

    // UNARY INC/DECR.
    static incrDecrAdv()
    {
        let x = 0;
        let y = 0;
        let z = 0;
        //setup
        x = 3;
        y = x++;
        z = ++x;

        console.log(x);
        console.log(y);
        console.log(z);
    }

    static incrDecrPlain()
    {
        let x = 0;
        let y = 0;
        let z = 0;
        //setup
        x = 3;

        y = x;
        x = x + 1;

        z = x + 1;
        x = x + 1;

        console.log(x);
        console.log(y);
        console.log(z);
    }

    // COMPOUND ASSIGNMENT
    static compoundAssignAdv()
    {
        let x = 2;
        //setup
        x += 3;
        console.log(x);
    }

    static compoundAssignPlain()
    {
        let x = 2;
        //setup
        x = x + 3;
        console.log(x);
    }

    // FOREACH
    static foreachAdv()
    {
        let nums = [10, 99, 4, 65, 38, 42];
        let total = 0;
        //setup
        for (let i of nums)
        {
            total += i;
        }

        console.log(total);
    }

    static foreachPlain()
    {
        let nums = [10, 99, 4, 65, 38, 42];
        let total = 0;
        //setup
        for (let i = 0; i < nums.length; i++)
        {
            total += nums[i];
        }

        console.log(total);
    }
}

class Person
{
    constructor(fn)
    {
        this.firstName = fn;
    }
}

Example.ternaryAdv(10);
Example.ternaryPlain(10);
Example.lambdaAdv("Alice");
Example.lambdaPlain("Bob");
Example.nullCoalesceAdv();
Example.nullCoalescePlain();
Example.nullConditionalAdv();
Example.nullConditionalPlain();
Example.incrDecrAdv();
Example.incrDecrPlain();
Example.compoundAssignAdv();
Example.compoundAssignPlain();
Example.foreachAdv();
Example.foreachPlain();