import java.util.ArrayList;
import java.util.Arrays;
import java.util.function.Consumer;

public class Adv
{
// TERNARY
    static String ternaryAdv(double temp)
    {
        return temp < 20.0 ? "Cold." : "Perfect!";
    }

// LAMBDA EXPRESSIONS
    static void lambdaAdv(String name)
    {
        Consumer<String> foo = (s) ->
        {
            String greeting = "Hello " + s + "!";
            System.out.println(greeting);
        };

        foo.accept(name);
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

        System.out.println(x);
        System.out.println(y);
        System.out.println(z);
    }

// COMPOUND ASSIGNMENT
    static void compoundAssignAdv()
    {
        int x = 2;
        //setup
        x += 3;
        System.out.println(x);
    }

// FOREACH
    static void foreachAdv()
    {
        ArrayList<Integer> nums = new ArrayList<Integer>(Arrays.asList(10, 99, 4, 65, 38, 42));
        int total = 0;
        //setup
        for (int i : nums)
        {
            total += i;
        }

        System.out.println(total);
    }

    public static void main(String[] args)
    {
        ternaryAdv(10);
        lambdaAdv("Alice");
        incrDecrAdv();
        compoundAssignAdv();
        foreachAdv();
    }
}