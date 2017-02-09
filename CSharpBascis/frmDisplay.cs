using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Can you store different types in an array ?
        /// Yes . If you create object array.Since all types inherit from object.array.Since all types inherit directly or indirectly from object type.
        /// We can add any types to an array including complex types
        /// For displaying complex types we need to override the ToString() if we want meaningful ouptput when ToString() method is invoked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
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
    }
}
