using System;

class Program
{
    static void Main(string[] args)
    {
        Person person1 = new Person();
        person1._name = "Luis";
        person1._lastname = "Pardo";

        Person person2 = new Person();
        person2._name = "Diego";
        person2._lastname = "Vasquez";

        Group group1 = new Group();
        group1._groupName = "Perrones";
        group1._people.Add(person1);
        group1._people.Add(person2);
        group1.DisplayGroup();
    }
}