# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property of a class before it has been explicitly initialized.  Uninitialized properties will default to their type's default value (0 for integers, null for references, etc.), which can lead to unexpected behavior or exceptions if not handled correctly.

## The Bug

The `bug.cs` file contains a simple class with a property `MyProperty` and a method `MyMethod`.  `MyMethod` attempts to use the value of `MyProperty` without first initializing it.  Since it is not initialized, this will lead to the property using its default value, potentially causing unexpected results. 

## The Solution

The `bugSolution.cs` file shows the correct way to handle this: explicitly initialize the property either in the constructor, or before using it. This prevents unexpected behavior and ensures the program works as intended.