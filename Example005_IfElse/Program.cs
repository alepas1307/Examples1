Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower()=="Саша")
{
    Console.WriteLine("Ура, это же САША!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}