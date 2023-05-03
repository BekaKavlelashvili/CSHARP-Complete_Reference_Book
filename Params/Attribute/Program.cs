using System.Diagnostics;
using System.Text.Json;
using System.Xml.Linq;

[AttributeUsage(AttributeTargets.All)]
public class RemarkAttribute : Attribute
{
	string pre_mark;

	public RemarkAttribute(string comment)
	{
		pre_mark = comment;
	}

	public string Remark { get { return pre_mark; } }
}

[RemarkAttribute("This class uses an attribute.")]
class UseAttribute
{

}

class AttributeDemo
{
	static void Main()
	{
		Type t = typeof(UseAttribute);

		Console.Write("Attributes in " + t.Name + ": ");

		object[] attributes = t.GetCustomAttributes(false);
		foreach (object o in attributes)
		{
			Console.WriteLine(o);
		}

		Console.Write("Remark: ");
		Type tRemAtt = typeof(RemarkAttribute);
		RemarkAttribute ra = (RemarkAttribute)Attribute.GetCustomAttribute(t, tRemAtt);

		Console.WriteLine(ra.Remark);
	}
}