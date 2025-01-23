/*
 
 //problem 1

using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        try {
            int num1 = int.Parse(input);
            Console.WriteLine($"int.Parse result: {num1}");
            
            int num2 = Convert.ToInt32(input);
            Console.WriteLine($"Convert.ToInt32 result: {num2}");
        }
        catch (FormatException) {
            Console.WriteLine("Invalid number format.");
        }
        catch (OverflowException) {
            Console.WriteLine("Number is too large or small.");
        }
        catch (Exception ex) {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}

 //Question Answer:
//int.Parse throws an ArgumentNullException if the input is null, while Convert.ToInt32 returns 0 for null inputs. However, when handling empty strings (not null), both methods throw a FormatException.

 */
/*
 
 // problem 2

 using System;

class Program {
    static void Main() {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number)) {
            Console.WriteLine($"Valid number: {number}");
        } else {
            Console.WriteLine("Invalid input!");
        }
    }
}

 //Question Answer:
//TryParse is recommended because it avoids exceptions, improving performance and providing a graceful way to handle invalid user input.

*/
/*
 
 //problem 3 

using System;

class Program {
    static void Main() {
        object obj = 10;
        Console.WriteLine(obj.GetHashCode()); // Int32 hash

        obj = "Hello";
        Console.WriteLine(obj.GetHashCode()); // String hash

        obj = 3.14;
        Console.WriteLine(obj.GetHashCode()); // Double hash
    }
}

//Question Answer:
//GetHashCode() generates a hash code for an object, primarily used in hash-based collections (e.g., Dictionary) to efficiently store and retrieve objects.
*/

/*
 
// problem 4 

 using System;

class MyClass {
    public int Value;
}

class Program {
    static void Main() {
        MyClass obj1 = new MyClass { Value = 10 };
        MyClass obj2 = obj1;

        obj1.Value = 20;
        Console.WriteLine(obj2.Value); // Output: 20
    }
}

// Question Answer:
//Reference equality in .NET means two variables point to the same memory location. Changes via one reference affect all references to that object.*/

/*
 
 //problem 5

 using System;

class Program {
    static void Main() {
        string str = "Hello";
        Console.WriteLine(str.GetHashCode());
        
        str += " World";
        Console.WriteLine(str.GetHashCode()); // New hash code
    }
}

 //Question Answer:
//Strings are immutable to ensure thread safety, security, and optimization (e.g., interning). Modifications create new strings, preventing unintended side effects.*/

/*
 
 // problem 6 
 
 using System.Text;

class Program {
    static void Main() {
        StringBuilder sb = new StringBuilder("Hi");
        Console.WriteLine(sb.GetHashCode());

        sb.Append(" Willy");
        Console.WriteLine(sb.GetHashCode()); // Same hash code
    }
}

 //Question Answers:

//StringBuilder vs. String: StringBuilder uses a resizable buffer, reducing memory allocations during modifications.

//Speed: For large changes, StringBuilder minimizes costly string reallocations and copies.*/

/*
 
 //problem 7 

 using System;

class Program {
    static void Main() {
        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Sum is " + (a + b)); // Concatenation
        Console.WriteLine(string.Format("Sum is {0}", a + b)); // Composite
        Console.WriteLine($"Sum is {a + b}"); // Interpolation
    }
}

 //Question Answer:
//String interpolation ($"...") is most used due to readability and simplicity.*/

/*
 
//problem 8

using System.Text;

class Program {
    static void Main() {
        StringBuilder sb = new StringBuilder("Hello");
        sb.Append(" World");       // Append
        sb.Replace("World", "C#"); // Replace
        sb.Insert(5, "!!!");       // Insert
        sb.Remove(5, 3);           // Remove
        Console.WriteLine(sb.ToString());
    }
}

//Question Answer:
//StringBuilder efficiently handles frequent changes by maintaining a mutable buffer, avoiding the overhead of creating new strings.
 */
