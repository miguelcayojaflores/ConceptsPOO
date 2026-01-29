
using ConceptsPOO;

Console.WriteLine("Hello, World!");


try
{
	Console.WriteLine(new Date(2026,2,28));
	Console.WriteLine(new Date(2026,12,31));
	Console.WriteLine(new Date(2026,2,28));
}
catch (Exception Error )
{
	Console.WriteLine(Error.Message);
}

