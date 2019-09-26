using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0920
{
public interface IBetweenVisitor
{
void Visit(InBetween ckin);
void Visit(OutBetween ckout);
}

public class AreaVisitor : IBetweenVisitor
{
    public void Visit(InBetween ckin)
    {
        if (ckin.StarNum <= ckin.CKnum && ckin.EndNum >= ckin.CKnum)
        {
            Console.WriteLine("Cknumber: " + ckin.CKnum + " InBetween: " + ckin.StarNum + "~" + ckin.EndNum + "    True");
        }
        else
        {
            Console.WriteLine("Cknumber: " + ckin.CKnum + " InBetween: " + ckin.StarNum + "~" + ckin.EndNum + "    False");
        }

    }

    public void Visit(OutBetween ckout)
    {

        if (ckout.CKnum <= ckout.StarNum && ckout.CKnum <= ckout.EndNum)
        {
            Console.WriteLine("Cknumber: " + ckout.CKnum + " OutBetween: " + ckout.StarNum + "~" + ckout.EndNum + "   False");
        }
        else
        {
            Console.WriteLine("Cknumber: " + ckout.CKnum + " OutBetween: " + ckout.StarNum + "~" + ckout.EndNum + "    True");
        }
    }
}



}
