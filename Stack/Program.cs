//Testing our Stack

using OurStack;

var ourSatck = new OurStack<string>(5);

// We have The following Items:  A,B,C,D,E

//Operation 1: Pushing the items onto the stack

ourSatck.Push("A");
ourSatck.Push("B");
ourSatck.Push("C");
ourSatck.Push("D");
ourSatck.Push("E");

Console.WriteLine($"\nPrinting Pushed Items:\n{ourSatck}");

//Operation 2: Peek
Console.WriteLine($"\nPeeking Item:\n{ourSatck.Peek()}");

//Operation 3: Pop
Console.WriteLine($"\nPopping Item:\n{ourSatck.Pop()}");
Console.WriteLine($"\nPrinting Items After Pop Operation:\n{ourSatck}");

//Operation 4: Count
Console.WriteLine($"\nNumber of Items:\n{ourSatck.GetCount()}");


//Operation 5: Contains
Console.WriteLine($"\nCheck whether the stack contains a given item: for instance 'C'\n{ourSatck.Contains("C")}");

//operation 6: Reverse Stack
ourSatck.Reverse();
Console.WriteLine($"\nReversed Stack:\n{ourSatck}");

//operation 7: Checking whether the stack is empty
Console.WriteLine($"\nChecking If stack is empty:\n{ourSatck.IsEmpty()}");

//operation 8: Clearing the stack
ourSatck.Clear();
Console.WriteLine($"\nAfter Clearing, The stack is empty:\n{ourSatck.GetCount()}");





Console.ReadLine();