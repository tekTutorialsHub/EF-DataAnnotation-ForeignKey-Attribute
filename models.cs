using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFForeignKeyAttribute
{



    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }

        public virtual Department Dept { get; set; }
    }



    public class Department
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
    }




    //public class Employee
    //{
    //    public int EmployeeID { get; set; }
    //    public string Name { get; set; }

    //    public int DepartmentID { get; set; }
    //    public virtual Department Dept { get; set; }
    //}



    //public class Department
    //{
    //    public int DepartmentID { get; set; }
    //    public string Name { get; set; }
    //}



        //public class Employee
        //{
        //    public int EmployeeID { get; set; }
        //    public string Name { get; set; }

            
        //    public int DeptID { get; set; }

        //    [ForeignKey("DeptID")]
        //    public virtual Department Dept { get; set; }
        //}



        //public class Department
        //{
        //    public int DepartmentID { get; set; }
        //    public string Name { get; set; }
        //}

}
