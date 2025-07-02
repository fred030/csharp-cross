//第一种注释 两杠注释    CTRL+K+C 注释
//星号注释，多行注释
/*sahgduHNDOLKAJNCOIASHCIASNBCKJASDNC
KJSHCGIASNCLAKSDNC*/
//三行注释<>

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.Write("你好");//write和writeline的区别是write不会自动换行
//Console.WriteLine("请玩家输入：");
//Console.ReadLine();
//Console.WriteLine("玩家输入完毕");

//Console.ReadKey();//检测是否按键，输入任意键就会认为是输入结束


//输出是在控制台输出信息
//输入是向控制台输入内容

using System;

class Program
{
    static void Main()
    {
        // 提示用户输入
        Console.WriteLine("请输入你的名字：");
        string name = Console.ReadLine();

        Console.WriteLine("请输入你的年龄：");
        string age = Console.ReadLine();

        Console.WriteLine("请输入你的班级：");
        string className = Console.ReadLine();

        Console.WriteLine("输入完毕！");
        Console.ReadKey();

        Console.WriteLine("你喜欢什么运动？");
        string sport = Console.ReadLine();

        Console.WriteLine($"好巧啊，{name}，我也喜欢 {sport}！");
    }
}
