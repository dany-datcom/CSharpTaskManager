namespace CSharpTaskManager.Models;

public class TaskValue
{
    public string? TextValue { get; set; }
    public int? IntegerValue { get; set; }
    public bool? BooleanValue { get; set; }

    /// <summary>
    /// Creates a task value that stores text data.
    /// </summary>
    /// <param name="value">The text value to store.</param>
    public TaskValue(string value)
    {
        TextValue = value;
    }

    /// <summary>
    /// Creates a task value that stores integer data.
    /// </summary>
    /// <param name="value">The integer value to store.</param>
    public TaskValue(int value)
    {
        IntegerValue = value;
    }

    /// <summary>
    /// Creates a task value that stores Boolean data.
    /// </summary>
    /// <param name="value">The Boolean value to store.</param>
    public TaskValue(bool value)
    {
        BooleanValue = value;
    }

    /// <summary>
    /// Returns the stored value as text.
    /// </summary>
    /// <returns>The stored text, integer, or Boolean value.</returns>
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