using CSharpHomeWork2Cats;

Cat GetKitten(bool hasTail, CatColor furColor)
{
    return new Cat(hasTail, furColor, 1000.0f);
}

Cat cat1 = GetKitten(true, CatColor.Black);
Cat cat2 = GetKitten(false, CatColor.White);
Console.WriteLine("Всего котов (должно быть 2): {0}", Cat.GetCatCount());

Console.WriteLine("Первого кота заставим умереть");
Console.WriteLine("Было веса до: {0}", cat1.Weight);
while (cat1.GetIsAlive())
{
    cat1.Eat(100);
}
Console.WriteLine("Веса после: {0}", cat1.Weight);
Console.WriteLine("Съеденной еды: {0}\n", cat1.GetEatenFood());

Console.WriteLine("Второго кота заставим умереть");
cat2.Eat(200);
Console.WriteLine("Вес до: {0}", cat2.Weight);

while (cat2.GetIsAlive())
{
    cat2.Meow();
}

Console.WriteLine("Вес после: {0}", cat2.Weight);
Console.WriteLine("Съеденной еды: {0}\n", cat2.GetEatenFood());
cat2.Pee();

Console.WriteLine("Всего котов: {0}", Cat.GetCatCount());
Cat cat3 = cat1.Clone();
Console.WriteLine("Живой ли кот: {0}", cat3.GetIsAlive());
Console.WriteLine("Всего котов: {0}", Cat.GetCatCount());
Cat cat4 = GetKitten(false, CatColor.Brown);
Cat cat5 = cat4.Clone();
Console.WriteLine("Живой ли кот: {0}", cat5.GetIsAlive());
Console.WriteLine("Всего котов: {0}", Cat.GetCatCount());

// Я не люблю убивать котов, это всё по ТЗ!