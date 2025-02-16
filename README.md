### **1. Which of the following is the correct syntax to define a class in C#?**

- a) `class MyClass { }`
- b) `class: MyClass { }`
- c) `class MyClass() { }`
- d) `MyClass class { }`

answer:- `class MyClass { }`

### **2. What is the default access modifier for members of a class in C#?**

- a) `public`
- b) `private`
- c) `protected`
- d) `internal`

Answer:-  b) `private`

### **3. Which of the following is true about constructors in C#?**

- a) A constructor has a return type.
- b) A constructor can have the same name as the class.
- c) Constructors cannot be overloaded.
- d) A constructor must always be public.

Answer :-  b) A constructor can have the same name as the class.

### **4. What is the result of the following code?**

```csharp
class MyClass {
    public int x = 5;
}

class Program {
    static void Main() {
        MyClass obj = new MyClass();
        Console.WriteLine(obj.x);
    }
}

```

- a) Error, obj is not initialized.
- b) 0
- c) 5
- d) Compilation error.

Answer:- c) 5

### **5. What is the purpose of the `this` keyword in C#?**

- a) It refers to the class itself.
- b) It is used to access the instance members of the current object.
- c) It refers to the static members of the class.
- d) It is used to inherit a class.

Answer:- b) It is used to access the instance members of the current object.

### **6. Which of the following is an example of a property in a C# class?**

- a) `public int x;`
- b) `public int x { get; set; }`
- c) `public void SetX(int value) { x = value; }`
- d) `public void X(int value) { x = value; }`

Answer:- b) `public int x { get; set; }`

### **7. What will happen if you try to access a private member of a class from outside that class in C#?**

- a) Compilation error
- b) The member will be accessed, but a warning will be shown
- c) Runtime exception
- d) It will be allowed if the member is inside a method

Answer:- a) Compilation error

### **8. Which of the following statements is correct about the C#.NET code snippet given below?**

```csharp
int i;
int j = new int();
i = j = ;
String str;
str = i.ToString();
str = j.ToString();

```

1. This is a perfectly workable code snippet.
2. Since `int` is a primitive, we cannot use `new` with it.
3. Since an `int` is a primitive, we cannot call the method `ToString()` using it.
4. `i` will get created on stack, whereas `j` will get created on heap.
5. Both `i` and `j` will get created on heap.

Answer:- 2. Since `int` is a primitive, we cannot use `new` with it.


### **Which of the following statements are correct about the `this` reference?**

1. `this` reference can be modified in the instance member function of a class.
2. Static functions of a class never receive the `this` reference.
3. Instance member functions of a class always receive a `this` reference.
4. `this` reference continues to exist even after control returns from an instance member function.
5. While calling an instance member function we are not required to pass the `this` reference explicitly.

Answer:-`this` reference continues to exist even after control returns from an instance member function.
---

### **Which of the following is the correct way to create an object of the `class Sample`?**

1. `Sample s = new Sample();`
2. `Sample s;`
3. `Sample s; s = new Sample();`
4. `s = new Sample();`

Answer:- `Sample s = new Sample();`
