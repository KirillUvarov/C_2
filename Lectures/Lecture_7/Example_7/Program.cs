// Игра в мирамидки (конусы) с блинчиками

void Towers(string with = "1", string on = "3", string some = "2", int count = 3) // count - количество блинов
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}

Towers();
