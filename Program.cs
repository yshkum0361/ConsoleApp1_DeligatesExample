using System;


class Program
{


    public static void Main()
    {

        ////////---------------Example of Single delegate---------------////////////
        Operations DoMath = add;

        int A=DoMath(4, 8);

        Console.WriteLine($"The Sum is ={A}");

        DoMath = Subtract;

        A=DoMath(10, 5);

        Console.WriteLine($"The Subtraction is = {A}");


        ////////---------------Example of Multicast delegate---------------////////////

        DoMath += Mul;
        DoMath += Div;

        int result = DoMath(10, 5);

        Console.WriteLine($"Multicast examle:- {result}");


        Multicast cast =  Multiply;
        cast += Divide;



        cast();
    }


    public static int add(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }

    public static int Mul(int x , int y)
    {
        return x * y;
    }

    public static int Div(int x, int y)
    {
        return x / y;
    }
    public static void Multiply()
    {

        Console.WriteLine($"Multiply Numbers ");
    }

    public static void Divide()
    {
        Console.WriteLine($"Divide Numbers");
    }

    public delegate int Operations(int x, int y);

    public delegate void Multicast();
}