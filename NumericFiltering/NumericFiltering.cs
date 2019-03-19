using System;

public class TextInput
{
    public string value;
    public virtual void Add(char c)
    {
        value += c;
    }
    public string GetValue()
    {
        return value.ToString();
    }
}

//if input is of type str or char, ignore
public class NumericInput : TextInput
{
    override public void Add(char c)
    {
        String s = new string(c, 1);
        int i = 0;
        bool result = int.TryParse(s, out i);
        if (result)
        {
            value += c;
        }
    }
}

public class UserInput
{
    public static void Main(string[] args)
    {
        TextInput input = new NumericInput();
        input.Add('1');
        input.Add('a');
        input.Add('0');
        input.Add('f');
        Console.WriteLine(input.GetValue());
        Console.ReadKey();
    }
}