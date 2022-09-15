Console.Write("Input user name ");
string username = Console.ReadLine();

if(username.ToLower() == "papa")
{
    Console.Write("Welome ");
    Console.WriteLine(username.ToUpper());
}
else
{
    Console.Write("Hi ");
    Console.WriteLine(username);
}