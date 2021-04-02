using NUnit.Framework;
using EPAM_task_4_3;

namespace Task_4_2_test
{
    public class Tests
    {

        static readonly Monomial[] arrayofstruct1 = new Monomial[]
        {
            new Monomial(1,2),
            new Monomial(2,3),
            new Monomial(3,3)
        };

        static readonly Monomial[] arrayofstruct2 = new Monomial[]
        {
            new Monomial(1,2),
            new Monomial(2,3),
            new Monomial(3,3)
        };

        static readonly Monomial[] arrayofstruct3 = new Monomial[]
        {
            new Monomial(5,2),
            new Monomial(12,3),
            new Monomial(3,34)
        };

        static readonly Monomial[] arrayofstruct4 = new Monomial[]
        {
            new Monomial(4,1),
            new Monomial(2,3),
            new Monomial(5,3),
            new Monomial(0,2)
        };

        static readonly object[] PolynomialEqualsData = new object[]
        {
            new object[] {arrayofstruct1,3,arrayofstruct2,3,true},
            new object[] {arrayofstruct3,12,arrayofstruct4,5,false}
        };

        static readonly object[] PolynomialToStringTestData = new object[]
        {
            new object[] {arrayofstruct1,3,"3x^3+3x^2+2x^1"},
            new object[] {arrayofstruct3,12,"3x^12+2x^5+34x^3"}
        };

        [TestCaseSource("PolynomialEqualsData")]
        public void PolynomialEqualsTest(Monomial[] array1, int degree1, Monomial[] array2, int degree2, bool result)
        {
            var pol1 = new Polynomial(degree1);
            pol1.AddCoefficients(array1);
            var pol2 = new Polynomial(degree2);
            pol2.AddCoefficients(array2);
            Assert.AreEqual(pol1.Equals(pol2),result);
        }

        [TestCaseSource("PolynomialToStringTestData")]
        public void PolynomialToStringTest(Monomial[] array1, int degree1, string str)
        {
            var pol1 = new Polynomial(degree1);
            pol1.AddCoefficients(array1);
            Assert.AreEqual(pol1.ToString(), str);
        }
    }
}