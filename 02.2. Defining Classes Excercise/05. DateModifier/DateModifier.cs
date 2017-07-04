using System;

public class DateModifier
{
    public DateModifier(string firstDate, string secDate)
    {
        var firstDateDtm = new DateTime(int.Parse(firstDate.Substring(0, 4)), int.Parse(firstDate.Substring(5, 2)), int.Parse(firstDate.Substring(8, 2)));
        var secDateDtm = new DateTime(int.Parse(secDate.Substring(0, 4)), int.Parse(secDate.Substring(5, 2)), int.Parse(secDate.Substring(8, 2)));
        this.dateDiff = Math.Abs(CalculateDifferenceInDays(firstDateDtm, secDateDtm));
    }
    private static int CalculateDifferenceInDays(DateTime firstDate, DateTime secDate)
    {
        return firstDate.Subtract(secDate).Days;
    }
    public int dateDiff;
}