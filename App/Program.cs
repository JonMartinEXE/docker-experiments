Console.WriteLine("How many roads must a man walk down?");
var x = Console.ReadLine() ?? "";
if (x.ToLower().Trim() == "42")
    Console.WriteLine("Correct! It is 42.");
else
    Console.WriteLine("Incorrect! It is 42.");

// boring

//var counter = 0;
//var max = args.Length is not 0 ? Convert.ToInt32(args[0]) : -1;

//while (max is -1 || counter < max)
//{
//    Console.WriteLine($"Counter: {++counter}");

//    await Task.Delay(TimeSpan.FromMilliseconds(1_000));
//}