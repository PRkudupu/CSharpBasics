using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Collections;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;

namespace CSharpBascis
{
    public partial class frmDisplay : Form
    {
        public frmDisplay()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Array ArrayList
        /// <summary>
        /// ARRAY ARRAY LIST AND OBJECTS
        /// Can you store different types in an array ?
        /// Yes . If you create object array.Since all types inherit from object.array.Since all types inherit directly or indirectly from object type.
        /// We can add any types to an array including complex types
        /// For displaying complex types we need to override the ToString() if we want meaningful ouptput when ToString() method is invoked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ArrayList_Click(object sender, EventArgs e)
        {
            //Strongly types arrray
            int [] array= new int[2];
            array[0] = 10;
            //array[1] = "2"; Not we get compile time error

            //We can use an object
            object [] objArray= new object[3];
            objArray[0] = 1;
            objArray[1] = "2";

            //We can also store complex type in an array
            Customer customer= new Customer();
            customer.ID = 1;
            customer.Name = "String Object";
            objArray[2] = customer;

            //ArrayList allows to add a type of object, so we can add any data type to an arraylist
            ArrayList arrayList= new ArrayList();
            arrayList.Add(1);
            arrayList.Add("Test");

            //display using a for each loop for an array
            foreach (var obj in array)
            {
                MessageBox.Show(@"Integer Array :" +obj);
            }
            //display using a for each loop
            foreach (var obj in objArray)
            {
                MessageBox.Show(@"Object Array :"+ obj);
            }

            //Display data from an arrayList
            foreach (var obj in arrayList)
            {
                MessageBox.Show(@"Array List :"+obj);
            }
        }
        public class Customer
        {
            public int ID { get; set; }
            public string Name { get; set; }

            //Overide ToString method 
            public override string ToString()
            {
                return this.Name;
            }
        }
        #endregion

        #region JaggedArray
        /// <summary>
        /// Jagged array is an array or arrays
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JarredArray_Click(object sender, EventArgs e)
        {
            // string array to store employee names
            string[] employeeNames = new string[3];
            employeeNames[0] = "Mark";
            employeeNames[1] = "Matt";
            employeeNames[2] = "John";

            // string array to store employee qulifications
            string[] [] jaggedArray = new string[3] [];
            //Specify the size of the array
            jaggedArray[0] = new string[3];
            jaggedArray[1] = new string[1];
            jaggedArray[2] = new string[2];

            //initilize first string array
            jaggedArray[0] [0]=  "Bachelors";
            jaggedArray[0] [1] = "Masters";
            jaggedArray[0] [2] = "Doctorate";

            //initilize second string array
            jaggedArray[1][0] = "Bachelors";
            
            //initilize third string array
            jaggedArray[2][0] = "Bachelors";
            jaggedArray[2][1] = "Masters";
        
            // Loop through the array. We need to get the length of the jagged array
            for (int i = 0; i < jaggedArray.Length; i++)
            {
                
                string[] innerArray = jaggedArray[i];
                //loop through the inner array
                for (int j = 0; j < innerArray.Length; j++)
                {
                    MessageBox.Show(@"Employee Name :" + employeeNames[i] + @"--> "+ innerArray[j]);
                }
            }
        }

        #endregion

        #region Abstract class implementation
        private void button3_Click(object sender, EventArgs e)
        {
            //GetFullTimeEmployee
            AbstractClass.FulltimeEmployee fulltimeEmployee = new CSharpBascis.AbstractClass.FulltimeEmployee();
            fulltimeEmployee.Id = 1;
            fulltimeEmployee.FirstName = "Prathap ";
            fulltimeEmployee.LastName = "Kudupu";
            fulltimeEmployee.AnnualSalary = 30000;
            MessageBox.Show(@"FullName :" + fulltimeEmployee.GetFullName() + @"Salary :" + fulltimeEmployee.GetMontlySalary());

            //Contract employee
            AbstractClass.ContractEmployee contractEmployee = new CSharpBascis.AbstractClass.ContractEmployee();
            contractEmployee.Id = 1;
            contractEmployee.FirstName = "Prathap ";
            contractEmployee.LastName = "Kudupu";
            contractEmployee.Pay = 95;
            contractEmployee.Hours = 160;
            MessageBox.Show(@"Contract :" + contractEmployee.GetFullName() + @"Salary :" + contractEmployee.GetMontlySalary());

        }


        #endregion

        #region reverse Array string
        private void button4_Click(object sender, EventArgs e)
        {
            Reverse(txtStringToveReveresed.Text);

            MessageBox.Show(@"Rev :" + Reverse(txtStringToveReveresed.Text) );
            MessageBox.Show(@"Array Reverse :" + Reverse(txtStringToveReveresed.Text));

        }

