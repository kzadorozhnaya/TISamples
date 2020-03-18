
namespace LinqInterviewExample
{
	public class Developer : IEmployee
	{
		public int Age { get; set; }
		public string Name { get; set; }

		public Developer(int age, string name)
		{
			Age = age;
			Name = name;
		}
	}
}
