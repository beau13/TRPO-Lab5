namespace Laba3.ClassLibrary
{
    public class Cylinder_surface_area
    {
        public double Cylinder_surface_area_formula(double r, double h)
        {
            if (r <= 0 || h <= 0)
            {
                throw new ArgumentException("Значение параметров должно быть большим 0");
            }
            return Math.Round(2 * Math.PI * r * (h + r), 3);
        }
    }
}