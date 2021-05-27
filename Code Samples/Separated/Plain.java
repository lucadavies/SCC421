import java.util.ArrayList;
import java.util.Arrays;
import java.util.function.Consumer;

public class Plain
{
// TERNARY
    static String ternaryPlain(double temp)
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
    static void lambdaPlain(String name)
    {
        String greeting = "Hello " + name + "!";
        System.out.println(greeting);
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

        System.out.println(x);
        System.out.println(y);
        System.out.println(z);
    }

// COMPOUND ASSIGNMENT
    static void compoundAssignPlain()
    {
        int x = 2;
        //setup
        x = x + 3;
        System.out.println(x);
    }

// FOREACH
    static void foreachPlain()
    {
        ArrayList<Integer> nums = new ArrayList<Integer>(Arrays.asList(10, 99, 4, 65, 38, 42));
        int total = 0;
        //setup
        for (int i = 0; i < nums.size(); i++)
        {
            total += nums.get(i);
        }

        System.out.println(total);
    }

    public static void main(String[] args)
    {
        ternaryPlain(10);
        lambdaPlain("Alice");
        incrDecrPlain();
        compoundAssignPlain();
        foreachPlain();
    }
}