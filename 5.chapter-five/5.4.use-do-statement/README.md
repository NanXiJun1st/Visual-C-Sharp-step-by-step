## note
**Q:不能理解的地方**  
在`int digitCode = '0' + nextDight`中，必须加上`0`最终输出才正常，加上`8`也不行，最终输出都会乱码。  
```
 int amount = int.Parse(number.Text);
 steps.Text = "";
 string current = "";

 do
 {
     int nextDigit = amount % 8;
     amount /= 8;
     int digitCode = '0' + nextDigit;
     char digit = Convert.ToChar(digitCode);
     current = digit + current;
     steps.Text += current + "\n";
 }
 while (amount != 0);
```
**文中解释：**
```
每个字符都有唯一代码，具体由操作系统使用的字符集决定。在Windows常用的字符集中，字符‘0’的代码是整数值48.字符‘1’的代码是49，字符‘2’的代码是50，以此类推，直到字符‘9’，它的代码是57。C#允许将字符当做整数处理，允许对它们执行算术运算。但这样做会将字符码作为值使用。所以，在表达式'0' + nextDigit的结果是48~55之间的值（nextDigit的值在0~7之间），对应等价的八进制数位的代码。
```