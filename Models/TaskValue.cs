namespace CSharpTaskManager.Models;

public class TaskValue
{
    public string? TextValue { get; set; }
    public int? IntegerValue { get; set; }
    public bool? BooleanValue { get; set; }

    public TaskValue(string value)
    {
        TextValue = value;
    }

    public TaskValue(int value)
    {
        IntegerValue = value;
    }

    public TaskValue(bool value)
    {
        BooleanValue = value;
    }

    public override string ToString()
    {
        if (TextValue != null)
        {
            return TextValue;
        }

        if (IntegerValue.HasValue)
        {
            return IntegerValue.Value.ToString();
        }

        if (BooleanValue.HasValue)
        {
            return BooleanValue.Value.ToString();
        }

        return "No value";
    }
}