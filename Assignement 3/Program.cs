using System;

class Person
{
    // Private member variables
    private string name;
    private int age;

    // Constructor
    public Person()
    {
        // Initialize variables or perform other setup tasks
        name = "";
        age = 0;
    }

    // Method to set details of the person
    private void SetDetails(string personName, int personAge)
    {
        // Validation can be added here if needed
        name = personName;
        age = personAge;
    }

    // Method to get details of the person
    private string GetDetails()
    {
        return $"Name: {name}, Age: {age}";
    }

    // Example of another private method
    private void DoSomething()
    {
        Console.WriteLine("I'm argentine professional footballer ");
    }

    // Main method for demonstration
    static void Main()
    {
        // Create an instance of the Person class
        Person person = new Person();

        // Call the SetDetails method to set the person's details
        person.SetDetails("Lionel Messi ", 36 );

        // Call the GetDetails method to retrieve and print the person's details
        string details = person.GetDetails();
        Console.WriteLine(details);

        // Call another method for demonstration
        person.DoSomething();
    }
}
