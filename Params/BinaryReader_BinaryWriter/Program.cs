using System.Security.AccessControl;

class Inventory
{
    static void Main()
    {
        BinaryWriter dataOut;
        BinaryReader dataIn;

        string item;
        int onHand;
        double cost;

        try
        {
            dataOut = new BinaryWriter(new FileStream("inventory.dat", FileMode.Create));
        }
        catch (IOException exc)
        {
            Console.WriteLine("Cannot open inventory file for output.");
            Console.WriteLine("Reason: " + exc.Message);
            return;
        }

        try
        {
            dataOut.Write("Hammers");
            dataOut.Write(10);
            dataOut.Write(3.95);

            dataOut.Write("Screwdrivers");
            dataOut.Write(18);
            dataOut.Write(1.50);

            dataOut.Write("Pliers");
            dataOut.Write(5);
            dataOut.Write(4.95);

            dataOut.Write("Saws");
            dataOut.Write(8);
            dataOut.Write(8.95);
        }
        catch (IOException exc)
        {
            Console.WriteLine("Error writing inventory files.");
            Console.WriteLine("Reason: " + exc.Message);
        }
        finally
        {
            dataOut.Close();
        }

        Console.WriteLine();

        try
        {
            dataIn = new BinaryReader(new FileStream("inventory.dat", FileMode.Open));
        }
        catch (IOException exc)
        {
            Console.WriteLine("Cannot open inventory file for input.");
            Console.WriteLine("Reason: " + exc.Message);
            return;
        }

        Console.Write("Enter item to look up: ");
        string what = Console.ReadLine();
        Console.WriteLine();

        try
        {
            for (; ; )
            {
                item = dataIn.ReadString();
                onHand = dataIn.ReadInt32();
                cost = dataIn.ReadDouble();

                if (item.Equals(what, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(onHand + " " + item + " on hand. " + "Cost: {0:C} each", cost);
                    Console.WriteLine("Total value of {0}: {1:C}.", item, cost * onHand);
                    break;
                }
            }
        }
        catch (EndOfStreamException)
        {
            Console.WriteLine("Item not found");
        }catch(IOException exc)
        {
            Console.WriteLine("error reading inventory file.");
            Console.WriteLine("Reason: " + exc.Message);
        }
        finally
        {
            dataIn.Close();
        }
    }
}