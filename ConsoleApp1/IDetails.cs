using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IDetails
    {
        int GetMemberName(string name);
    }

    public abstract class Details
    {
        public abstract double GetMemberSalary(string name);

        public int GetMemberName()
        {
            return 1;
        }
    
    }

    public class CHildDetails : Details
    {
        public override double GetMemberSalary(string name)
        {
            throw new NotImplementedException();
        }
    }
}
