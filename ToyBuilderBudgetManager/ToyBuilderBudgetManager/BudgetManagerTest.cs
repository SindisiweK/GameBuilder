using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace ToyBuilderBudgetManager
{
    [TestFixture]
    public class BudgetManagerTest
    { 
        [Test]
        public void GenerateItemList_GivenOneItem_ShouldReturnItemAdded()
        {
            //Arrange
            var sut = new BudgetManager();
            var expected = "EmergencyFund";
            //Act
            var actual = sut.GetBudgetItems();

            //Assert
            Assert.AreEqual(expected,actual.First().expense);
        }
        [Test]
        public void GenerateItemList_GivenTwoItems_ShouldReturnItemAtTheIndex0f2()
        {
            //Arrange
            var sut = new BudgetManager();
            var expected = "Savings";
            //Act
            var actual = sut.GetBudgetItems();

            //Assert
            Assert.AreEqual(expected,actual.ElementAt(1).expense);
        }
        [Test]
        public void GenerateItemList_GivenThreeItems_ShouldReturnItemAtTheIndex0f3()
        {
            //Arrange
            var sut = new BudgetManager();
            var expected = "FoodAndGrocerie";
            //Act
            var actual = sut.GetBudgetItems();

            //Assert
            Assert.AreEqual(expected,actual.ElementAt(2).expense);
        }
        [Test]
        public void AddBudgetItems_GivenExtraCater_ShouldAddItemToAList()
        {
            //Arrange
            var items = new BudgetModel
            {
                expense = "PocketMoney",
                cost = 2100,
                startDate = DateTime.Parse("2018-07-01"),
                endDate = DateTime.Parse("2018-12-31")
            };
            var sut = new BudgetManager();
            
            //Act
            var actual = sut.AddItems(items);

            //Assert
            Assert.AreEqual(4,actual.Count);
        }
        [Test]
        public void AddBudgetItems_GivenDefaultItems_ShouldAddItemToAList()
        {
            //Arrange
            var items = new BudgetModel
            {
                expense = "PocketMoney",
                cost = 2100,
                startDate = DateTime.Parse("2018-07-01"),
                endDate = DateTime.Parse("2018-12-31")
            };
            var sut = new BudgetManager();

            //Act
            var actual = sut.AddItems(items);

            //Assert
            Assert.AreEqual(4, actual.Count);
        }

    }
}

