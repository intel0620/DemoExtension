using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0920
{
public static class CheckInOutBetweenExtension
{
    public static void Accept(this IBetween target, IBetweenVisitor visitor)
    {
        var parameterTypes = new Type[] { target.GetType(), typeof(IBetweenVisitor) };
        var method = typeof(CheckInOutBetweenExtension).GetMethod("Accept", parameterTypes, null);
        if (method != null)
        {
            method.Invoke(null, new object[] { target, visitor });
        }
    }

    public static void Accept(InBetween target, IBetweenVisitor visitor)
    {
        visitor.Visit(target);
    }

    public static void Accept(OutBetween target, IBetweenVisitor visitor)
    {
        visitor.Visit(target);
    }

}
}
