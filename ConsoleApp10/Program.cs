using System;
using System.Threading;
using System.Collections.Generic;

namespace ConsoleApp10
{
    class Program
    {
        /************************************** Variable  ****************************************/
        #region Variables
        static List<NewEmploy> NewEmpArr = new List<NewEmploy>();
        #endregion
        /************************************** Methods  *****************************************/
        #region Methods
        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <param name="EmpIDIndex">Employee ID for Delete</param>
        static void DeleteEmployee(int EmpIDIndex)
        {
            NewEmpArr.RemoveAt(EmpIDIndex);
        }
        /// <summary>
        /// Check Exist CodeMeli in System or not
        /// </summary>
        /// <param name="MyCodemeli">String Codemeli</param>
        /// <returns>Return bool ,if exists return true else return false</returns>
        static bool IsNationalCodeExist(string MyCodemeli)
        {
            bool result = false;
            foreach (var item in NewEmpArr)
            {
                if (item.NationalCode.Equals(MyCodemeli))
                {
                    result = true;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// Print Your Text
        /// </summary>
        /// <param name="str">Your String to Print it</param>
        /// <param name="myColor">Print your String with Your Color</param>
        /// 
        static void PrintMessage(string str, ConsoleColor myColor)
        {
            Console.ForegroundColor = myColor;
            Console.WriteLine(str); ;
            Console.ResetColor();
        }
        /// <summary>
        /// Show Total Employee And Admin Acounts Counts
        /// </summary>
        static void ShowStatisticalSummary()
        {
            Console.ResetColor();
            Console.Write("Index\t| EmployeeType\t|\t");
            Console.ForegroundColor = ConsoleColor.Green; Console.Write(Actions.ActivateType.Active);
            Console.ResetColor(); Console.Write("\t|\t");
            Console.ForegroundColor = ConsoleColor.Red; Console.Write(Actions.ActivateType.Deactive);
            Console.ResetColor(); Console.WriteLine("\t|\tTotalCount");
            Separator("-", ConsoleColor.White);
            int ActiveAdmin = 0, DeactiveAdmin = 0, ActiveEmployee = 0, DeactiveEmployee = 0;
            for (int i = 0; i < NewEmpArr.Count; i++)
            {
                if (NewEmpArr[i].EmployeeType == (int)Actions.EmployeeType.Employees)//employee type
                {
                    if (NewEmpArr[i].IsActive == (int)Actions.ActivateType.Active)
                    {
                        ++ActiveEmployee;
                    }
                    else
                    {
                        ++DeactiveEmployee;
                    }
                }
                if (NewEmpArr[i].EmployeeType == (int)Actions.EmployeeType.Administrator)//admin type
                {
                    if (NewEmpArr[i].IsActive == (int)Actions.ActivateType.Active)
                    {
                        ++ActiveAdmin;
                    }
                    else
                    {
                        ++DeactiveAdmin;
                    }
                }
            }
            if (NewEmpArr.Count > 0)
            {
                Console.Write(" 1 \t| ");
                Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black; Console.Write(Actions.EmployeeType.Administrator); Console.ResetColor();
                Console.WriteLine("\t|\t" + ActiveAdmin.ToString() + "\t|\t" + DeactiveAdmin + "\t\t|\t" + (NewEmploy.Total_Admin_Employee).ToString()); Console.ResetColor();
                Console.Write(" 2 \t| ");
                Console.BackgroundColor = ConsoleColor.DarkBlue; Console.Write(Actions.EmployeeType.Employees); Console.ResetColor();
                Console.WriteLine("\t|\t" + ActiveEmployee.ToString() + "\t|\t" + DeactiveEmployee + "\t\t|\t" + (NewEmploy.Total_usual_Employee).ToString());
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("There are no Employee in system !");
            }
        }
        /// <summary>
        /// Print Arrow Shape
        /// </summary>
        static void Arrow()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write(" >>> ");
            Console.ResetColor();
        }
        /// <summary>
        /// Print Your Text
        /// </summary>
        /// <param name="t1">Your String</param>
        /// <param name="MyColor">Your Color to Print Your Text</param>
        static void Title(string t1, ConsoleColor MyColor)
        {
            Console.ForegroundColor = MyColor;
            Console.WriteLine(t1);
            Console.ResetColor();
        }
        /// <summary>
        /// Print Your Text
        /// </summary>
        /// <param name="t1">Your First String To Print</param>
        /// <param name="t2">Your Second String To Print</param>
        /// <param name="MyColor">Your Color to Print Your Text</param>
        static void Title(string t1, string t2, ConsoleColor MyColor)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(t1);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" >>> ");
            Console.ResetColor();
            Console.ForegroundColor = MyColor;
            Console.WriteLine(t2);
            Console.ResetColor();
        }
        /// <summary>
        /// Print Your Text
        /// </summary>
        /// <param name="t1">Your First String To Print</param>
        /// <param name="t2">Your Second String To Print</param>
        /// <param name="t3">Your Third String To Print</param>
        /// <param name="MyColor">Your Color to Print Your Text</param>
        static void Title(string t1, string t2, string t3, ConsoleColor MyColor)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(t1);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" >>> ");
            Console.ResetColor();
            Console.ForegroundColor = MyColor;
            Console.Write(t2);
            Console.ResetColor();
            Arrow();
            Console.ForegroundColor = MyColor;
            Console.WriteLine(t3);
            Console.ResetColor();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="t1">Your First String To Print</param>
        /// <param name="t2">Your Second String To Print</param>
        /// <param name="t3">Your Third String To Print</param>
        /// <param name="t4">Your Forth String To Print</param>
        /// <param name="MyColor">Your Color to Print Your Text</param>
        static void Title(string t1, string t2, string t3, string t4, ConsoleColor MyColor)
        {
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(t1);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(" >>> ");
            Console.ResetColor();
            Console.ForegroundColor = MyColor;
            Console.Write(t2);
            Console.ResetColor();
            Arrow();
            Console.ForegroundColor = MyColor;
            Console.Write(t3);
            Console.ResetColor();
            Arrow();
            Console.ForegroundColor = MyColor;
            Console.WriteLine(t4);
            Console.ResetColor();
        }
        /// <summary>
        /// Search Employee With it's ID
        /// </summary>
        /// <param name="EmployeeID">Your ID to Serarch in List</param>
        /// <param name="IndexOut">Return Index of Finded Employee in List</param>
        /// <returns></returns>
        static bool SerachEmployee(int EmployeeID, out int IndexOut)
        {
            bool result = false;
            IndexOut = -1;
            if (NewEmpArr.Count > 0)
            {
                for (int index = 0; index < NewEmpArr.Count; index++)
                {
                    if (NewEmpArr[index] != null)
                    {
                        if (NewEmpArr[index].EmployeeID == EmployeeID)
                        {
                            result = true;
                            IndexOut = index;
                        }
                    }
                }
            }
            return result;
        }
        /// <summary>
        /// Print "Press Any Key ..."
        /// </summary>
        static void PressAnyKey()
        {
            Console.WriteLine("Press Any key ... ");
            Console.ReadKey();
        }
        /// <summary>
        /// Validate Your String with YourDateType
        /// </summary>
        /// <param name="Str">Your String</param>
        /// <param name="type">Choose Your Data Type Between Digits or Characters</param>
        /// <returns></returns>
        static bool ValidateMyData(string Str, Actions.YourDateType type)
        {
            bool Result = false;
            if (type == Actions.YourDateType.Character)
            {
                if (Str.Contains("1") || Str.Contains("2") || Str.Contains("3") || Str.Contains("4") || Str.Contains("5") || Str.Contains("6") || Str.Contains("7") || Str.Contains("8") || Str.Contains("9"))
                {
                    Result = false;
                }
                else
                {
                    Result = true;
                }
            }
            else
            {
                Int64 temp;
                if (Int64.TryParse(Str, out temp))
                {
                    Result = true;
                }
                else
                {
                    Result = false;
                }
            }
            return Result;
        }
        /// <summary>
        /// Create New Employee with Any Type or Active/Deactive it
        /// </summary>
        static void CreateEmployee(string AccountFullName)
        {
            // get new employee information
            int input;
            while (true)
            {
                Console.Clear();
                Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                Title("You Are Here", "MainMenu", "Show Manage Account", "Create New Account", ConsoleColor.White);
                Separator("=", ConsoleColor.Yellow);
                Console.WriteLine();
                PrintMessage("You want to create New User Account . So Please Compelete Neccessary Field For Action to this.", ConsoleColor.Cyan);
                Console.Write("Please Enter EmployeeType (1---->Admin  \tOR\t0---->Employee) : ");
                input = Convert.ToInt32(Console.ReadLine());
                if (!(input == 0 || input == 1))
                {
                    Console.Clear();
                    PrintMessage("Please Enter Correct Format", ConsoleColor.Red);
                    PressAnyKey();
                    continue;
                }
                else
                {
                    break;
                }
            }
            NewEmploy objNewEmployee = new NewEmploy(input);
            objNewEmployee.EmployeeType = input;
            objNewEmployee.EmployeeID = GetMaxEmployeeID();
            Console.Write("New Employee ID is : ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(objNewEmployee.EmployeeID);
            Console.ResetColor();
            string TempString = null;
            // Validate FirstName 
            do
            {
                Console.Write("Please Enter First Name : ");
                TempString = Console.ReadLine();
                if (!(ValidateMyData(TempString, Actions.YourDateType.Character)))
                {
                    Console.Clear();
                    PrintMessage("Please Enter Correct Format. Your FirstName Must Be Contain Char A to Z.", ConsoleColor.Red);
                    PressAnyKey();
                    Console.Clear();
                    Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                    Title("You Are Here", "MainMenu", "Show Manage Account", "Create New Account", ConsoleColor.White);
                    Separator("=", ConsoleColor.Yellow);
                    Console.WriteLine();
                    PrintMessage("You want to create New User Account . So Please Compelete Neccessary Field For Action to this.", ConsoleColor.Cyan);
                    Console.WriteLine("Type of Employee is : " + objNewEmployee.EmployeTypeName);
                    Console.WriteLine("New Employee ID is : " + objNewEmployee.EmployeeID);
                    continue;
                }
                else
                {
                    objNewEmployee.FirstName = TempString;
                    break;
                }
            } while (true);
            // Validate LastName 
            do
            {
                TempString = null;
                Console.Write("Please Enter Last Name : ");
                TempString = Console.ReadLine();
                if (!(ValidateMyData(TempString, Actions.YourDateType.Character)))
                {
                    Console.Clear();
                    PrintMessage("Please Enter Correct Format. Your LastName Must Be Contain Char A to Z.", ConsoleColor.Red);
                    PressAnyKey();
                    Console.Clear();
                    Title("Wellcome " + AccountFullName + "\t--------- " + TotalEmployee(), ConsoleColor.Yellow);
                    Title("You Are Here", "MainMenu", "Show Manage Account", "Create New Account", ConsoleColor.White);
                    Separator("=", ConsoleColor.Yellow);
                    Console.WriteLine();
                    PrintMessage("You want to create New User Account . So Please Compelete Neccessary Field For Action to this.", ConsoleColor.Cyan);
                    Console.WriteLine("Type of Employee is : " + objNewEmployee.EmployeTypeName);
                    Console.WriteLine("New Employee ID is : " + objNewEmployee.EmployeeID);
                    Console.WriteLine("New Employee FirstName is : " + objNewEmployee.FirstName);
                    continue;
                }
                else
                {
                    objNewEmployee.LastName = TempString;
                    break;
                }
            } while (true);
            // Validate NationalCode
            do
            {
                Console.Write("Please Enter NationalCode : ");
                string input2 = Console.ReadLine();
                if (!(input2.Length == 10 && ValidateMyData(input2, Actions.YourDateType.Digit)))
                {
                    Console.Clear();
                    PrintMessage("Please Enter Correct Format. Your Number Must Be Only 10 Digit Numbers", ConsoleColor.Red);
                    PressAnyKey();
                    Console.Clear();
                    Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                    Title("You Are Here", "MainMenu", "Show Manage Account", "Create New Account", ConsoleColor.White);
                    Separator("=", ConsoleColor.Yellow);
                    Console.WriteLine();
                    PrintMessage("You want to create New User Account . So Please Compelete Neccessary Field For Action to this.", ConsoleColor.Cyan);
                    Console.WriteLine("Type of Employee is : " + objNewEmployee.EmployeTypeName);
                    Console.WriteLine("New Employee ID is : " + objNewEmployee.EmployeeID);
                    Console.WriteLine("New Employee First Name is : " + objNewEmployee.FirstName);
                    Console.WriteLine("New Employee Last Name is : " + objNewEmployee.LastName);
                    continue;
                }
                else
                {
                    if (!(IsNationalCodeExist(input2)))
                    {
                        objNewEmployee.NationalCode = input2;
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        PrintMessage("This NationalCode Exist in HRMS System Database. So Please Another NationalCode", ConsoleColor.Red);
                        PressAnyKey();
                        Console.Clear();
                        Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                        Title("You Are Here", "MainMenu", "Show Manage Account", "Create New Account", ConsoleColor.White);
                        Separator("=", ConsoleColor.Yellow);
                        Console.WriteLine();
                        PrintMessage("You want to create New User Account . So Please Compelete Neccessary Field For Action to this.", ConsoleColor.Cyan);
                        Console.WriteLine("Type of Employee is : " + objNewEmployee.EmployeTypeName);
                        Console.WriteLine("New Employee ID is : " + objNewEmployee.EmployeeID);
                        Console.WriteLine("New Employee First Name is : " + objNewEmployee.FirstName);
                        Console.WriteLine("New Employee Last Name is : " + objNewEmployee.LastName);
                        continue;
                    }
                }
            }
            while (true);
            // Validate Active Employee
            do
            {
                Console.Write("Please Enter ActiveID (1---->Active\tOR\t0---->Deactive) : ");
                string input3 = Console.ReadLine();
                if (!(input3 == ((int)Actions.ActivateType.Deactive).ToString() || input3 == ((int)Actions.ActivateType.Active).ToString()))
                {
                    Console.Clear();
                    PrintMessage("Please Enter Correct Format", ConsoleColor.Red);
                    PressAnyKey();
                    Console.Clear();
                    Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                    Title("You Are Here", "MainMenu", "Show Manage Account", "Create New Account", ConsoleColor.White);
                    Separator("=", ConsoleColor.Yellow);
                    Console.WriteLine();
                    PrintMessage("You want to create New User Account . So Please Compelete Neccessary Field For Action to this.", ConsoleColor.Cyan);
                    Console.WriteLine("Type of Employee is : " + objNewEmployee.EmployeTypeName);
                    Console.WriteLine("New Employee ID is : " + objNewEmployee.EmployeeID);
                    Console.WriteLine("New Employee First Name is : " + objNewEmployee.FirstName);
                    Console.WriteLine("New Employee Last Name is : " + objNewEmployee.LastName);
                    Console.WriteLine("New Employee NationalCode is : " + objNewEmployee.NationalCode);
                    continue;
                }
                else
                {
                    objNewEmployee.IsActive = Convert.ToByte(input3);
                    break;
                }
            }
            while (true);
            //insert Date Today
            objNewEmployee.CreateDate = DateTime.Now.ToShortDateString();
            //Default Password
            objNewEmployee.Password = 1111;
            Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
            //set new admin to array admin
            Console.WriteLine("Thanks For Complete Required Filed ");
            Console.Write("System Try to Create New Employee Account");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < 6; i++)
            {
                Thread.Sleep(250);
                Console.Write(".");
            }
            Console.ResetColor();
            NewEmpArr.Add(objNewEmployee);
            Console.WriteLine();
            PrintMessage("New Employee is Created.", ConsoleColor.Green);
            PressAnyKey();
            Console.Clear();
        }
        /// <summary>
        /// Edit Employee Name And Family with New value
        /// </summary>
        /// <param name="EmployeeID">EmployeeID to Search it</param>
        /// <param name="NewName">Your New value for FirstName</param>
        /// <param name="NewFamily">Your New value for LastName</param>
        /// <exception cref="Exception">Throw New Exceptin When Employee is not Found.</exception>
        static void EditInfoEmploy(int EmployeeID, string NewName, string NewFamily)
        {
            int index;
            if (SerachEmployee(EmployeeID, out index))
            {
                NewEmpArr[index].FirstName = NewName;
                NewEmpArr[index].LastName = NewFamily;
            }
            else
            {
                throw new Exception("Connot Find Employee.");
            }
        }
        /// <summary>
        /// Deactive Employee
        /// </summary>
        /// <param name="UserAccountID">Employee ID for Disable it</param>
        /// <returns></returns>
        /// <exception cref="Exception">Throw New Exceptin When Employee is not Found or Employee was Disable.</exception>
        static bool Deactive_user_Account(int UserAccountID)
        {
            bool result = false;
            int index;
            if (SerachEmployee(UserAccountID, out index))
            {
                if (NewEmpArr[index].IsActive == (int)Actions.ActivateType.Active)
                {
                    NewEmpArr[index].IsActive = (int)Actions.ActivateType.Deactive;
                    result = true;
                }
                else
                {
                    throw new Exception("The Employee is Disable Now. You can Disable Active Employees.");
                }
            }
            else
            {
                throw new Exception("Cannot Find Any Item.");
            }
            return result;
        }
        /// <summary>
        /// Active Employee
        /// </summary>
        /// <param name="UserAccountID">Employee ID for Enable it</param>
        /// <returns></returns>
        /// <exception cref="Exception">Throw New Exceptin When Employee is not Found or Employee was Enable.</exception>
        static bool Active_user_Account(int UserAccountID)
        {
            bool result = false;
            int index;
            if (SerachEmployee(UserAccountID, out index))
            {
                if (NewEmpArr[index].IsActive == (int)Actions.ActivateType.Deactive)
                {
                    NewEmpArr[index].IsActive = (int)Actions.ActivateType.Active;
                    result = true;
                }
                else
                {
                    throw new Exception("The Employee is Enbale Now. You can Enable Deactive Employees.");
                }
            }
            else
            {
                throw new Exception("Cannot Find Any Item.");
            }
            return result;
        }
        /// <summary>
        /// Chack UserName and Password to login 
        /// </summary>
        /// <param name="EmployeeID">Employee ID (UserName)</param>
        /// <param name="Password">Employee Password</param>
        /// <param name="FullName">Return FirstName And LastNAme Founded Item .</param>
        /// <param name="Accounttype">Return Account Type of Founded Employee</param>
        /// <exception cref="Exception">Throw New Exception When Account is Disable or UserName - Password is Invalid .</exception>
        static void CheckUserNameAndPassword(int EmployeeID, int Password, out string FullName, out int Accounttype)
        {
            int index;
            FullName = null;
            Accounttype = -1;
            if (SerachEmployee(EmployeeID, out index))
            {
                if (NewEmpArr[index].IsActive == (int)Actions.ActivateType.Deactive)
                {
                    throw new Exception("Your Account is Disable. Please Call System Manager.");
                }
                if (NewEmpArr[index].Password == Password)
                {
                    FullName = NewEmpArr[index].FullName;
                    Accounttype = NewEmpArr[index].EmployeeType;
                }
                else
                {
                    throw new Exception("Password is invalid. Please Try again.");
                }
            }
            else
            {
                throw new Exception("Connot Find Any Item.");
            }
        }
        /// <summary>
        /// Show Total Member Account (Employees with Specifications)
        /// </summary>
        static void ShowTotalAccount()
        {
            int Index = 0;
            Console.WriteLine(" Index  | AccountType\t| ID\t| AccountName \t\t| NationalCode  | Pass\t| Status\t| Create Date");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
            if (NewEmpArr.Count > 0)
            {
                for (int i = 0; i < NewEmpArr.Count; i++)
                {
                    if (NewEmpArr[i] != null)
                    {
                        Console.Write(" " + (++Index) + "\t| ");
                        if (NewEmpArr[i].FullName.Length <= 13)
                        {
                            if (NewEmpArr[i].EmployeeType == (int)Actions.EmployeeType.Employees)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.Write(NewEmpArr[i].EmployeTypeName);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(NewEmpArr[i].EmployeTypeName);
                                Console.ResetColor();
                            }
                            Console.Write("\t| " + NewEmpArr[i].EmployeeID.ToString() + "\t| " + NewEmpArr[i].FullName + "\t\t| " + NewEmpArr[i].NationalCode + "\t| " + NewEmpArr[i].Password + "\t| ");
                            if (NewEmpArr[i].IsActive == (int)Actions.ActivateType.Active)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            Console.Write(NewEmpArr[i].Status); Console.ResetColor();
                            Console.WriteLine("\t| " + NewEmpArr[i].CreateDate);
                            Console.ResetColor();
                        }
                        else
                        {
                            if (NewEmpArr[i].EmployeeType == (int)Actions.EmployeeType.Employees)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkBlue;
                                Console.Write(NewEmpArr[i].EmployeTypeName);
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.BackgroundColor = ConsoleColor.DarkYellow;
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(NewEmpArr[i].EmployeTypeName);
                                Console.ResetColor();
                            }
                            Console.Write("\t| " + NewEmpArr[i].EmployeeID.ToString() + "\t| " + NewEmpArr[i].FullName + "\t| " + NewEmpArr[i].NationalCode + "\t| " + NewEmpArr[i].Password + "\t| ");
                            if (NewEmpArr[i].IsActive == (int)Actions.ActivateType.Active)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            Console.Write(NewEmpArr[i].Status); Console.ResetColor();
                            Console.WriteLine("\t| " + NewEmpArr[i].CreateDate);
                            Console.ResetColor();
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no Employee in system !");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Show Unique Member Account (Employees with Specifications)
        /// </summary>
        static void ShowUniqueAccount(int EmployeeID)
        {
            Console.WriteLine();
            Console.WriteLine(" UserAccountType | ID\t| AccountName \t\t| NationalCode  | Pass\t | Create Date");
            Separator("=", ConsoleColor.White);
            Console.WriteLine();
            int index;
            if (SerachEmployee(EmployeeID, out index))
            {
                if (NewEmpArr[index].FullName.Length <= 13)
                {
                    Console.Write(NewEmpArr[index].EmployeTypeName + "\t\t| " + NewEmpArr[index].EmployeeID.ToString() + "\t| " + NewEmpArr[index].FullName + "\t\t|" + NewEmpArr[index].NationalCode + "\t|" + NewEmpArr[index].Password + "\t|" + NewEmpArr[index].CreateDate);
                }
                else
                {
                    Console.Write(NewEmpArr[index].EmployeTypeName + "\t\t|" + NewEmpArr[index].EmployeeID.ToString() + "\t| " + NewEmpArr[index].FullName + "\t|" + NewEmpArr[index].NationalCode + "\t|" + NewEmpArr[index].Password + "\t|" + NewEmpArr[index].CreateDate);
                }
            }
            else
            {
                throw new Exception("There Are No Employee Items To Show !");
            }
        }
        /// <summary>
        /// Get Last Index of List For Insert New Employee
        /// </summary>
        /// <returns>Return Last Index of List</returns>
        static int GetMaxEmployeeID()
        {
            int maxnumber = -1;
            for (int i = 0; i < NewEmpArr.Count; i++)
            {
                if (NewEmpArr[i] != null)
                {
                    if (maxnumber < NewEmpArr[i].EmployeeID)
                    {
                        maxnumber = NewEmpArr[i].EmployeeID;
                    }
                }
            }
            return ++maxnumber;
        }
        static void Admin_ManagePasswordMenu()
        {
            Console.WriteLine();
            Console.Write("1- Change Password (User Defined "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[Low Security] "); Console.ResetColor(); Console.WriteLine(")");
            Console.Write("2- Reset  Password (System Defined "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("[High Security] "); Console.ResetColor(); Console.WriteLine(")");
            Console.WriteLine("0- Back to Menu");
        }
        /// <summary>
        /// Create And Return 4 Digits Number to Set New password for Employee
        /// </summary>
        /// <returns>Return 4 Digit Number when All Digits is Uniqe</returns>
        static int SystemDefinePassword()
        {
            string Result = String.Empty;
            Random rnd = new Random();
            string temp = String.Empty;
            while (true)
            {
                temp = rnd.Next(1, 9).ToString();
                if (Result.Length == 4)
                {
                    break;
                }
                if (!Result.Contains(temp))
                {
                    Result += temp.ToString();
                    continue;
                }
            }
            return Convert.ToInt32(Result);
        }
        /// <summary>
        /// Intiolizing System to Correctly Execute For First Run
        /// </summary>
        static void Intiolizing()
        {
            /*******************/
            //defult value for run corecctly program
            NewEmploy objMng = new NewEmploy(1000, "Alire", "Borojer", "1234567890", 1, 1111, 1, "09/05/2024");//username(ManageID) is : 1000
            NewEmpArr.Add(objMng);
            NewEmploy objMng1 = new NewEmploy(1001, "Amin", "ghorbani", "0015682345", 1, 2222, 0, "12/01/2000");// (EmployeeID) is : : 1001
            NewEmpArr.Add(objMng1);
            NewEmploy objEmp = new NewEmploy(1002, "Davod", "mohamadi", "1231231230", 1, 1111, 0, "01/15/2023");// (EmployeeID) is : 1002
            NewEmpArr.Add(objEmp);
            NewEmploy objEmp2 = new NewEmploy(1003, "reza", "amini", "4488779955", 1, 5678, 0, "11/17/2021");// (EmployeeID) is : 1003
            NewEmpArr.Add(objEmp2);
            NewEmploy objEmp3 = new NewEmploy(1004, "Rozha", "Elhami", "6593241562", 0, 5555, 0, "06/30/2022");// (EmployeeID) is : 1004
            NewEmpArr.Add(objEmp3);
            NewEmploy objEmp4 = new NewEmploy(1005, "Sara", "Bayat", "5965745120", 1, 8524, 0, "09/14/2020");// (EmployeeID) is : 1005
            NewEmpArr.Add(objEmp4);
            /******************/
        }
        /// <summary>
        /// Change Employee Password
        /// </summary>
        /// <param name="EmployeeID">Employee ID For Search it</param>
        /// <param name="NewPassword">New password to change with Old Password</param>
        /// <exception cref="Exception">throw New Exception When Employee id not Found.</exception>
        static void ChangePassword(int EmployeeID, int NewPassword)
        {
            int index;
            if (SerachEmployee(EmployeeID, out index))
            {
                NewEmpArr[index].Password = NewPassword;
            }
            else
            {
                throw new Exception("Connot Find Any Item.");
            }
        }
        static void Separator(String Template, ConsoleColor w)
        {
            Console.ForegroundColor = w;
            for (int i = 0; i < 113; i++)
            {
                Console.Write(Template);
            }
            Console.WriteLine();
            Console.ResetColor();
        }
        /// <summary>
        /// Return Total of Employees
        /// </summary>
        /// <returns>Return Total of Employees with String Format</returns>
        static string TotalEmployee()
        {
            return $"Count of {Actions.EmployeeType.Administrator}({NewEmploy.Total_Admin_Employee})\tAND\tCount of {Actions.EmployeeType.Employees}({NewEmploy.Total_usual_Employee})";
        }
        #endregion
        /************************************** Main Method  *************************************/
        #region Main
        static void Main(string[] args)
        {
            Intiolizing();
            while (true)
            {
                Console.Clear();
                Title("HRMS Application.", ConsoleColor.Yellow);
                Separator("=", ConsoleColor.Yellow);
                Console.WriteLine();
                Console.WriteLine("1- Login");
                Console.WriteLine("2- Application MAP");
                Console.WriteLine("3- Exit ");
                Console.WriteLine();
                Console.Write("Please Enter Your choose : ");
                int input = Convert.ToInt32(Console.ReadLine());
                //input cheking
                if (!(input == 1 || input == 2 || input == 3))
                {
                    Console.Clear();
                    PrintMessage("Please Enter Correct Number of Menu item Number.", ConsoleColor.Red);
                    PressAnyKey();
                    continue;
                }
                //login Page 
                if (input == 1)
                {
                    Console.Clear();
                    Title("HRMS Application.\tLogin Page", ConsoleColor.Yellow);
                    Separator("=", ConsoleColor.Yellow);
                    Console.WriteLine();
                    Console.Write("Please Enter UserName : ");
                    int input_username = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Please Enter Password : ");
                    int inpu_password = Convert.ToInt32(Console.ReadLine());
                    //check username and password
                    string AccountFullName;
                    int Accounttype;
                    try
                    {
                        CheckUserNameAndPassword(input_username, inpu_password, out AccountFullName, out Accounttype);
                        if (Accounttype == (int)Actions.EmployeeType.Administrator)//Admin
                        {
                            while (true)
                            {
                                Console.Clear();
                                Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                Title("You Are Here", "MainMenu", ConsoleColor.White);
                                Separator("=", ConsoleColor.Yellow);
                                Console.WriteLine();
                                Console.WriteLine("1- Manage Accounts");
                                Console.WriteLine("2- Manage Password For User Account");
                                Console.WriteLine("3- Log out");
                                Console.WriteLine();
                                Console.Write("Please Enter Your Choose : ");
                                int input2 = Convert.ToInt32(Console.ReadLine());
                                if (!(input2 == 1 || input2 == 2 || input2 == 3))
                                {
                                    Console.Clear();
                                    PrintMessage("Please Enter Correct Format Number.", ConsoleColor.Red);
                                    PressAnyKey();
                                    continue;
                                }
                                //choose user item
                                switch (input2)
                                {
                                    //Show manage Account
                                    case 1:
                                        while (true)
                                        {
                                            Console.Clear();
                                            Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                            Title("You Are Here", "MainMenu", "Show Manage Account", ConsoleColor.White);
                                            Separator("=", ConsoleColor.Yellow);
                                            Console.WriteLine();
                                            Console.WriteLine("1- Show Total User Account");
                                            Console.WriteLine("2- Create New User Account");
                                            Console.WriteLine("3- Disable User Account");
                                            Console.WriteLine("4- Enable User Account");
                                            Console.WriteLine("5- Edit User Account Information");
                                            Console.WriteLine("6- Change Employee Type");
                                            Console.WriteLine("7- Statistical Summary of Employees");
                                            Console.WriteLine("8- Delete Employee");
                                            Console.WriteLine("0- Back");
                                            Console.WriteLine();
                                            Console.Write("Please Enter Your Choose : ");
                                            int input3 = Convert.ToInt32(Console.ReadLine());
                                            //chech input format
                                            if (!(input3 == 1 || input3 == 2 || input3 == 3 || input3 == 4 || input3 == 5 || input3 == 6 || input3 == 7 || input3 == 8 || input3 == 0))
                                            {
                                                Console.Clear();
                                                PrintMessage("Please Enter Correct Format Number.", ConsoleColor.Red);
                                                PressAnyKey();
                                                continue;
                                            }
                                            //Show Total Account
                                            if (input3 == 1)
                                            {
                                                while (true)
                                                {
                                                    Console.Clear();
                                                    Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                    Title("You Are Here", "MainMenu", "Show Manage Account", "Show Total Account", ConsoleColor.White);
                                                    Separator("=", ConsoleColor.Yellow);
                                                    Console.WriteLine();
                                                    ShowTotalAccount();
                                                    Console.WriteLine(); Console.WriteLine();
                                                    PressAnyKey();
                                                    break;
                                                }
                                            }
                                            //Create new Account
                                            if (input3 == 2)
                                            {
                                                while (true)
                                                {
                                                    try
                                                    {
                                                        Console.Clear();
                                                        Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                        Title("You Are Here", "MainMenu", "Show Manage Account", "Create New Employee", ConsoleColor.White);
                                                        Separator("=", ConsoleColor.Yellow);
                                                        Console.WriteLine();
                                                        Console.Write("Are You Ready to Create New Employee ? (y or n)");
                                                        string temp = Console.ReadLine();
                                                        if (temp == "n" || temp == "N")
                                                        {
                                                            break;
                                                        }
                                                        else if (temp == "y" || temp == "Y")
                                                        {
                                                            CreateEmployee(AccountFullName);
                                                            Console.Clear();
                                                            Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                            Title("You Are Here", "MainMenu", "Show Manage Account", "Create New Employee", ConsoleColor.White);
                                                            Separator("=", ConsoleColor.Yellow);
                                                            Console.WriteLine();
                                                            ShowTotalAccount();
                                                            Console.WriteLine(); Console.WriteLine();
                                                            PressAnyKey();
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            throw new Exception("Please Enter Correct Format.");
                                                        }
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.Clear();
                                                        PrintMessage(e.Message, ConsoleColor.Red);
                                                        PressAnyKey();
                                                        break;
                                                    }
                                                }
                                                continue;
                                            }
                                            //Disable User Account
                                            if (input3 == 3)
                                            {
                                                Console.Clear();
                                                Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                Title("You Are Here", "MainMenu", "Show Manage Account", "Disable User Account", ConsoleColor.White);
                                                Separator("=", ConsoleColor.Yellow);
                                                Console.WriteLine();
                                                ShowTotalAccount();
                                                Console.WriteLine();
                                                Console.Write("Please Enter Employee ID to Disable it. (or 0 to Back to Menu) ");
                                                while (true)
                                                {
                                                    string input10 = Console.ReadLine();
                                                    if (input10 == "0")
                                                    {
                                                        break;
                                                    }
                                                    if (input10 == "1000")
                                                    {
                                                        Console.Clear();
                                                        PrintMessage("Default User Admin Cannot Disable For EveryTime. Please Choose Another Account.", ConsoleColor.Red);
                                                        PressAnyKey();
                                                        continue;
                                                    }
                                                    try
                                                    {
                                                        if (Deactive_user_Account(Convert.ToInt32(input10)))
                                                        {
                                                            Console.Clear();
                                                            PrintMessage("Employee ID " + input10 + " is Disabled.", ConsoleColor.Green);
                                                            PressAnyKey();
                                                            Console.Clear();
                                                            Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                            Title("You Are Here", "MainMenu", "Show Manage Account", "Disable User Account", ConsoleColor.White);
                                                            Separator("=", ConsoleColor.Yellow);
                                                            Console.WriteLine();
                                                            ShowTotalAccount();
                                                            PressAnyKey();
                                                            break;
                                                        }
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.Clear();
                                                        PrintMessage(e.Message, ConsoleColor.Red);
                                                        PressAnyKey();
                                                        break;
                                                    }
                                                }
                                            }
                                            //Enable user Account
                                            if (input3 == 4)
                                            {
                                                Console.Clear();
                                                Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                Title("You Are Here", "MainMenu", "Show Manage Account", "Enable User Account", ConsoleColor.White);
                                                Separator("=", ConsoleColor.Yellow);
                                                Console.WriteLine();
                                                ShowTotalAccount();
                                                Console.WriteLine();
                                                Console.Write("Please Enter Employee ID to Enable it. (or 0 to Back to Menu) ");
                                                try
                                                {
                                                    while (true)
                                                    {
                                                        int input10 = Convert.ToInt32(Console.ReadLine());
                                                        if (input10 == 0)
                                                        {
                                                            break;
                                                        }
                                                        if (Active_user_Account(Convert.ToInt32(input10)))
                                                        {
                                                            Console.Clear();
                                                            PrintMessage("Enable User Account Successfully.", ConsoleColor.Green);
                                                            PressAnyKey();
                                                            Console.Clear();
                                                            Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                            Title("You Are Here", "MainMenu", "Show Manage Account", "Enable User Account", ConsoleColor.White);
                                                            Separator("=", ConsoleColor.Yellow);
                                                            Console.WriteLine();
                                                            ShowTotalAccount();
                                                            PressAnyKey();
                                                            break;
                                                        }
                                                    }
                                                }
                                                catch (Exception e)
                                                {
                                                    Console.Clear();
                                                    PrintMessage(e.Message, ConsoleColor.Red);
                                                    PressAnyKey();
                                                    continue;
                                                }
                                            }
                                            //Edit Employ 
                                            if (input3 == 5)
                                            {
                                                Console.Clear();
                                                Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                Title("You Are Here", "MainMenu", "Show Manage Account", "Edit Information", ConsoleColor.White);
                                                Separator("=", ConsoleColor.Yellow);
                                                Console.WriteLine();
                                                ShowTotalAccount();
                                                Console.WriteLine();
                                                Console.Write("Please Enter Employee ID to Edit the Information. (or 0 to Back to Menu) ");
                                                while (true)
                                                {
                                                    try
                                                    {
                                                        int input10 = Convert.ToInt32(Console.ReadLine());
                                                        if (input10 == 0)
                                                        {
                                                            break;
                                                        }
                                                        int index;
                                                        if (!SerachEmployee(input10, out index))
                                                        {
                                                            Console.Clear();
                                                            PrintMessage("Connot Find Any Item. Please Try Again...", ConsoleColor.Red);
                                                            PressAnyKey();
                                                            break;
                                                        }
                                                        Console.Clear();
                                                        Console.Write("Do You Want to Edit Name and Family for Employee ID : " + input10 + " ? (y or n)");
                                                        string temp = Console.ReadLine();
                                                        if (temp == "y" || temp == "Y")
                                                        {
                                                            string NewFirstName;
                                                            do
                                                            {
                                                                Console.Clear();
                                                                Console.Write("Please Enter First Name : ");
                                                                NewFirstName = Console.ReadLine();
                                                                if (!(ValidateMyData(NewFirstName, Actions.YourDateType.Character)))
                                                                {
                                                                    Console.Clear();
                                                                    PrintMessage("Please Enter Correct Format. Your FirstName Must Be Contain Char A to Z.", ConsoleColor.Red);
                                                                    PressAnyKey();
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    break;
                                                                }
                                                            } while (true);
                                                            // Validate LastName 
                                                            string NewLastName;
                                                            do
                                                            {
                                                                Console.Clear();
                                                                NewLastName = null;
                                                                Console.Write("Please Enter Last Name : ");
                                                                NewLastName = Console.ReadLine();
                                                                if (!(ValidateMyData(NewLastName, Actions.YourDateType.Character)))
                                                                {
                                                                    Console.Clear();
                                                                    PrintMessage("Please Enter Correct Format. Your FirstName Must Be Contain Char A to Z.", ConsoleColor.Red);
                                                                    PressAnyKey();
                                                                    continue;
                                                                }
                                                                else
                                                                {
                                                                    break;
                                                                }
                                                            } while (true);
                                                            EditInfoEmploy(Convert.ToInt32(input10), NewFirstName, NewLastName);
                                                            Console.Clear();
                                                            PrintMessage("The New FirstName and New LastName is Successfully Changed.", ConsoleColor.Green);
                                                            PressAnyKey();
                                                            Console.Clear();
                                                            ShowTotalAccount();
                                                            PressAnyKey();
                                                            break;
                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.Clear();
                                                        PrintMessage(e.Message, ConsoleColor.Red);
                                                        PressAnyKey();
                                                        continue;
                                                    }
                                                }
                                            }
                                            //Change Employee Type
                                            if (input3 == 6)
                                            {
                                                Console.Clear();
                                                Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                Title("You Are Here", "MainMenu", "Show Manage Account", "Change Employee Type", ConsoleColor.White);
                                                Separator("=", ConsoleColor.Yellow);
                                                Console.WriteLine();
                                                ShowTotalAccount();
                                                Console.WriteLine();
                                                Console.Write("Please Enter Employee ID to Change EmployType. (or 0 to Back to Menu) ");
                                                while (true)
                                                {
                                                    try
                                                    {
                                                        int input10 = Convert.ToInt32(Console.ReadLine());
                                                        if (input10 == 0)
                                                        {
                                                            break;
                                                        }
                                                        int index;
                                                        if (!SerachEmployee(input10, out index))
                                                        {
                                                            Console.Clear();
                                                            PrintMessage("Connot Find Any Item. Please Try Again...", ConsoleColor.Red);
                                                            PressAnyKey();
                                                            break;
                                                        }
                                                        Console.Clear();
                                                        PrintMessage("The Type of Employee ID " + NewEmpArr[index].EmployeeID + " is ===>\t" + NewEmpArr[index].EmployeTypeName, ConsoleColor.Cyan);
                                                        Console.WriteLine();
                                                        Console.Write("Do You Want to Change this Employee Type to Another Type ? (y or n)");
                                                        string input50 = Console.ReadLine();
                                                        if (input50 == "y" || input50 == "Y")
                                                        {
                                                            if (NewEmpArr[index].EmployeeType == (int)Actions.EmployeeType.Employees)//type employee
                                                            {
                                                                NewEmpArr[index].EmployeeType = (int)Actions.EmployeeType.Administrator;//type admin
                                                                ++NewEmploy.Total_Admin_Employee;//increase count admin
                                                                --NewEmploy.Total_usual_Employee;//decrease count employ
                                                            }
                                                            else
                                                            {
                                                                NewEmpArr[index].EmployeeType = (int)Actions.EmployeeType.Employees;//type employee
                                                                --NewEmploy.Total_Admin_Employee;//decrease count admin
                                                                ++NewEmploy.Total_usual_Employee;//increase count employ
                                                            }

                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                        PrintMessage("The Type Employee is Successfully Change.", ConsoleColor.Green);
                                                        PressAnyKey();
                                                        Console.Clear();
                                                        ShowTotalAccount();
                                                        PressAnyKey();
                                                        break;
                                                    }

                                                    catch (Exception e)
                                                    {
                                                        Console.Clear();
                                                        PrintMessage(e.Message, ConsoleColor.Red);
                                                        PressAnyKey();
                                                        continue;
                                                    }
                                                }
                                            }
                                            //Statistical Summary
                                            if (input3 == 7)
                                            {
                                                Console.Clear();
                                                Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                Title("You Are Here", "MainMenu", "Show Manage Account", "Statistical Summary", ConsoleColor.White);
                                                Separator("=", ConsoleColor.Yellow);
                                                Console.WriteLine();
                                                Console.ForegroundColor = ConsoleColor.Yellow;
                                                Console.Write("Please Wait ");
                                                for (int i = 0; i < 6; i++)
                                                {
                                                    Thread.Sleep(300);
                                                    Console.Write(".");
                                                }
                                                Console.Clear();
                                                Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                Title("You Are Here", "MainMenu", "Show Manage Account", "Statistical Summary", ConsoleColor.White);
                                                Separator("=", ConsoleColor.Yellow);
                                                Console.WriteLine();
                                                ShowStatisticalSummary();
                                                Console.WriteLine();
                                                PressAnyKey();
                                            }
                                            if (input3 == 8)
                                            {
                                                Console.Clear();
                                                Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                Title("You Are Here", "MainMenu", "Show Manage Account", "Delete Employee", ConsoleColor.White);
                                                Separator("=", ConsoleColor.Yellow);
                                                Console.WriteLine();
                                                ShowTotalAccount();
                                                Console.WriteLine();
                                                Console.Write("Please Enter Employee ID to Delete it. (or 0 to Back to Menu) ");
                                                while (true)
                                                {
                                                    try
                                                    {
                                                        int input10 = Convert.ToInt32(Console.ReadLine());
                                                        if (input10 == 0)
                                                        {
                                                            break;
                                                        }
                                                        if(input10 == input_username) 
                                                        {
                                                            Console.Clear();
                                                            PrintMessage("Connot Delete This Employee Because this is login Now. Please Enter Another Employee...", ConsoleColor.Red);
                                                            PressAnyKey();
                                                            break;
                                                        }
                                                        int index;
                                                        if (!SerachEmployee(input10, out index))
                                                        {
                                                            Console.Clear();
                                                            PrintMessage("Connot Find Any Item. Please Try Again...", ConsoleColor.Red);
                                                            PressAnyKey();
                                                            break;
                                                        }
                                                        Console.Clear();
                                                        PrintMessage("The Type of Employee ID " + NewEmpArr[index].EmployeeID + " is ===>\t" + NewEmpArr[index].EmployeTypeName, ConsoleColor.Cyan);
                                                        Console.WriteLine();
                                                        Console.Write("Do You Want to Delete this Employee ? (y or n)");
                                                        string input50 = Console.ReadLine();
                                                        if (input50 == "y" || input50 == "Y")
                                                        {
                                                            DeleteEmployee(index);
                                                        }
                                                        else
                                                        {
                                                            break;
                                                        }
                                                        PrintMessage("The Employee is Successfully Deleted.", ConsoleColor.Green);
                                                        PressAnyKey();
                                                        Console.Clear();
                                                        Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                        Title("You Are Here", "MainMenu", "Show Manage Account", "Delete Employee", ConsoleColor.White);
                                                        Separator("=", ConsoleColor.Yellow);
                                                        Console.WriteLine();
                                                        ShowTotalAccount();
                                                        PressAnyKey();
                                                        break;
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        Console.Clear();
                                                        PrintMessage(e.Message, ConsoleColor.Red);
                                                        PressAnyKey();
                                                        continue;
                                                    }
                                                }
                                            }
                                            //back to menu
                                            if (input3 == 0)
                                            {
                                                break;
                                            }
                                        }
                                        break;
                                    //show Password menu
                                    case 2:
                                        while (true)
                                        {
                                            Console.Clear();
                                            Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                            Title("You Are Here", "MainMenu", "Show Password Menu", ConsoleColor.White);
                                            Separator("=", ConsoleColor.Yellow);
                                            Console.WriteLine();
                                            ShowTotalAccount();
                                            Console.WriteLine();
                                            Console.Write("Please Enter Employee ID to Change Password: (or 0 to Back TO Menu) ");
                                            int input_AccountNumber = Convert.ToInt32(Console.ReadLine());
                                            if (input_AccountNumber == 0)
                                            {
                                                break;
                                            }
                                            int index;
                                            if (!SerachEmployee(input_AccountNumber, out index))
                                            {
                                                Console.Clear();
                                                PrintMessage("Connot Find Any Item. Please Try Again...", ConsoleColor.Red);
                                                PressAnyKey();
                                                continue;
                                            }
                                            while (true)
                                            {
                                                Console.Clear();
                                                Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                                Title("You Are Here", "MainMenu", "Change Password", ConsoleColor.White);
                                                Separator("=", ConsoleColor.Yellow);
                                                Console.WriteLine();
                                                Admin_ManagePasswordMenu();
                                                Console.Write("Please Enter Your Choose : ");
                                                int input_typePassword = Convert.ToInt32(Console.ReadLine());
                                                if (!(input_typePassword == 1 || input_typePassword == 2 || input_typePassword == 0))
                                                {
                                                    Console.Clear();
                                                    PrintMessage("Please Enter Correct Format Number.", ConsoleColor.Red);
                                                    PressAnyKey();
                                                    continue;
                                                }
                                                //change password by user
                                                if (input_typePassword == 1)
                                                {
                                                    string pass1 = "";
                                                    string pass2 = "";
                                                    while (true)
                                                    {
                                                        try
                                                        {
                                                            Console.Clear();
                                                            Console.Write("Please Enter New Password (4 Digit): ");
                                                            pass1 = Console.ReadLine();
                                                            Console.Write("Please reEnter your Password (4 Digit): ");
                                                            pass2 = Console.ReadLine();
                                                            if (pass1 == pass2 && pass1.Length == 4)
                                                            {
                                                                try
                                                                {
                                                                    ChangePassword(input_AccountNumber, Convert.ToInt32(pass1));
                                                                    PrintMessage("Password Successfully Chenged.", ConsoleColor.Green);
                                                                    PressAnyKey();
                                                                    break;
                                                                }
                                                                catch (Exception e)
                                                                {
                                                                    Console.Clear();
                                                                    PrintMessage(e.Message, ConsoleColor.Red);
                                                                    PressAnyKey();
                                                                    break;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                Console.Clear();
                                                                PrintMessage("Password Not Equal or Lenght of Password les than 4 digit. Please Try Again", ConsoleColor.Red);
                                                                PressAnyKey();
                                                                continue;
                                                            }
                                                        }
                                                        catch
                                                        {
                                                            Console.Clear();
                                                            PrintMessage("Error During Change Password. Please Try again.", ConsoleColor.Red);
                                                            PressAnyKey();
                                                            break;
                                                        }
                                                    }
                                                }
                                                //change password by system
                                                if (input_typePassword == 2)
                                                {
                                                    try
                                                    {
                                                        int temp = SystemDefinePassword();
                                                        ChangePassword(input_AccountNumber, temp);
                                                        PrintMessage("Password Successfully Chenged By System.", ConsoleColor.Green);
                                                        PrintMessage("The New Password is : " + temp, ConsoleColor.White);
                                                        PressAnyKey();
                                                        break;
                                                    }
                                                    catch (Exception e)
                                                    {
                                                        PrintMessage(e.Message, ConsoleColor.Red);
                                                        PressAnyKey();
                                                        continue;
                                                    }
                                                }
                                                //Back to Menu
                                                if (input_typePassword == 0)
                                                {
                                                    break;
                                                }
                                            }
                                        }
                                        break;
                                }
                                //log out
                                if (input2 == 3)
                                {
                                    break;
                                }
                                continue;
                            }
                        }
                        else if (Accounttype == (int)Actions.EmployeeType.Employees)
                        {
                            while (true)
                            {
                                Console.Clear();
                                Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                Title("You Are Here", "MainMenu", ConsoleColor.White);
                                Separator("=", ConsoleColor.Yellow);
                                Console.WriteLine("1- Show your information");
                                Console.WriteLine("2- Change your Password");
                                Console.WriteLine("0- Log out");
                                Console.WriteLine();
                                Console.Write("Please Enter Your Choose : ");
                                int input_userAccount = Convert.ToInt32(Console.ReadLine());
                                if (input_userAccount == 0)
                                {
                                    break;
                                }
                                //Show Employee Information
                                if (input_userAccount == 1)
                                {
                                    Console.Clear();
                                    Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                    Title("You Are Here", "MainMenu", "Show Employee Information", ConsoleColor.White);
                                    Separator("=", ConsoleColor.Yellow);
                                    ShowUniqueAccount(input_username);
                                    Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine(); Console.WriteLine();
                                    PressAnyKey();
                                }
                                //Change Password
                                if (input_userAccount == 2)
                                {
                                    while (true)
                                    {
                                        Console.Clear();
                                        Title("Wellcome " + AccountFullName + "\t---------  " + TotalEmployee(), ConsoleColor.Yellow);
                                        Title("You Are Here", "MainMenu", "Change Password", ConsoleColor.White);
                                        Separator("=", ConsoleColor.Yellow);
                                        Console.WriteLine();
                                        Admin_ManagePasswordMenu();
                                        Console.Write("Please Enter Your Choose : ");
                                        int input_typePassword = Convert.ToInt32(Console.ReadLine());
                                        if (!(input_typePassword == 1 || input_typePassword == 2 || input_typePassword == 0))
                                        {
                                            Console.Clear();
                                            PrintMessage("Please Enter Correct Format Number.", ConsoleColor.Red);
                                            PressAnyKey();
                                            continue;
                                        }
                                        //change password by user
                                        if (input_typePassword == 1)
                                        {
                                            string pass1 = "";
                                            string pass2 = "";
                                            while (true)
                                            {
                                                try
                                                {
                                                    Console.Clear();
                                                    Console.Write("Please Enter New Password (4 Digit): ");
                                                    pass1 = Console.ReadLine();
                                                    Console.Write("Please reEnter your Password (4 Digit): ");
                                                    pass2 = Console.ReadLine();
                                                    if (pass1 == pass2 && pass1.Length==4)
                                                    {
                                                        try
                                                        {
                                                            ChangePassword(input_username, Convert.ToInt32(pass1));
                                                            PrintMessage("Password Successfully Chenge.", ConsoleColor.Green);
                                                            PressAnyKey();
                                                            break;
                                                        }
                                                        catch (Exception e)
                                                        {
                                                            Console.Clear();
                                                            PrintMessage(e.Message, ConsoleColor.Red);
                                                            PressAnyKey();
                                                            break;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        Console.Clear();
                                                        PrintMessage("Password Not Equal or Lenght of password less than 4 digit. Please Try Again", ConsoleColor.Red);
                                                        PressAnyKey();
                                                        continue;
                                                    }
                                                }
                                                catch
                                                {
                                                    Console.Clear();
                                                    PrintMessage("Error During Change Password. Please Try Again.", ConsoleColor.Red);
                                                    PressAnyKey();
                                                    break;
                                                }
                                            }
                                        }
                                        //change password by system
                                        if (input_typePassword == 2)
                                        {
                                            try
                                            {
                                                int temp = SystemDefinePassword();
                                                ChangePassword(input_username, temp);
                                                PrintMessage("Password Successfully Chenged By System.", ConsoleColor.Green);
                                                PrintMessage("The New Password is : " + temp, ConsoleColor.White);
                                                PressAnyKey();
                                                break;
                                            }
                                            catch (Exception e)
                                            {
                                                Console.Clear();
                                                PrintMessage(e.Message, ConsoleColor.Red);
                                                PressAnyKey();
                                            }
                                        }
                                        if (input_typePassword == 0)
                                        {
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        PrintMessage(e.Message, ConsoleColor.Red);
                        PressAnyKey();
                        continue;
                    }
                }
                //Show Program MAP
                if (input == 2)
                {
                    Console.Clear();
                    Console.WriteLine("WellCome to HRMS Console Application.This is a MAP of This programms Menu to Refer to you that What is Menu Items. ");
                    Console.Write("So Please Read it Carefully IF Your Employee Account is "); Console.BackgroundColor = ConsoleColor.DarkYellow; Console.ForegroundColor = ConsoleColor.Black; Console.Write(Actions.EmployeeType.Administrator); Console.ResetColor();
                    Console.WriteLine(" Then Below Menu Show For you."); Console.WriteLine();
                    Console.WriteLine("1- Manage Accounts");
                    Console.Write("\t1-1 Show Total User Account"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Show All Employees With Their Specification."); Console.ResetColor();
                    Console.Write("\t1-2 Create New User Account"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Create New Employee Withe its Specification."); Console.ResetColor();
                    Console.Write("\t1-3 Disable User Account"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Disable Employee With Employee ID."); Console.ResetColor();
                    Console.Write("\t1-4 Enable User Account"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Enable Employee With Employee ID."); Console.ResetColor();
                    Console.Write("\t1-5 Edit User Account Information"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Edit Employee FirstNAme and LastName With Employee ID."); Console.ResetColor();
                    Console.Write("\t1-6 Change Employee Type"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Change Employee Type With Employee ID."); Console.ResetColor();
                    Console.Write("\t1-7 Statistical Summary of Employees"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Show All Employees Statistical Summary ."); Console.ResetColor();
                    Console.Write("\t1-8 Delete Employee"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Delete Employee !"); Console.ResetColor();
                    Console.WriteLine();
                    Console.WriteLine("2- Manage Password For User Account");
                    Console.Write("\t2-1 Change Password (User Defined "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[Low Security]"); Console.ResetColor(); Console.Write(" )"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Change Password With Enter Your Number."); Console.ResetColor();
                    Console.Write("\t2-2 Reset  Password (System Defined "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("[High Security]"); Console.ResetColor(); Console.Write(" )"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Change Password By System Founction (Recommended)."); Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("3- Log out"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Logout From Your Account."); Console.ResetColor();
                    Console.WriteLine(); Console.WriteLine();
                    PressAnyKey();
                    Console.Clear();
                    Console.Write("WellCome to HRMS Console Application.This is a MAP of This programms Menu to Refer to you that What is Menu Items. So Please Read it Carefully IF Your Employee Account is ");
                    Console.BackgroundColor = ConsoleColor.DarkBlue; Console.ForegroundColor = ConsoleColor.White; Console.Write(Actions.EmployeeType.Employees); Console.ResetColor();
                    Console.WriteLine(" Then Below Menu Show For you."); Console.WriteLine();
                    Console.Write("1- Show your information"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Show Your Information ."); Console.ResetColor();
                    Console.WriteLine("2- Manage Password For User Account");
                    Console.Write("\t2-1 Change Password (User Defined "); Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("[Low Security]"); Console.ResetColor(); Console.Write(" )"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Change Password With Enter Your Number."); Console.ResetColor();
                    Console.Write("\t2-2 Reset  Password (System Defined "); Console.ForegroundColor = ConsoleColor.Green; Console.Write("[High Security]"); Console.ResetColor(); Console.Write(" )"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Change Password By System Founction (Recommended)."); Console.ResetColor();
                    Console.WriteLine();
                    Console.Write("3- Log out"); Console.ForegroundColor = ConsoleColor.DarkGray; Console.WriteLine(" - Logout From Your Account."); Console.ResetColor();
                    Console.WriteLine(); Console.WriteLine();
                    PressAnyKey();
                    Console.Clear();
                    continue;
                }
                //exit program
                if (input == 3)
                {
                    break;
                }
            }
            char[] Goodbye = { 'T', 'h', 'a', 'n', 'k', ' ', 'y', 'o', 'u', ' ', ' ', '.', ' ', ' ', 'G', 'o', 'o', 'd', ' ', 'B', 'y', 'e', '.', '.', '.' };
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < Goodbye.Length; i++)
            {
                Thread.Sleep(35);
                Console.Write(Goodbye[i]);
            }
            Console.ResetColor();
        }
        #endregion
    }
}
