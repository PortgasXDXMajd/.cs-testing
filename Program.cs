using Helpers;

var input = "aiefkd00kgbsdocwqejifbdfcosa";
var minWindow = ValideSlidingWindow.GetMinValidWindow(input);

Console.WriteLine($"Input: {input}");
if (string.IsNullOrEmpty(minWindow))
{
    Console.WriteLine("No valid window found.");
}
else
{
    Console.WriteLine($"Minimum valid window: {minWindow}");
}


