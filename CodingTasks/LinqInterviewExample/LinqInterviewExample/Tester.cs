namespace LinqInterviewExample
{
	public class Tester : IEmployee
	{

		public int Age { get; set; }
		public string Name { get; set; }

		public Tester(int age, string name)
		{
			Age = age;
			Name = name;
		}
	}
}
