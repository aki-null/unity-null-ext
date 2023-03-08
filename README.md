Unity Null Extension
===

Unity Null Extension is a collection of extension methods to make it easier to use null-conditional operator for Unity objects.

Null-conditional operator cannot be used with `UnityEngine.Object` safely, due to how Unity's object system works.

This project is a code generator to add alternative methods to make the operator friendlier in Unity.

Example
===
Getting a collider from some GameObject or component.

Without extention:
```csharp
Collider collider = null;
if (target != null)
{
    collider = target.GetComponent<Collider>();
}
```

With extension:
```csharp
var collider = target?.OrGetComponent<Collider>();
```

Installation
===
Copy files under `lib` folder to your project.

Generating Code
===
This is needed if you modify the template or definitions.

## Install ninja2
The code generator uses ninja2 as a template engine.
```shell
pip install ninja2
```

## Generate Code
This script reads class definitions from `definition` directory, and emits code to `lib` directory.
```shell
./gen.py
```
