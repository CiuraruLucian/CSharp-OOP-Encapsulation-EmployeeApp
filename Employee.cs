using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    class Employee
    {
        //Field data or the state of the class
        private string empName; // This field is defined using the private  keyword -> not directly accessible from an object variable
        private int empId; // This field is defined using the private  keyword -> not directly accessible from an object variable
        private float currPay;// This field is defined using the private  keyword -> not directly accessible from an object variable

        // Accessor (get method).
        
        public string GetName()
        {
            return empName;
        }

        // Mutator (set method)
        
        public void SetName( string name)
        {
            // Do a check on incoming value
            // before making assignment
            if (name.Length > 15 )
                Console.WriteLine("Error! Name length needs to be less than 15 characters!");
            else
                empName = name;
        }

        
        public int GetId()
        {
            return empId; 
        }

        public void SetId ( int id )
        {
            if ( id > 1000 )
                Console.WriteLine("Error! Our company cannot have more than 1000 employees!");
            else
                empId = id;
        }

        public float GetCurrPay()
        {
            return currPay; 
        }

        public void SetCurrPay (float currPay)
        {
            if ( currPay > 1000000)
                Console.WriteLine("Error! No employee can earn that much in our company!");
            else
                this.currPay = currPay;
        }
        
        //Constructors
        public Employee(){}

        public Employee(string name, int id, float pay)
        {
            empName = name;
            empId = id;
            currPay = pay;
        }

        // Methods
        public void GiveBonus(float amount)
        {
            currPay += amount;
        }

        public void DisplayStats()
        {
            Console.WriteLine("Name: {0}", empName);
            Console.WriteLine("ID: {0}", empId);
            Console.WriteLine("Pay: {0}", currPay);
        }
    }
}
