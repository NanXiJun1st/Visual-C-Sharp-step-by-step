# note  
### 封装的目的
- 将方法和数据合并到类中，也就是为了支持分类
- 控制对方法和数据的访问，也就是为了控制类的使用

### 随笔
- 如果方法的参数与某个字段同名，在该方法的任何语句中，参数都将覆盖字段。
- 静态方法也称为‘类方法’，静态字段是叫‘静态字段’或者‘静态变量’
- 两个匿名类具有相同数量的字段，并且字段的名称、类型、顺序相同时，则两个变量可以被认为是同一个匿名类的实例
    ```
    var myAnonymousObject = new {Name = "gordon",Age = 28};
    var anotherAnonymousObjecy = new {Name = "Trump",Age = 77};

    myAnonymousObject = anotherAnonymousObjecy;
    ```
