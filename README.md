# C# Runtime Exception: Accessing a Non-Existent Property

This repository demonstrates a common runtime exception in C# that occurs when accessing a property that either does not exist in the class or has not been properly initialized.  The code example shows how attempting to access `NonExistentProperty` in `ExampleClass` throws an exception.

## How to Reproduce

1. Clone this repository.
2. Compile and run `bug.cs`.  You'll observe a runtime exception.
3. The `bugSolution.cs` demonstrates a safe way to handle potential issues.