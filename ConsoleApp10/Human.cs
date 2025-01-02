using System;

namespace ConsoleApp10
{
    public abstract class Human
    {


        /*********** Field and Properties *******/
        private string fName;
        private string lName;
        private string nationalCode;
        public string FirstName
        {
            get { return fName; }
            set { fName = value; }
        }
        public string LastName
        {
            get { return lName; }
            set { lName = value; }
        }
        public string NationalCode
        {
            get { return nationalCode; }
            set
            {
                if (value != null)
                {
                    if (value.Length == 10)
                    {
                        nationalCode = value;
                    }
                    else
                    {
                        throw new Exception("Invalid NationalCode Value");
                    }
                }
            }
        }




        /*********** ctor ***********************/
        //public Human(in int type)
        //{
        //    _ = type;
        //}

        public Human() {}
        public Human(string FirstName, string LastName, string NationalCode)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.NationalCode = NationalCode;
        }
    }
}
