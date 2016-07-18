using System;
using NUnit.Framework;

namespace Logic.Tests
{
    [TestFixture]
    public class MasterServiceTests
    {
        IAlgoService algo = new AlgoService();
        static IDataService DataInicialization()
        {
            IDataService data = new DataService(5);
            for (int i = 1; i <= 5; i++)
            {
                data.AddItem(i);
            }
            return data;
        }

        [Test]
        public void GetDoubleSum_When_given_list_of_numbers_Then_given_correct_sum_of_double_it()
        {
            //Arrange
            MasterService master = new MasterService(algo, DataInicialization());
            //Act           
            var result = master.GetDoubleSum();
            //Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void GetMinSqure_When_given_list_of_numbers_Then_given_correct_square_of_min_element()
        {
            //Arrange            
            MasterService master = new MasterService(algo, DataInicialization());
            //Act 
            var result = master.GetMinSqure();
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void GetMaxSqure_When_given_list_of_numbers_Then_given_correct_square_of_max_element()
        {
            //Arrange            
            MasterService master = new MasterService(algo, DataInicialization());
            //Act 
            var result = master.GetMaxSquare();
            //Assert
            Assert.That(result, Is.EqualTo(25));
        }

        [Test]
        public void GetAverage_When_given_list_of_numbers_Then_given_correct_average_of_elements()
        {
            //Arrange            
            MasterService master = new MasterService(algo, DataInicialization());
            //Act 
            var result = master.GetAverage();
            //Assert
            Assert.That(result, Is.EqualTo(3));
        }
        [Test]
        public void GetFunction_When_given_list_of_numbers_Then_given_correct_average_of_elements()
        {
            //Arrange            
            MasterService master = new MasterService(algo, DataInicialization());
            //Act 
            var result = master.GetFunction();
            //Assert
            Assert.That(result, Is.EqualTo(15649.558601907298));
        }
    }
}
