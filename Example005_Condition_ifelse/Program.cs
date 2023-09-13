Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.InputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.WriteLine("Привет, ");
    Console.WriteLine(username);
}