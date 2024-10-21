// See https://aka.ms/new-console-template for more information

#region Syntax

UnitConverter feetToInchesConverter = new UnitConverter(12);
Console.WriteLine(feetToInchesConverter.Convert(30));

public class UnitConverter
{
    private int ratio;

    public UnitConverter(int unitRatio)
    {
        ratio = unitRatio;
    }

    public int Convert(int unit)
    {
        return ratio * unit;
    }
}

#endregion