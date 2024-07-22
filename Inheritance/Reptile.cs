namespace Inheritance;

public class Reptile : Animal
{
    public Reptile()
    {
        Type = "Reptile";
        Age = 6;
        Sex = "Male";
        Parent = false;
    }
    public string ScaleColor { get; set; }
    public bool LaysEggs { get; set; }
    public bool HasTail { get; set; }
    public string ScaleShape { get; set; }
}