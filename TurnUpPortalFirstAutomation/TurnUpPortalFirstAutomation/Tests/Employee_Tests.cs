﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using TurnUpPortalFirstAutomation.Pages;
using TurnUpPortalFirstAutomation.Utilities;

namespace TurnUpPortalFirstAutomation.Tests
{
    [TestFixture]
    [Parallelizable]
    class Employee_Tests : CommonDriver
    {
        [Test, Order(1), Description("Check if user is able to create an Employee record with valid data")]
        public void CreateEmployeeTests()
        {

            //create obj for homepage
            homePage HomePageObj = new homePage();
            HomePageObj.goToEmployees(driver);

            //TMpage object initialization and definition
            //create new employee
            EmployeesPage employeePageobj = new EmployeesPage();
            employeePageobj.CreateEmployee(driver);

        }

        [Test, Order(2), Description("Check if user is able to edit an existing Employee record")]
        public void EditemployeeTest()
        {
            //create obj for homepage
           //homePage HomePageObj = new homePage();
            //HomePageObj.goToEmployees(driver);

            //Edit employee
             EmployeesPage employeePageobj = new EmployeesPage();
             employeePageobj.EditEmployee(driver);

        }
        [Test, Order(3), Description("Check if user is able to delete an Employee record")]
        public void DeleteEmployeeTest()
        {
            //create obj for homepage
           // homePage HomePageObj = new homePage();
            //HomePageObj.goToEmployees(driver);

            //Delete Employee
            EmployeesPage employeePageobj = new EmployeesPage();
            employeePageobj.DeleteEmployee(driver);

        }


    }
}
