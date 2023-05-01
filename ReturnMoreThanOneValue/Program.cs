
int[] numbers = { 3, 7, 1, 9, 4, 6 };


// Example 1: Custom class
var minMax = GetMinMaxUsingCustomClass(numbers);
Console.WriteLine($"Min - {minMax.Min}");
Console.WriteLine($"Max - {minMax.Max}");



// Example 2: Out Parameters
GetMinMaxOutParameters(numbers, out int minParameters, out int maxParameters);
Console.WriteLine($"Min: {minParameters}, Max: {maxParameters}");



// Example 3: Assigning the tuple to variables
var (min, max) = GetMinMaxTuple(numbers);
Console.WriteLine($"Min: {min}, Max: {max}");

//Using a custom class
static MinMax GetMinMaxUsingCustomClass(IReadOnlyList<int> numbers)
{
    var result = new MinMax
    {
        Min = numbers[0],
        Max = numbers[0]
    };

    for (var i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] < result.Min)
            result.Min = numbers[i];

        if (numbers[i] > result.Max)
            result.Max = numbers[i];
    }

    return result;
}


static void GetMinMaxOutParameters(IReadOnlyList<int> numbers, out int min, out int max)
{
    min = numbers[0];
    max = numbers[0];

    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] < min)
            min = numbers[i];

        if (numbers[i] > max)
            max = numbers[i];
    }
}


static (int, int) GetMinMaxTuple(IReadOnlyList<int> numbers)
{
    int min = numbers[0];
    int max = numbers[0];

    for (int i = 1; i < numbers.Count; i++)
    {
        if (numbers[i] < min)
            min = numbers[i];

        if (numbers[i] > max)
            max = numbers[i];
    }

    return (min, max);
}



