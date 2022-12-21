Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша") //ToLower переводит введенное значение пользователем Маша в нижний регистр
{
	Console.WriteLine("Ура, это Маша!");
}
else
{
	Console.Write($"Привет, {username}");
}
