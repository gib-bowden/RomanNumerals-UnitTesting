using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using RomanNumerals.App;

namespace RomanNumerals.Tests
{
    [TestFixture]
    class RomanNumeralToIntTests
    {
        [Test]
        public void Convert_I_to_one()
        {
            //arrange
            var numeral = "I";
            var converter = new RomanNumeralToIntConverter();

            //Act
            var result = converter.Convert(numeral);

            //assert
            Assert.AreEqual(1, result);
        }

        [Test]
        public void Convert_II_to_two()
        {
            //arrange
            var numeral = "II";
            var converter = new RomanNumeralToIntConverter();

            //Act
            var result = converter.Convert(numeral);

            //assert
            Assert.AreEqual(2, result);
        }

        [Test]
        public void Convert_V_to_five()
        {
            //arrange
            var numeral = "V";
            var converter = new RomanNumeralToIntConverter();

            //Act
            var result = converter.Convert(numeral);

            //assert
            Assert.AreEqual(5, result);
        }

        [Test]
        public void Convert_VI_to_six()
        {
            //arrange
            var numeral = "VI";
            var converter = new RomanNumeralToIntConverter();

            //Act
            var result = converter.Convert(numeral);

            //assert
            Assert.AreEqual(6, result);
        }

        [Test]
        public void Convert_IX_to_9()
        {
            //arrange
            var numeral = "IX";
            var converter = new RomanNumeralToIntConverter();

            //Act
            var result = converter.Convert(numeral);

            //assert
            Assert.AreEqual(9, result);
        }
    }
}
