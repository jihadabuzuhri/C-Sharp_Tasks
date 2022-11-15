using System;

class Stack<T> 
{
	static readonly int MAX =10;
	int top=-1;
	T[] stack = new T[MAX];
	
	public bool Push (T item )
	{	

		if (top >= MAX-1 )
		{
			Console.WriteLine("stack is full");
			return false;
		}
		
		top++;
		stack[top]=item;
		return true;
		
	}
	
	public T Pop ()
	{	
		if (top < 0)
		return default(T);
		
		T item =stack[top];  
		top--;
		return item;
		
	}
	
	public void Print ()
	{	
		if (top < 0)
		Console.WriteLine("No items to Print");
		
		for ( int i =top; i>-1;i--)
		Console.WriteLine(stack[i]);
		
	}
	
	public void Peak ()
	{	
		if (top < 0)
		{
			Console.WriteLine("stack in empty");
		}
		
		else 
		{
			T item =stack[top];  
			Console.WriteLine(item);
		}
		
	}
	
		
	public void Clear ()
	{	
		top =-1;
	}
	
	
	public bool IsEmpty()
	{	
		return (top == -1);
	}
	
	public int Count()
	{	
		return (top + 1);
	}
	
}


public class Program
{
	public static void Main()
	{
		
			Stack<int> myStack = new Stack <int>();
  
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
            
			myStack.Print();
            
			myStack.Peak();
            
			Console.WriteLine("Item popped from Stack : {0}", myStack.Pop());
            
			myStack.Print();
			Console.WriteLine("myStack.IsEmpty() ? {0} ",myStack.IsEmpty());
		
			myStack.Clear();
			
			myStack.Print();
			Console.WriteLine("myStack.IsEmpty() ? {0}",myStack.IsEmpty());
		
			
			myStack.Push(10);
            myStack.Push(20);
            myStack.Push(30);
            myStack.Push(40);
			myStack.Push(50);
            myStack.Push(60);
			Console.WriteLine("Number of items in myStack : {0} ",myStack.Count());
            myStack.Push(70);
            myStack.Push(80);
			myStack.Push(90);
            myStack.Push(100);
            myStack.Push(110);
			Console.WriteLine("Number of items in myStack : {0} ",myStack.Count());
			Console.WriteLine(myStack.Push(110));
		
		
			
			Console.WriteLine("__________________________________________________");

			
			Stack<String> StringStack = new Stack <String>();
  
            StringStack.Push("10");
            StringStack.Push("20");
            StringStack.Push("30");
            StringStack.Push("40");
            
			StringStack.Print();
            
			StringStack.Peak();
            
			Console.WriteLine("Item popped from Stack : {0}", StringStack.Pop());
            
			StringStack.Print();
			Console.WriteLine("StringStack.IsEmpty() ? {0} ",StringStack.IsEmpty());
		
			StringStack.Clear();
			
			StringStack.Print();
			Console.WriteLine("StringStack.IsEmpty() ? {0}",StringStack.IsEmpty());
		
			
			StringStack.Push("10");
            StringStack.Push("20");
            StringStack.Push("30");
            StringStack.Push("40");
			StringStack.Push("50");
            StringStack.Push("60");
			Console.WriteLine("Number of items in StringStack : {0} ",StringStack.Count());
            StringStack.Push("70");
            StringStack.Push("80");
			StringStack.Push("90");
            StringStack.Push("100");
            StringStack.Push("110");
			Console.WriteLine("Number of items in StringStack : {0} ",StringStack.Count());
			Console.WriteLine(StringStack.Push("110"));
		
		
		

	
	}
}