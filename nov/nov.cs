using System;

public class IslandAdventure
{
    public static void Main(string[] args)
    {
        Console.WriteLine("ТАИНСТВЕННЫЙ ОСТРОВ");
        Console.WriteLine("-------------------");
        Console.WriteLine("Вы очнулись на незнакомом берегу. Вокруг только песок и пальмы.\n");

        // Первый выбор
        Console.WriteLine("Ваши действия:");
        Console.WriteLine("1) Осмотреть пляж");
        Console.WriteLine("2) Пойти вглубь джунглей");
        Console.WriteLine("3) Попробовать развести костер");

        char choice = GetUserChoice('1', '2', '3');

        switch (choice)
        {
            case '1':
                ExploreBeach();
                break;
            case '2':
                EnterJungle();
                break;
            case '3':
                MakeFire();
                break;
        }

        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }

    private static char GetUserChoice(params char[] validChoices)
    {
        while (true)
        {
            var key = Console.ReadKey().KeyChar;
            Console.WriteLine();
            
            if (Array.Exists(validChoices, c => c == key))
                return key;
                
            Console.WriteLine("Неверный выбор. Попробуйте еще раз:");
        }
    }

    private static void ExploreBeach()
    {
        Console.WriteLine("\nВы идете вдоль берега и находите бутылку с запиской.");
        Console.WriteLine("Прочитать? (да/нет)");
        
        if (Console.ReadLine().ToLower() == "да")
        {
            Console.WriteLine("Записка гласит: 'Осторожно с пещерами на севере'.");
            Console.WriteLine("1) Искать пещеры");
            Console.WriteLine("2) Игнорировать предупреждение");
            
            char choice = GetUserChoice('1', '2');
            
            if (choice == '1')
                Console.WriteLine("Вы нашли скрытый клад в пещере!");
            else
                Console.WriteLine("Вы решили остаться на пляже. Вскоре вас спасли.");
        }
        else
        {
            Console.WriteLine("Вы бросили бутылку обратно в океан.");
        }
    }

    private static void EnterJungle()
    {
        Console.WriteLine("\nДжунгли густые и влажные. Вы слышите странные звуки.");
        Console.WriteLine("1) Идти на звук");
        Console.WriteLine("2) Вернуться на пляж");
        
        char choice = GetUserChoice('1', '2');
        
        if (choice == '1')
        {
            Console.WriteLine("Вы встретили племя туземцев. Они оказались дружелюбными!");
            Console.WriteLine("1) Остаться с ними");
            Console.WriteLine("2) Попросить показать дорогу");
            
            choice = GetUserChoice('1', '2');
            
            if (choice == '1')
                Console.WriteLine("Вы стали частью племени.");
            else
                Console.WriteLine("Туземцы показали вам безопасный путь домой.");
        }
        else
        {
            Console.WriteLine("Вы вернулись на пляж как раз к прибытию спасателей.");
        }
    }

    private static void MakeFire()
    {
        Console.WriteLine("\nВы собрали ветки и пытаетесь развести огонь.");
        Console.WriteLine("1) Использовать очки для фокусировки солнечного света");
        Console.WriteLine("2) Попробовать метод трения");
        
        char choice = GetUserChoice('1', '2');
        
        if (choice == '1')
        {
            Console.WriteLine("Огонь разгорелся! Дым привлек внимание пролетающего самолета.");
            Console.WriteLine("Вас спасли через несколько часов.");
        }
        else
        {
            Console.WriteLine("После долгих попыток у вас ничего не вышло. Ночью вас нашло племя.");
        }
    }
}