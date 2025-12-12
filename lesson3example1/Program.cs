using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lesson3example1//本节课学习了类的实例化，引用变量
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建了一个匿名实例
            //(new Form()).ShowDialog();
            //声明一个引用变量
            Form myform;
            myform = new Form();
            myform.ShowDialog();

        }
    }
}
