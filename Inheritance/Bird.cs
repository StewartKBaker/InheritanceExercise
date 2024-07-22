namespace Inheritance;

public class Bird : Animal
{
    public Bird()
    {
        Type = "Bird";
        Age = 10;
        Sex = "Female";
        Parent = true;
    }
    public bool CanFly { get; set; }
    public string ChirpNoise { get; set; }
    public string FeatherColor { get; set; }
    public string BeakLength { get; set; }
}