        //function to reverse a string
        public string Reverse(string text)
        {

            //Convert the 
            char[] cArray = text.ToCharArray();

            string reverse = string.Empty;
            for (int i = cArray.Length - 1; i >= 0; i--)
            {
                reverse = reverse + cArray[i];

            }
            return reverse;
        }
       
        //function to reverse using array.reverse
        public string ArrayReverse(string text)
        {
            //Convert the 
            char[] cArray = text.ToCharArray();
            Array.Reverse(cArray);
              return new string( cArray);
        }
        #endregion

        #region Generics
        private void Generics_Click(object sender, EventArgs e)
        {
            //Using strongly typed function
            bool isEqual = GenericsExample.IsEqualStronglyType(10, 10);
            MessageBox.Show(@"isEqual :" + isEqual);
            //Using object typed function
            bool isObjectEqual = GenericsExample.IsEqualObjectType(10, 10);
            MessageBox.Show(@"isobjetEqual :" + isObjectEqual);
            //check for generic method
            bool isGenericEqual = GenericsExample.IsGenericEqual<int>(10, 10);
            MessageBox.Show(@"isGenericEqual :" + isGenericEqual);
            //check for generic class
            bool isGenericClassEqual = GenericClassExample<int>.IsGenericEqual(10, 10);
            MessageBox.Show(@"is Generic Class Equal :" + isGenericClassEqual);
            
        }
        #endregion

        #region Factory pattern implementation
        /// <summary>
        /// Example for factory pattern implementation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void abstractFactory_Click(object sender, EventArgs e)
        {
           
            //Call Simple customer factory
            FactoryPattern.CustomerFactory obj= new FactoryPattern.CustomerFactory();
            //Simple Customer
            var simpleObj=obj.create(0);
            //Discounted Customer
            var discountedObj=obj.create(1);

            MessageBox.Show(@"Simple Customer :" + simpleObj.Calculate());
            MessageBox.Show(@"Discounted Customer :" + discountedObj.Calculate());


        }
        #endregion

        #region List
        /// <summary>
        /// Api to show using List 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListExample_Click(object sender, EventArgs e)
        {
            ListExample lst = new ListExample();
            //Fetch the list of countries
            var country = lst.GetCountries();
            //Use for each for display
            foreach (String ls in country)
            {
                MessageBox.Show(@"Countries :"+ls);
            }
            //Use for display
            for(int i=0;i<= country.Count-1;i++)
            {
                MessageBox.Show(@"For loop Countries :" + country[i]);
            }
            //Fetch the list of countries
            var zipCode = lst.GetZipCode();

            //Use for display
            foreach (int ls in zipCode)
            {
                MessageBox.Show(@"Zip Code :" + ls);
            }
            //Use for display
            for (int i = 0; i <= zipCode.Count-1; i++)
            {
                MessageBox.Show(@"For loop zipCode :" + zipCode[i]);
            }
        }
        #endregion

        #region Async and Await

        /// <summary>
        /// Example for async and await
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void asyncAwait_Click(object sender, EventArgs e)
        {
            //asyncAwait.ReadFromFile();
            MessageBox.Show("Start :");
            //async method call
            example();
            MessageBox.Show("running asnc :");


        }

        public async void example()
        {
            //Create a task
            Task<string> task = new Task<string>(GetCount);
            task.Start();
            //wait for task to be completed
            var str = await task;
            MessageBox.Show("Completed");

        }

        public string GetCount()
        {
            Thread.Sleep(5000);
            return "Blocking call";
        }


        #endregion

        #region Factorial
        private void factorial_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Factorial using non recursive method :" + Factorial.GetFactorial(4));
           // MessageBox.Show("Factorial using recursive method :" + Factorial.GetFactorialRecursive(4));


        }
        #endregion

        #region FindMaxIntegerArray
        private void findMaxIntArray_Click(object sender, EventArgs e)
        {
            var max = FindMaxIntInArray.FindMax();
            MessageBox.Show("max"+ max);
        }
        #endregion

        #region ReverseIntegerContent
        private void ReverseIntArray_Click(object sender, EventArgs e)
        {
           int  [] arr = ReverseIntegerArray.Reverse();
            for(int i=0;i<= arr.Length-1;i++)
            {
                MessageBox.Show("Integer Array" + arr[i]);
            }

        }
        #endregion


        #region Func
        private void Func_Click(object sender, EventArgs e)
        {
            //Function with one input parameter and one return value
            Func<int, string> func = (x) => string.Format("string= {0}", x);

            //Function with two input parameter and one return value
            Func<int,int, string> func1 = (x,y) => string.Format("string= {0} and {1}" , x,y);
            
            //Function that has no parameters
            Func<string> func2 = () => string.Format("Return string ");

            //Call Func
            
            MessageBox.Show("Func with one parameter" + func(1));

           
            MessageBox.Show("Func with two parameter" + func1(1,4));
            
            MessageBox.Show("Func with no parameter" + func2());
        }
        #endregion
    }
}
 