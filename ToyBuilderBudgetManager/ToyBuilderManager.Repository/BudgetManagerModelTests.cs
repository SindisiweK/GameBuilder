using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ToyBuilderBudgetManager.Model;

namespace ToyBuilderManager.Repository
{
    [TestFixture]
    public class BudgetManagerModelTests
    {
        [Test]
        public void AddUser_GivenUserProfile_ShouldAddUserDetails()
        {
            //Arrange
            var sut = new BudgetManagerModel("BudgetDB"); 
            var userProfile = new UserProfile
            {
                FirstName = "Kungayo",
                LastName = "Pantshwa",
                Salary = 50000
            };
            //Act
            var actual = sut.AddUser(userProfile);

            //Assert
            Assert.AreEqual(userProfile.Salary,actual.Salary);
        }

        [Test]
        public void GetAllUsers_WhenGetAllUsersMethodIsCalled_ShouldReturnAllUsers()
        {
            //Arrange
            var sut = new BudgetManagerModel("BudgetDB");
            //Act
            var actual = sut.GetAllUsers();

            //Assert
            Assert.AreEqual(5, actual.Count);
        }
    }
}
