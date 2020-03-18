using System;

public class Developer : Employee
{
	public int Age => new int() { };
	public string Name => new string() { };

	public Developer(int age, string name)
	{
		Age = age;
		Name = name;
	}
}
