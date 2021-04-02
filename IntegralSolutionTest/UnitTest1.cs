using System;
using CalculateLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntegralSolutionTest
{
    [TestClass]
    public class ICalculateLibraryTests
    {
        [TestMethod]
        public void Intergrate_xx_Gives_Correct_Result_For_Rectangle() // 1 тест для прямоугольников
        {
            //arrange
            double expected = 333_333.3333;
            double a = 0;
            double b = 100;
            long n = 100000;
            RectangleCalculator rectangleCalculator = new RectangleCalculator();
            Func<double, double> f = x => x * x;
            //act
            double actual = rectangleCalculator.Calculate(a, b, n, f);
            //assert
            Assert.AreEqual(expected, actual, 0.0001);

        }

        [TestMethod]
        public void Intergrate_xx_Gives_Correct_Result_For_Trapezoid() // 2 для проверки значения трапеций
        {
            //arrange
            double expected = 333_333.3333;
            double a = 0;
            double b = 100;
            long n = 100000;
            TrapCalculator trapCalculator = new TrapCalculator();
            Func<double, double> f = x => x * x;
            //act
            double actual = trapCalculator.Calculate(a, b, n, f);
            //assert
            Assert.AreEqual(expected, actual, 0.0001);

        }

        [TestMethod]
        public void Intergrate_xx_Gives_0_For_Rectangle() // 3 проверка 0 для прямоугольников 
        {
            //arrange
            double expected = 0;
            double a = 0;
            double b = a;
            long n = 100000;
            RectangleCalculator rectangleCalculator = new RectangleCalculator();
            Func<double, double> f = x => x * x;
            //act
            double actual = rectangleCalculator.Calculate(a, b, n, f);
            //assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        public void Intergrate_xx_Gives_0_For_Trapezoid() // 4 проверка 0 для трапеции
        {
            //arrange
            double expected = 0;
            double a = 0;
            double b = a;
            long n = 100000;
            TrapCalculator trapCalculator = new TrapCalculator();
            Func<double, double> f = x => x * x;
            //act
            double actual = trapCalculator.Calculate(a, b, n, f);
            //assert
            Assert.AreEqual(expected, actual, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))] // 5 означает что выдаст исключение
        public void Intergrate_xx_negative_n()
        {
            // Arrange
            double a = 0;
            double b = a;
            long n = -10;
            RectangleCalculator rectangleCalculator = new RectangleCalculator();
            Func<double, double> f = x => x * x;
            // Act
            double actual = rectangleCalculator.Calculate(a, b, n, f);
        }
    }
}