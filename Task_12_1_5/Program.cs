namespace Task_12_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {        
            List<User> list = new List<User>();

            User user1 = new User();
            user1.Name  = "User 1";
            user1.Login = "User_1";
            user1.IsPremium = true;

            User user2 = new User();
            user2.Name = "User 2";
            user2.Login = "User_2";
            user2.IsPremium = true;

            User user3 = new User();
            user3.Name = "User 3";
            user3.Login = "User_3";
            user3.IsPremium = false;

            list.Add(user1);
            list.Add(user2);
            list.Add(user3);

            foreach (var user in list)
            {
                if (user.IsPremium)
                {
                    Console.WriteLine($"Привет {user.Name}");
                }
                else 
                {
                    ShowAds();
                }
            }
        }

        class User
        {
            public string Login { get; set; }
            public string Name { get; set; }
            public bool IsPremium { get; set; } 
        }

        static void ShowAds()
        {
            Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
            // Остановка на 1 с
            Thread.Sleep(1000);

            Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
            // Остановка на 2 с
            Thread.Sleep(2000);

            Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
            // Остановка на 3 с
            Thread.Sleep(3000);
        }
    }
}
