using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace Logic.Tests
{
    [TestFixture]
    class DataServiceTests
    {
        static DataService DataInicialization()
        {
            DataService data = new DataService(5);
            for (int i = 1; i <= 5; i++)
            {
                data.AddItem(i);
            }
            return data;
        }

        [TestCase(5)]
        public void DataService_Constructor_Initialization(int capacity)
        {
            //Arrange and Act
            DataService data = new DataService(capacity);
            //Assert
            Assert.That(data.ItemsCount, Is.EqualTo(0));
            Assert.That(data.GetAllData(), Is.Empty);
        }
        [Test]
        public void ItemsCount_Given_correct_count_of_collection()
        {
            //Arrange   
            DataService data = DataInicialization();
            //Act
            var result = data.ItemsCount;
            //Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [TestCase(4)]
        public void AddItem_When_added_new_item_Then_get_correct_collection(int a)
        {
            //Arrange
            DataService data = new DataService(0);
            List<int> testList = new List<int>() { 4 };
            //Act
            data.AddItem(a);
            //Assert
            CollectionAssert.AreEqual(testList, data.GetAllData());
        }
        [TestCase(2, ExpectedResult = 3)]
        public int GetElementAt_When_given_index_of_collection_Then_given_correct_item(int index)
        {
            //Arrange
            DataService data = DataInicialization();
            //Act
            var result = data.GetElementAt(index);
            //Assert
            return result;
        }
        [Test]
        public void GetAllData_gives_correct_collection()
        {
            //Arrange
            DataService data = DataInicialization();
            List<int> testList = new List<int>() { 1, 2, 3, 4, 5 };
            //Act
            var result = data.GetAllData();
            //Assert
            CollectionAssert.AreEqual(testList, result);
        }
        [TestCase(1)]
        public void RemoveAt_When_given_index_Then_given_correct_collection(int index)
        {
            //Arrange
            DataService data = DataInicialization();
            List<int> testList = new List<int>() { 1, 3, 4, 5 };
            //Act
            data.RemoveAt(index);
            var result = data.GetAllData();
            //Assert
            CollectionAssert.AreEqual(testList, result);
        }
        [Test]
        public void ClearAll_given_empty_collection()
        {
            //Arrange
            DataService data = DataInicialization();
            //Act
            data.ClearAll();
            //Assert
            Assert.That(data.GetAllData(), Is.Empty);
        }
        [TestCase(ExpectedResult = 5)]
        public int GetMax_Given_correct_max_item_of_collection()
        {
            //Arrange
            DataService data = DataInicialization();
            //Act
            var result = data.GetMax();
            //Assert
            return result;
        }
    }
}
