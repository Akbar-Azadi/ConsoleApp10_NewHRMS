namespace ConsoleApp10
{
    public sealed  class NewEmploy : Human
    {
        /*********** ctor ***********************/

        public NewEmploy(int EmployeeType) : base()
        {
            if (EmployeeType == 0)
            {
                ++countof_usualEmp;
            }
            else
            {
                ++countof_AdminEmp;
            }
        }
        public NewEmploy(int EmpID, string FirstName, string LastName, string NationalCode, byte isActive, int Password, int EmployType , string CreateDate) : base(FirstName, LastName, NationalCode)
        {
            this.EmployeeID = EmpID;
            this.IsActive = isActive;
            this.Password = Password;
            this.EmployeeType = EmployType;
            this.createDate = CreateDate;
            if (EmployType == (int)Actions.EmployeeType.Employees)
            {
                ++countof_usualEmp;
            }
            else
            {
                ++countof_AdminEmp;
            }
        }



        /*********** Field and Properties *******/
        private string createDate;
        public string CreateDate
        {
            get { return createDate; }
            set { createDate = value; }
        }

        private int Emptype;
        public int EmployeeType
        {
            get { return Emptype; }
            set { Emptype = value; }
        }

        public string Status
        {
            get
            {
                if (isActive == (int)Actions.ActivateType.Active)
                {
                    return Actions.ActivateType.Active.ToString();
                }
                else
                {
                    return Actions.ActivateType.Deactive.ToString();
                }
            }
        }

        private int employeeID;
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }

        private static int countof_usualEmp = 0;
        public static int Total_usual_Employee
        {
            get { return countof_usualEmp; }
            set { countof_usualEmp = value; }
        }

        private static int countof_AdminEmp = 0;
        public static int Total_Admin_Employee
        {
            get { return countof_AdminEmp; }
            set { countof_AdminEmp = value; }
        }

        private byte isActive;
        public byte IsActive
        {
            get { return isActive; }
            set { isActive = value; }
        }

        private int password;
        public int Password
        {
            get { return password; }
            set { password = value; }
        }

        public string FullName
        {
            get { return base.FirstName + " " + base.LastName; }
        }

        public string EmployeTypeName
        {
            get
            {
                if (EmployeeType == (int)Actions.EmployeeType.Employees)
                {
                    return Actions.EmployeeType.Employees.ToString();
                }
                else
                {
                    return Actions.EmployeeType.Administrator.ToString();
                }
            }
        }
    }
}
