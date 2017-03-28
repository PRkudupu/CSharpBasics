using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBascis
{
    class ListExample
    {
     
        public List<string> GetCountries()
        {
            //Add Data to the List
            List<string> countries = new List<string>();
            
                countries.Add("India ");
                countries.Add("America");
                countries.Add("Australia");
            return countries;

        }
        public List<int> GetZipCode()
        {
            //Add Data to the List
            List<int> ZipCodeList = new List<int>();

            ZipCodeList.Add(95015);
            ZipCodeList.Add(06360);
            ZipCodeList.Add(97035);
            return ZipCodeList;

        }

    }
}
