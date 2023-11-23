bool proceed = true;

while (proceed)
{
    string result = "";
    Console.WriteLine("Zadejte slovo:");
    string userInput = Console.ReadLine();

    if (string.IsNullOrEmpty(userInput))
    {
        proceed = false;
    }
    result += userInput;
    //Console.WriteLine($"Debug: {result}");
}
Console.WriteLine("Zde je cílový výpis!");