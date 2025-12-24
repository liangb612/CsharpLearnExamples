using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace towerOfHanoi
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            uint textN;
            textN = 4;//测试值
            Console.WriteLine(CountHanoi(textN));//调用并打印结果
            
         }
        static uint CountHanoi(uint n)//静态方法，静态方法只能访问静态的属性
        {
            uint count = 0;
            if (n == 2)
                return 3;//递归出口，同时也对应一个递归前方的示例可以改为如下形式
            /*if (n == 1)
                return 1;
            if (n == 2)
                return 3;
             */
            else
            {
                count = 2 * CountHanoi(n - 1) + 1;/*假设上一阶数的汉诺塔移动次数结果已知，那么这一次的返回值为
                                                     按照上一阶的移动方法移动到任意空柱子上，再把本次大圆盘移动到第
                                                   三根柱子上，最后再按照上一阶的移动方法移动一遍。总的次数等于上一阶
                                                   的移动次数+大圆盘一次+上一阶移动次数。然而上一阶移动次数未知，那就
                                                   再往前直到不再调用自己时开始从前往后计算。
                                                   */
                return count;
            }
        }
    }
   
}
