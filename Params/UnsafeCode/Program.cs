using System.Reflection.Metadata;
using System.Xml;
using UnsafeCode;

class UnsafeCodeDemo
{
	unsafe static void UseUnsafe()
	{
		Console.WriteLine("\n=== Use Unsafe ===");
		int count = 99;
		int* p; //create an int pointer

		p = &count; // put count address in p pointer

		Console.WriteLine("Initiale value of count is : " + *p);

		*p = 10; // assign 10 to count via *p

		Console.WriteLine("New value of count is: " + *p);
	}

	unsafe static void UseFixed()
	{
		Console.WriteLine("\n=== Use Fixed ===");

		UseFixedCode fixedCode = new UseFixedCode(19);

		fixed (int* p = &fixedCode.num)
		{
			Console.WriteLine("Initial value of fixedCode.Num is: " + *p);

			*p = 10;

			Console.WriteLine("New value of o.num is " + *p);
		}
	}

	static void Main()
	{
		UseUnsafe();
		UseFixed();
		StructureWithPointers.StructureWithPointersMain();
		PointerArithmetic.PointerArithmeticMain();
		PointersAndArrays.PointersAndArraysMain();
		PointersAndStrings.PointersAndStringsMain();
		MultipleIndirect.MultipleIndirectMain();
		StackAlloc.StackAllocMain();
	}
}

class UseFixedCode
{
	public int num;

	public UseFixedCode(int num)
	{
		this.num = num;
	}	
}
