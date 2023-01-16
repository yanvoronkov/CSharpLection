// Вид 1 ничего не принимаю и ничего не возвращают
// void Method1()
// {
// 	Console.WriteLine("Автор ...");
// }

// Method1(); //Вызов метода

// Вид 2 ничего не возвращают, но могут принимать аргументы
// void Method2(string msg)
// {
// 	Console.WriteLine(msg);
// }

// Method2("Текст сообщения"); //Вызов метода c аргументом

// void Method21(string msg, int count)
// {
// 	int i = 0;
// 	while (i < count)
// 	{
// 		Console.WriteLine(msg);
// 		i++;
// 	}

// }

// Method21("Сообщение", 4); //запуск метода с помощью двух аргументов
// Method21(msg: "Сообщение", count: 4); //запуск метода с явным указанием конкретных аргументов
// Method21(count: 4, msg: "новый текст"); //если явно указываются аргументы, можно их менять местами и не соблюдать последовательность ввода

// // Вид 3 что-то возвращают, но ничего не принимают

// int Method3()
// {
// 	return DateTime.Now.Year;

// }

// int year = Method3(); //вызов метода с пустыми скобками без аргументов и можно, например, присвоить значение переменной
// Console.WriteLine(year);

// Вид 4 что-то принимают, и что-то возвращают

// string Method4(int count, string text)
// {
// 	int i = 0;
// 	string result = String.Empty;
// 	while (i < count)
// 	{
// 		result = result + text;
// 		i++;
// 	}
// 	return result;
// }

// string Method4(int count, string text)
// {
// 	string result = String.Empty;
// 	for (int i = 0; i < count; i++)
// 	{
// 		result = result + text;
// 	}
// 	return result;
// }

// string res = Method4(10, "asdf");
// Console.WriteLine(res);

// for (int i = 0; i <= 10; i++)
// {
// 	for (int j = 0; j <= 10; j++)
// 	{
// 		Console.WriteLine($"{i} x {j} = {i * j}");
// 	}
// 	Console.WriteLine();
// }

// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие буквы “к” заменить большими “К”, а большие “С” заменить
// маленькими “с”.
// Ясна ли задача?

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
				+ "ежели бы вас послали вместо нашего милого Винценгероде,"
				+ "вы бы взяли приступом согласие прусского короля"
				+ "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "Text" //переменная текст
// s[2]//обращение к третьему символу строки "x"

string Replace(string text, char oldValue, char newValue)
{
	string result = String.Empty;
	int lenght = text.Length;
	for (int i = 0; i < lenght; i++)
	{
		if (text[i] == oldValue) result = result + $"{newValue}";
		else result = result + $"{text[i]}";
	}
	return result;
}
string newText = Replace(text, ' ', '_');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);