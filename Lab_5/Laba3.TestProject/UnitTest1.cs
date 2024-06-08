using Laba3.ClassLibrary;

namespace Laba3.TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddTestSquare()
        {
            const double r = 2;
            const double h = 4;
            const double expected = 628.319;

            double result = new Cylinder_surface_area().Cylinder_surface_area_formula(r, h);
            Assert.AreEqual(expected, result);

        }
        [Test]
        public void AddTestSquare_2()
        {
            const double r = 2;
            const double h = -4;
            const double expected = 56.548667764616276;

            Cylinder_surface_area result = new Cylinder_surface_area();
            Assert.Throws<ArgumentException>(() => result.Cylinder_surface_area_formula(r, h));

        }
    }
}