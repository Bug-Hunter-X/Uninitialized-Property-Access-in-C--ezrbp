# Uninitialized Property Access in C#

This repository demonstrates a common error in C#: accessing a property before it has been assigned a value.  This can lead to unexpected behavior, often resulting in exceptions or incorrect calculations.

The `bug.cs` file shows the problematic code. The `bugSolution.cs` file provides a corrected version.

**Problem:**
In the `MyMethod` function, `MyProperty` is used in a calculation without being initialized.  This can result in an exception if the property is a value type or unexpected behavior if it's a reference type.

**Solution:**
Initialize `MyProperty` either in the constructor or before using it in `MyMethod` to avoid this issue.  This ensures that the property has a defined value when accessed.
