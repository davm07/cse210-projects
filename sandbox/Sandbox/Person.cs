public class Person 
{
    public string _name;
    public string _lastname;
    private int _age = 1000;

    public void DisplayInfo() {
        Console.WriteLine($"{_name} {_lastname} años {_age}");
    }
}
