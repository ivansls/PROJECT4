using Everydayinik;

bool isListenning = true;

DateTime now = DateTime.Now;

int plusDay = 0;
List<Date1> zametki = new List<Date1>() { };

Console.WriteLine(now.AddDays(plusDay).ToLongDateString());

int posicion = 1;

Date1 zametka1 = new Date1();

zametka1.Name = "Сходить в шарагу";
zametka1.Description = "Желательно сходить и посидеть на всех парах";
zametka1.Done = "19.10.22";
zametka1.Dade = new DateTime(2022, 10, 15).ToLongDateString();
zametki.Add(zametka1);

Date1 zametka2 = new Date1();
zametka2.Name = "Купить слона";
zametka2.Description = "Надо успеть до ажиотажа";
zametka2.Done = "25.10.22";
zametka2.Dade = new DateTime(2022, 10, 15).ToLongDateString();
zametki.Add(zametka2);

Date1 zametka3 = new Date1();
zametka3.Name = "Отдохнуть";
zametka3.Description = "Эх... отдыхать бы вечно, но есть всего 15 минут :(";
zametka3.Done = "18.10.22";
zametka3.Dade = new DateTime(2022, 10, 18).ToLongDateString();
zametki.Add(zametka3);

Date1 zametka4 = new Date1();
zametka4.Name = "Сходить в магазин";
zametka4.Description = "Бегом за ПЕЛЬМЕНЯМИ!!!";
zametka4.Done = "18.10.22";
zametka4.Dade = new DateTime(2022, 10, 18).ToLongDateString();
zametki.Add(zametka4);

Date1 zametka5 = new Date1();
zametka5.Name = "ДОДЕЛЯТЬ ЕЖЕДНЕВНИК ПО С#";
zametka5.Description = "ОСТАЛОСЬ МЕНЬШЕ ЧЕМ ДЕНЬ ДО СДАЧИ";
zametka5.Done = "21.10.22";
zametka5.Dade = new DateTime(2022, 10, 20).ToLongDateString();
zametki.Add(zametka5);

void zamet(ConsoleKeyInfo key)
{
    if (zametka1.Dade == now.AddDays(plusDay).ToLongDateString())
    {
        Console.SetCursorPosition(2, 1);
        Console.WriteLine("1: " + zametki[0].Name);
        Console.SetCursorPosition(2, 2);
        Console.WriteLine("2: " + zametki[1].Name);
        if (key.Key == ConsoleKey.Enter && posicion == 1)
        {
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("1:Дата создания " + zametki[0].Dade);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("2:Название " + zametki[0].Name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("3:Описание " + zametki[0].Description);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("4:Дата окрнчания " + zametki[0].Done);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Чтобы выйти обратно нажмите любую кнопку");
        }
        else if (key.Key == ConsoleKey.Enter && posicion == 2)
        {
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("1:Дата создания " + zametki[1].Dade);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("2:Название " + zametki[1].Name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("3:Описание " + zametki[1].Description);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("4:Дата окрнчания " + zametki[1].Done);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Чтобы выйти обратно нажмите любую кнопку");
        }
    }
    else if (zametka3.Dade == now.AddDays(plusDay).ToLongDateString())
    {
        Console.SetCursorPosition(2, 1);
        Console.WriteLine("1: " + zametki[2].Name);
        Console.SetCursorPosition(2, 2);
        Console.WriteLine("2: " + zametki[3].Name);
        if (key.Key == ConsoleKey.Enter && posicion == 1)
        {
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("1:Дата создания " + zametki[2].Dade);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("2:Название " + zametki[2].Name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("3:Описание " + zametki[2].Description);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("4:Дата окрнчания " + zametki[2].Done);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Чтобы выйти обратно нажмите любую кнопку");
        }
        else if (key.Key == ConsoleKey.Enter && posicion == 2)
        {
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("1:Дата создания " + zametki[3].Dade);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("2:Название " + zametki[3].Name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("3:Описание " + zametki[3].Description);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("4:Дата окрнчания " + zametki[1].Done);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Чтобы выйти обратно нажмите любую кнопку");
        }
    }
    else if (zametka5.Dade == now.AddDays(plusDay).ToLongDateString())
    {
        Console.SetCursorPosition(2, 1);
        Console.WriteLine("1: " + zametki[4].Name);
        if (key.Key == ConsoleKey.Enter && posicion == 1)
        {
            Console.Clear();
            Console.SetCursorPosition(2, 1);
            Console.WriteLine("1:Дата создания " + zametki[4].Dade);
            Console.SetCursorPosition(2, 2);
            Console.WriteLine("2:Название " + zametki[4].Name);
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("3:Описание " + zametki[4].Description);
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("4:Дата окрнчания " + zametki[4].Done);
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("Чтобы выйти обратно нажмите любую кнопку");
        }
    }
}


void Cursor(ConsoleKeyInfo key)
{
    if (key.Key == ConsoleKey.UpArrow)
    {
        if (posicion - 1 == 0)
        {
            posicion = 1;
        }
        else
        {
            posicion--;
        }
    }
    else if (key.Key == ConsoleKey.DownArrow)
    {
        posicion++;
    }
    else if (key.Key == ConsoleKey.RightArrow)
    {
        plusDay++;
    }
    else if (key.Key == ConsoleKey.LeftArrow)
    {
        plusDay--;
    }
    else if (key.Key == ConsoleKey.Escape)
    {
        isListenning = false;
    }
    Console.Clear();
}


while (isListenning == true)
{
    ConsoleKeyInfo key = Console.ReadKey();
    Cursor(key);
    zamet(key);
    Console.SetCursorPosition(0, 0);
    Console.WriteLine(now.AddDays(plusDay).ToLongDateString());
    Console.SetCursorPosition(0, posicion);
    Console.WriteLine("->");
}
