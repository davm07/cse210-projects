public class Group
{
    public string _groupName;
    public List<Person> _people = new List<Person>();

    public void DisplayGroup()
    {
        Console.WriteLine($"Group name: {_groupName}");
        foreach (Person menso in _people)
        {
            menso.DisplayInfo();
        }
    }
}
