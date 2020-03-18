using System;

public class Tester : Employee
{

	public int Age => new int () { };
	public string Name => new string() { };

	public Tester(int age, string name)
	{
		Age = age;
		Name = name;
	}
}
