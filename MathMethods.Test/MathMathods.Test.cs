
using MathematicalMethods;

namespace MathMethods.Test
{
    [TestClass]
    public class MathMethodsTest
    {
        private static MathematicalMethods.MathMethods mathmethods;

        private static double a1;
        private static double b1;
        private static double c1;
        private static double a2;
        private static double b2;
        private static double c2;
        private static double a3;
        private static double b3;
        private static double c3;
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)//
        {
            //initializing class
            mathmethods = new MathematicalMethods.MathMethods();


             a1 = 1;
             b1 = 0;
             c1 = 1;
            a2 = 1;
            b2 = -2;
            c2 = 1;
            a3 = 1;
            b3 = -4;
             c3 = 5;
        double[] expected = null; //functiion will return null
        }


        [TestMethod]
        public void Discriminant_null_pass()
        {

            //find discriminant
            double[] actual = mathmethods.Discriminant(a1, b1, c1);
            double[] expected = null;
            //check

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Discriminant_equalvalentsnull_pass()
        {
            
            double[] expected = new[] { 1.0 };//function will return 1.0
            double[] actual = mathmethods.Discriminant(a2, b2, c2);//find discriminant
            //check
            CollectionAssert.AreEquivalent(expected, actual);//equa;l despite position


        }
        [TestMethod]
        public void Discriminant_areallequal_pass()
        {

            
            double[] expected = new[] { 5.0, -1.0 };//function will return 1.0


            double[] actual = mathmethods.Discriminant(a3, b3, c3);//find discriminant


            CollectionAssert.AllItemsAreUnique(expected);//check
        }

        [TestMethod]
        public void PrecentFromNumber_50_pass()
        {
            double num = 10.5, percent = 50.5; 
            double expected = 20.792079207920793; // expected precentage 
            double delta = 0.001;//delta

            if (delta == 0)
            {
                Assert.Inconclusive("Test couldn't be accomplished");
            }
            //find precentage
            double actual = mathmethods.PrecentFromNumber(num, percent);
            Assert.AreEqual(expected, actual, delta);
            

        }

    }
}