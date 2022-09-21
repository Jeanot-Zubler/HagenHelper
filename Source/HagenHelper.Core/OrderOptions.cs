namespace HagenHelper.Core;

[Flags]
public enum OrderOptions : int
{
    Default = 0,
    NoSalad = 1,
    OnlyMainMeal = NoSalad,
    NoMainMeal = 2,
    OnlySalad = NoMainMeal,    
    NoMilk = 4,
    Vegetarian = 8,
    Other = 16,
}
