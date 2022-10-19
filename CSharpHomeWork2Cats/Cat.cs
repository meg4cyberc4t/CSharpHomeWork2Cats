namespace CSharpHomeWork2Cats;

public class Cat
{
    private static int _catCount = 0;

    const int EyesCount = 2;
    const int MinWeight = 1000;
    const int MaxWeight = 10000;

    private bool _isAlive;
    public float Weight { get; private set; }
    private CatColor CatFurColor { get; }
    private bool _hasTail;

    public Cat(bool tail, CatColor fur, bool isAlive = true)
    {
        _isAlive = isAlive;
        _hasTail = tail;
        CatFurColor = fur;
        if (_isAlive)
            _catCount++;
    }

    public Cat(bool tail, CatColor fur, float catWeight, bool isAlive = true) : this(tail, fur, isAlive)
    {
        Weight = catWeight;
    }

    public bool GetHasTail()
    {
        return _hasTail;
    }

    public CatColor GetFurColor()
    {
        return CatFurColor;
    }

    private float _eatenFood = 0;

    public float GetEatenFood()
    {
        return _eatenFood;
    }

    public bool GetIsAlive()
    {
        _isAlive = Weight >= MinWeight & Weight <= MaxWeight;
        return _isAlive;
    }

    public void Meow()
    {
        if (GetIsAlive())
        {
            Weight -= 10;
            if (!GetIsAlive()) _catCount--;
        }
        else Console.WriteLine("Мертвый кот не может мяукать((");
    }

    public void Eat(float food)
    {
        if (GetIsAlive())
        {
            _eatenFood += food;
            Weight += food;
            if (!GetIsAlive()) _catCount--;
        }
        else Console.WriteLine("Мертвый кот не может кушать((");
    }

    public void Pee()
    {
        if (GetIsAlive())
        {
            Weight -= 20;
            if (!GetIsAlive()) _catCount--;
        }
        else Console.WriteLine("Мертвый кот не может ходить под себя");
    }

    public static int GetCatCount()
    {
        return _catCount;
    }

    public Cat Clone()
    {
        return (Cat)MemberwiseClone();
    }
}