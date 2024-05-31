

namespace TicTacToe

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Крестки нолики
            Game game = new Game();
            game.Start();

            //Азбука морзе
            Console.WriteLine("Введите текст для перевода в азбуку Морзе:");
            string input = Console.ReadLine();
            string morseCode = Translator.TextToMorse(input);
            Console.WriteLine("Текст в азбуке Морзе:");
            Console.WriteLine(morseCode);

            Console.WriteLine("Введите текст в азбуке Морзе для перевода в обычный текст:");
            input = Console.ReadLine();
            string text = Translator.MorseToText(input);
            Console.WriteLine("Обычный текст:");
            Console.WriteLine(text);

            //Деньги и продукты
            Money money = new Money()
            {
                Whole = 10,
                Fraction = 50,
            };
            money.Print();
            Console.WriteLine();
            Product milk = new Product("Молочные продукты","Молоко");
            milk.Whole = 7;
            milk.Fraction = 50;
            Console.WriteLine($"\nТовар {milk.Type} ,{milk.Name} стоит {milk.Total()} \n" +
                $"c учетом скидки 3.20 стоимость товара составит {milk.Discount(3.20)} ");
            Console.WriteLine();

            //Устройства
            Teapot teapot = new Teapot("Чайник", "Электрический чайник", "Сфффффффф");
            teapot.Show();
            teapot.Desc();
            teapot.Sound();
            Console.WriteLine();
            Nuke nuke = new Nuke("Микроволновка", "Электрический прибор", "Дзынь");
            nuke.Show();
            nuke.Desc();
            nuke.Sound();
            Console.WriteLine();
            Auto auto = new Auto("Автомобиль","Дизель","Ррррр");
            auto.Show();
            auto.Desc();
            auto.Sound();
            Console.WriteLine();
            Steamboat steamboat = new Steamboat("Параход","Водный транспорт","Ту-ту-ту");
            steamboat.Show();
            steamboat.Desc();
            steamboat.Sound();
            Console.WriteLine();

            //Музыкальные инструменты
            Violin violin = new Violin("Скрипка","Смычковый инструмент","Появилась в 16 веке","уииуиуи");
            violin.Show();
            violin.Desc();
            violin.History();
            violin.Sound();
            Console.WriteLine();
            Trombone trombone = new Trombone("Тромбон","Духовой инструмент","Появился в 15 веке","трррртррытт");
            trombone.Show();
            trombone.Desc();
            trombone.History();
            trombone.Sound();
            Console.WriteLine();
            Ukulele ukulele = new Ukulele("Укулеле","Струнный инструмент","Появился в 18 веке","трыньтрынь");
            ukulele.Show();
            ukulele.Desc();
            ukulele.History();
            ukulele.Sound();
            Console.WriteLine();
            Violoncello violoncello = new Violoncello("Виолончель","Струнный инструмент","Появилась в 15 веке","ууууааауууу");
            violoncello.Show();
            violoncello.Desc();
            violoncello.History();
            violoncello.Sound();
            Console.WriteLine();

            //Работники
            President president = new President();
            Security security = new Security();
            Manager manager = new Manager();
            Engineer engineer = new Engineer();
            president.Print();
            manager.Print();
            security.Print();
            engineer.Print();
            








        }
    }
}