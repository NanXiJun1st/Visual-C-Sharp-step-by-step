## note
- 将数据项从栈自动复制到堆上的行为 / 将值类型转换为引用类型的过程称为**装箱**
- 将引用类型转换为值类型的过程成为**拆箱**
- 装箱和拆箱操作可能会影响性能，因为它们涉及到在堆和堆栈之间移动数据。因此，在编写代码时，应尽量避免不必要的装箱和拆箱操作。例如，使用泛型可以避免在容器类（如`List<T>`）中进行装箱和拆箱
- 在数据类型转换时可以通过`is`和`as`操作符对类型进行判断，如：
    ```
    WrappedInt wi = new WrappedInt();
    object o = wi;
    
    // if (o is WrappedInt)
    // {
    //     WrappedInt temp = (WrappedInt)o;
    // }
    
    if (o is WrappedInt temp)
    {
        ... // Use temp here
    }
    ```
    ```
    WrappedInt wi = new WrappedInt();
    object o = wi;
    WrappedInt temp = o as WrappedInt;
    if (temp != null)
    {
        ... // 只有转型成功，这里的代码才会执行
    }
    ```
- 在声明变量时，可以通过`?`修饰符，使其可以容纳值类型的值或者`null`值。如`int? i = null`  