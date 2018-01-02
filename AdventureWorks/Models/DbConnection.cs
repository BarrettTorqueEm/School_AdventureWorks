using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;
using System.Data.Odbc;
using AdventureWorks.Models.dbo;
using AdventureWorks.Models.HumanResources;
using AdventureWorks.Models.Person;
using AdventureWorks.Models.Production;
using AdventureWorks.Models.Purchasing;
using AdventureWorks.Models.Sales;

namespace AdventureWorks.Models
{
    public class DbConnection
    {
        #region //Createing things
        OleDbConnection aConnection = new OleDbConnection();

        private List<Department> aListOfDepartment = new List<Department>();
        private List<Employee> aListOfEmployee = new List<Employee>();
        private List<EmployeeDepartmentHistory> aListOfEmployeeHistory = new List<EmployeeDepartmentHistory>();
        private List<EmployeePayHistory> aListOfEmployeePayHistory = new List<EmployeePayHistory>();
        private List<JobCandidate> aListOfJobCandidate = new List<JobCandidate>();
        private List<Shift> aListOfShift = new List<Shift>();
        private List<Address> aListOfAddress = new List<Address>();
        private List<string> aListOfTables = new List<string>();
        #endregion

        #region //Database connections for List *
        /*Testing 
        public List<string> GetTables(string Lists)
        {
            string aSQL = "SELECT * FROM " + Lists + ";";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\AdventureWorks.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                string aDepartment = (string)aReader["HumanReasources_Department"];
                string aEmployee = (string)aReader["HumanReasources_Employee"];
                string aEmployeeAddress = (string)aReader["HumanReasources_EmployeeAddress"];

                aListOfTables.Add(aDepartment);
                aListOfTables.Add(aEmployee);
                aListOfTables.Add(aEmployeeAddress);
            }
            aConnection.Close();
            return aListOfTables;
        }*/

        public List<Department> GetDepartment()
        {
            string aSQL = "SELECT DepartmentID, Name, GroupName, ModifiedDate FROM HumanResources_Department;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\AdventureWorks.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                short aDepartmentId = (short)aReader["DepartmentID"];
                string aName = (string)aReader["Name"];
                string aGroupName = (string)aReader["GroupName"];
                DateTime aModifiedDate = (DateTime)aReader["ModifiedDate"];

                Department aDepartment = new Department();

                aDepartment.DepartmentId = aDepartmentId;
                aDepartment.Name = aName;
                aDepartment.GroupName = aGroupName;
                aDepartment.ModifiedDate = aModifiedDate;

                aListOfDepartment.Add(aDepartment);
            }
            aConnection.Close();

            return aListOfDepartment;
        }

        public List<Employee> GetEmployee()
        {
            string aSQL = "SELECT EmployeeID, NationalIDNumber, ContactID, LoginID, ManagerID, Title, BirthDate, MaritalStatus, Gender, " +
                "HireDate, SalariedFlag, VacationHours, SickLeaveHours, CurrentFlag, rowguid, ModifiedDate FROM HumanResources_Employee;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\AdventureWorks.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                int aEmployeeId = (int)aReader["EmployeeID"];
                string aNationalIdNumber = (string)aReader["NationalIDNumber"];
                int aContactId = (int)aReader["ContactID"];
                string aLoginId = (string)aReader["LoginID"];
                string aManagerId = aReader["ManagerID"].ToString();
                string aJobTitle = (string)aReader["Title"];
                DateTime aBirthDate = (DateTime)aReader["BirthDate"];
                string aMaritalStatus = (string)aReader["MaritalStatus"];
                string aGender = (string)aReader["Gender"];
                DateTime aHireDate = (DateTime)aReader["HireDate"];
                short aSalariedFlag = (short)aReader["SalariedFlag"];
                short aVacationHours = (short)aReader["VacationHours"];
                short aSickLeaveHours = (short)aReader["SickLeaveHours"];
                short aCurrentFlag = (short)aReader["CurrentFlag"];
                short aRowguid = (short)aReader["rowguid"];
                DateTime aModifiedDate = (DateTime)aReader["ModifiedDate"];

                Employee aEmployee = new Employee();

                aEmployee.EmployeeId = aEmployeeId;
                aEmployee.NationalIdNumber = aNationalIdNumber;
                aEmployee.ContactId = aContactId;
                aEmployee.LoginId = aLoginId;
                aEmployee.ManagerId = aManagerId;
                aEmployee.JobTitle = aJobTitle;
                aEmployee.BirthDate = aBirthDate;
                aEmployee.MaritalStatus = aMaritalStatus;
                aEmployee.Gender = aGender;
                aEmployee.HireDate = aHireDate;
                aEmployee.SalariedFlag = aSalariedFlag;
                aEmployee.VacationHours = aVacationHours;
                aEmployee.SickLeaveHours = aSickLeaveHours;
                aEmployee.CurrentFlag = aCurrentFlag;
                aEmployee.Rowguid = aRowguid;
                aEmployee.ModifiedDate = aModifiedDate;

                aListOfEmployee.Add(aEmployee);
            }
            aConnection.Close();

