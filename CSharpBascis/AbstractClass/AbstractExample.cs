using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBascis.AbstractClass
{
    /// <summary>
    /// Abstract class can only be implemented cannot be instantiated
    /// Would prevent accidentel use of the base class
    /// Abstract method : If we make the method abstract we do not have to provide the implementation
    /// When abstarct keyword is used for a method then it cannot have implementations
    /// </summary>
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string GetFullName()
        {
            return this.FirstName + this.LastName;
        }
        //abstract method
        public abstract int GetMontlySalary();
    }

    public class FulltimeEmployee : BaseEmployee
    {
        public int AnnualSalary { get; set; }
        //abstract method
        public override int GetMontlySalary()

        {
            return this.AnnualSalary / 12;
        }
    }
    public class ContractEmployee : BaseEmployee
    {
        public int Hours { get; set; }
        public int Pay { get; set; }
        //abstract method
        public override int GetMontlySalary()

        {
            return this.Hours * Pay;
        }
    }
}
