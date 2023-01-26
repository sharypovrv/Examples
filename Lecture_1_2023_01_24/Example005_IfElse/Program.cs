Console.Write("Введите имя: ");
string username = Console.ReadLine();

if (username.ToLower() == "рома")
{
    Console.WriteLine("Ура! Привет, Ромашка!");
}
else
{
    Console.WriteLine("Привет, " + username + ".");
}