            return aListOfEmployee;
        }

        public List<EmployeeDepartmentHistory> GetEmployeeDepartmentHistory()
        {
            string aSQL = "SELECT EmployeeID, DepartmentId, StartDate, ShiftID, EndDate, ModifiedDate FROM HumanResources_EmployeeDepartmentHistory;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\AdventureWorks.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                int aBusinessEntityId = (int)aReader["EmployeeID"];
                string aDepartmentId = aReader["DepartmentId"].ToString();
                string aStartDate = (string)aReader["StartDate"].ToString();
                string aShiftId = aReader["ShiftID"].ToString();
                string aEndDate = aReader["EndDate"].ToString();
                string aModifiedDate = aReader["ModifiedDate"].ToString();


                EmployeeDepartmentHistory aEmployeeHistory = new EmployeeDepartmentHistory();

                aEmployeeHistory.BusinessEntityId = aBusinessEntityId;
                aEmployeeHistory.DepartmentId = aDepartmentId;
                aEmployeeHistory.StartDate = aStartDate;
                aEmployeeHistory.ShiftId = aShiftId;
                aEmployeeHistory.EndDate = aEndDate;
                aEmployeeHistory.ModifiedDate = aModifiedDate;

                aListOfEmployeeHistory.Add(aEmployeeHistory);
            }
            aConnection.Close();

            return aListOfEmployeeHistory;
        }

        public List<EmployeePayHistory> GetEmployeePayHistory()
        {
            string aSQL = "SELECT EmployeeID, RateChangeDate, Rate, PayFrequency, ModifiedDate FROM HumanResources_EmployeePayHistory;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\AdventureWorks.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                int aBusinessEntityId = (int)aReader["EmployeeID"];
                string aRateChangeDate = aReader["RateChangeDate"].ToString();
                int aRate = Convert.ToInt32(aReader["Rate"]);
                int aPayFrequency= Convert.ToInt32(aReader["PayFrequency"]);
                string aModifiedDate = aReader["ModifiedDate"].ToString();


                EmployeePayHistory aEmployeePayHistory = new EmployeePayHistory();

                aEmployeePayHistory.BusinessEntityId = aBusinessEntityId;
                aEmployeePayHistory.RateChangeDate = aRateChangeDate;
                aEmployeePayHistory.Rate = aRate;
                aEmployeePayHistory.PayFrequencey = aPayFrequency;
                aEmployeePayHistory.ModifiedDate = aModifiedDate;

                aListOfEmployeePayHistory.Add(aEmployeePayHistory);
            }
            aConnection.Close();

            return aListOfEmployeePayHistory;
        }

        public List<JobCandidate> GetJobCandidate()
        {
            string aSQL = "SELECT EmployeeID, JobCandidateID, Resume, ModifiedDate FROM HumanResources_JobCandidate;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\AdventureWorks.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                string aBusinessEntityId = aReader["EmployeeID"].ToString();
                int aJobCandidateId= (int)aReader["JobCandidateID"];
                string aResume = (string)aReader["Resume"];
                string aModifiedDate = aReader["ModifiedDate"].ToString();

                JobCandidate aJobCandidate = new JobCandidate();

                aJobCandidate.BusinessEntityId = aBusinessEntityId;
                aJobCandidate.JobCandidateId = aJobCandidateId;
                aJobCandidate.Resume = aResume;
                aJobCandidate.ModifiedDate = aModifiedDate;

                aListOfJobCandidate.Add(aJobCandidate);
            }
            aConnection.Close();

            return aListOfJobCandidate;
        }

        public List<Shift> GetShift()
        {
            string aSQL = "SELECT ShiftID, Name, StartTime, EndTime, ModifiedDate FROM HumanResources_Shift;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\AdventureWorks.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                string aShiftId = aReader["ShiftID"].ToString();
                string aName = (string)aReader["Name"];
                string aStartTime = aReader["StartTime"].ToString();
                string aEndTime = aReader["EndTime"].ToString();
                string aModifiedDate = aReader["ModifiedDate"].ToString();

                Shift aShift = new Shift();

                aShift.ShiftId = aShiftId;
                aShift.Name = aName;
                aShift.StartTime = aStartTime;
                aShift.EndTime = aEndTime;
                aShift.ModifiedDate = aModifiedDate;

                aListOfShift.Add(aShift);
            }
            aConnection.Close();

            return aListOfShift;
        }

        public List<Address> GetAddress()
        {
            string aSQL = "SELECT AddressID, AddressLine1, AddressLine2, City, StateProvinceID, PostalCode, SpatialLocation, rowguid, ModifiedDate FROM Person_Address;";

            aConnection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0; 
Data Source=N:\AdventureWorks.mdb";

            aConnection.Open();

            OleDbCommand aCommand = aConnection.CreateCommand();

            aCommand.CommandText = aSQL;

            OleDbDataReader aReader = aCommand.ExecuteReader();

            while (aReader.Read())
            {
                int aAddressId= (int)aReader["AddressID"];
                string aAddressLine1 = (string)aReader["AddressLine1"];
                string aAddressLine2 = aReader["AddressLine2"].ToString();
                string aCity = (string)aReader["City"];
                int aStateProvinceId = (int)aReader["StateProvinceID"];
                string aPostalCode = (string)aReader["PostalCode"];
                string aSpatialLocation = (string)aReader["SpatialLocation"];
                string aRowguid = (string)aReader["rowguid"];
                string aModifiedDate = aReader["ModifiedDate"].ToString();

                Address aAddress = new Address();

                aAddress.AddressId = aAddressId;
                aAddress.AddressLine1= aAddressLine1;
                aAddress.AddressLine2= aAddressLine2;
                aAddress.City= aCity;
                aAddress.StateProvinceId= aStateProvinceId;
                aAddress.PostalCode= aPostalCode;
                aAddress.SpatialLocation= aSpatialLocation;
                aAddress.Rowguid= aRowguid;
                aAddress.ModifiedDate = aModifiedDate;

                aListOfAddress.Add(aAddress);
            }
            aConnection.Close();

            return aListOfAddress;
        }
        #endregion
    }
}
