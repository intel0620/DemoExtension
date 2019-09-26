using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0920
{
    public interface IBetween
    {
        int CKnum { get; }
    }


public class InBetween : IBetween
{
    public int StarNum { get; private set; }
    public int EndNum { get; private set; }

    public int CKnum { get; private set; }

    public InBetween(int starNum, int endNum, int _CKnum)
    {
        StarNum = starNum;
        EndNum = endNum;
        CKnum = _CKnum;
    }
}

public class OutBetween : IBetween
{
    public int StarNum { get; private set; }
    public int EndNum { get; private set; }

    public int CKnum { get; private set; }

    public OutBetween(int starNum, int endNum, int _CKnum)
    {
        StarNum = starNum;
        EndNum = endNum;
        CKnum = _CKnum;
    }
}

}
