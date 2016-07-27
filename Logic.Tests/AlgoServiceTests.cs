using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Logic.Tests
{
    [TestFixture]
    class AlgoServiceTests
    {
        IEnumerable<int> list = new int[] { 1, 2, 3, 4, 5 };

        [Test]
        public void DoubleSum_When_given_collection_Then_given_correct_result()
        {
            //Arrange
            AlgoService algo = new AlgoService();
            //Act
            var result = algo.DoubleSum(list);
            //Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void MinValue_When_given_collection_Then_given_correct_min_item()
        {
            //Arrange
            AlgoService algo = new AlgoService();
            //Act
            var result = algo.MinValue(list);
            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [TestCase(1, 0, 3, 4)]
        public void Function_When_given_params_Then_given_correct_result(int a, double b, int c, double d)
        {
            //Arrange
            AlgoService algo = new AlgoService();
            //Act
            var result = algo.Function(a, b, c, d);
            //Assert
            Assert.That(result, Is.EqualTo(67));
        }
        [Test]
        public void GetAverage_When_given_collection_Then_given_correct_average_of_it()
        {
            //Arrange
            AlgoService algo = new AlgoService();
            //Act
            var result = algo.GetAverage(list);
            //Assert
            Assert.That(result, Is.EqualTo(3));
        }
        [TestCase(2)]
        public void Sqr_When_given_number_Then_given_correct_result(int num)
        {
            //Arrange
            AlgoService algo = new AlgoService();
            //Act
            var result = algo.Sqr(num);
            //Assert
            Assert.That(result, Is.EqualTo(4));
        }
    }
}
