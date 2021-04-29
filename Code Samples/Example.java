import java.util.ArrayList;
import java.util.Arrays;
import java.util.function.Consumer;

public class Example
{
// TERNARY
    String DisplayTempA(double temp)
    {
        return temp < 20.0 ? "Cold." : "Perfect!";
    }
    //-
    String DisplayTempB(double temp)
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
    Consumer<String> greetA = (name) ->
    {
        String greeting = "Hello " + name + "!";
        System.out.println(greeting);
    };
    //-
    void greetB(String name)
    {
        String greeting = "Hello " + name + "!";
        System.out.println(greeting);
    }

// UNARY INC/DECR.
    void incrDecr()
    {
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
    }

// COMPOUND ASSIGNMENT
    void compoundAssign()
    {
        int d = 2;
        //setup
        d += 3;
        //-
        d = d + 3;
    }

// FOREACH
    void foreach()
    {
        ArrayList<Integer> nums = new ArrayList<Integer>(Arrays.asList(10, 99, 4, 65, 38, 42));
        int total = 0;
        //setup
        for (int i : nums)
        {
            total += i;
        }
        //-
        for (int i = 0; i < nums.size(); i++)
        {
            total += nums.get(i);
        }
    }
    
}