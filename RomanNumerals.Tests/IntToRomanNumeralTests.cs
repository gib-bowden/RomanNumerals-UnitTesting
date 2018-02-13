using NUnit.Framework;
using RomanNumerals.App; 

namespace RomanNumerals.Tests
{
    [TestFixture]
    public class IntToRomanNumeralTests
    {

        [Test]
        public void Nonnumber_input()
        {
            //arrange
            var number = "asdfsadf";
            var converter = new IntToRomanNumeralConverter();

            //Act and assert
            Assert.Throws<System.ArgumentException>(() => converter.Convert(number));

        }


        [Test]
        public void Convert_number_one()
        {
            //arrange
            var number = "1";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("I", result.Numeral); 
        }

        [Test]
        public void Convert_number_five()
        {
            //arrange
            var number = "5";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("V", result.Numeral);
        }

        [Test]
        public void Convert_number_nine()
        {
            //arrange
            var number = "9";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("IX", result.Numeral);
        }



        [Test]
        public void Convert_number_twelve()
        {
            //arrange
            var number = "12";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("XII", result.Numeral);
        }

        [Test]
        public void Convert_number_sixteen()
        {
            //arrange
            var number = "16";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("XVI", result.Numeral);
        }

        [Test]
        public void Convert_number_twenty_nine()
        {
            //arrange
            var number = "29";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("XXIX", result.Numeral);
        }

        [Test]
        public void Convert_number_fourty_four()
        {
            //arrange
            var number = "44";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("XLIV", result.Numeral);
        }

        [Test]
        public void Convert_number_fourty_five()
        {
            //arrange
            var number = "45";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("XLV", result.Numeral);
        }

        [Test]
        public void Convert_sixty_eight()
        {
            //arrange
            var number = "68";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("LXVIII", result.Numeral);
        }

        [Test]
        public void Convert_number_eighty_three()
        {
            //arrange
            var number = "83";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("LXXXIII", result.Numeral);
        }

        [Test]
        public void Convert_number_ninty_seven()
        {
            //arrange
            var number = "97";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("XCVII", result.Numeral);
        }

        [Test]
        public void Convert_number_ninty_nine()
        {
            //arrange
            var number = "99";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("XCIX", result.Numeral);
        }

        [Test]
        public void Convert_number_five_hundred()
        {
            //arrange
            var number = "500";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("D", result.Numeral);
        }

        [Test]
        public void Convert_number_five_hundred_one()
        {
            //arrange
            var number = "501";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("DI", result.Numeral);
        }

        [Test]
        public void Convert_number_six_fourty_nine()
        {
            //arrange
            var number = "649";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("DCXLIX", result.Numeral);
        }

        [Test]
        public void Convert_number_seven_ninty_eight()
        {
            //arrange
            var number = "798";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("DCCXCVIII", result.Numeral);
        }

        [Test]
        public void Convert_number_eight_ninty_one()
        {
            //arrange
            var number = "891";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("DCCCXCI", result.Numeral);
        }

        [Test]
        public void Convert_number_one_thousand()
        {
            //arrange
            var number = "1000";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("M", result.Numeral);
        }

        [Test]
        public void Convert_one_thousand_four()
        {
            //arrange
            var number = "1004";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("MIV", result.Numeral);
        }

        [Test]
        public void Convert_one_thousand_six()
        {
            //arrange
            var number = "1006";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("MVI", result.Numeral);
        }

        [Test]
        public void Convert_one_thousand_twenty_three()
        {
            //arrange
            var number = "1023";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("MXXIII", result.Numeral);
        }

        [Test]
        public void Convert_two_thousand_fourteen()
        {
            //arrange
            var number = "2014";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("MMXIV", result.Numeral);
        }

        [Test]
        public void Convert_three_thousand_nine_hundred_ninety_nine()
        {
            //arrange
            var number = "3999";
            var converter = new IntToRomanNumeralConverter();

            //Act
            var result = converter.Convert(number);

            //assert
            Assert.AreEqual("MMMCMXCIX", result.Numeral);
        }

    }
}
