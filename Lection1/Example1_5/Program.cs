// Написать программу с особенным приветствием
 Console.WriteLine("Введите ваше имя ");
 string username  = Console.ReadLine();
 if (username.ToLower() == "маша")
 {
    Console.WriteLine("Это же Маша!!!");
 }
 else
 {
    Console.Write("Привет, ");
    Console.Write(username);
 }