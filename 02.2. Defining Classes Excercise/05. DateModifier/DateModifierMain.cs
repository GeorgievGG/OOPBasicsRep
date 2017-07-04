using System;

public class DateModifierMain
{
    public static void Main()
    {
        var input1 = Console.ReadLine();
        var input2 = Console.ReadLine();
        var dm = new DateModifier(input1, input2);
        Console.WriteLine(dm.dateDiff);
    }
}