Console.WriteLine("How many roads must a man walk down?");
var x = Console.ReadLine() ?? "";
if (x.ToLower().Trim() == "42")
    Console.WriteLine("Correct! It is 42.");
else
    Console.WriteLine("Incorrect! It is 42.");

