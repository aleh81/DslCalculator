using System;

namespace DlsCalculation_.Services
{
    public static class Calculator
    {
        public static double DlsCalculate(double dl, double md1, double md2) => (dl / (md2 - md1)) * 100;

        public static void DegreeToRadianConverter(ref double val)
        {
            val = val * Math.PI / 180;
        }

        public static void RadianToDegreeConverter(ref double val)
        {
            val = val * 180 / Math.PI;
        }

        public static void DegreeToRadianConverter(ref double x1, ref double x2, ref double x3, ref double x4)
        {
            DegreeToRadianConverter(ref x1);
            DegreeToRadianConverter(ref x2);
            DegreeToRadianConverter(ref x3);
            DegreeToRadianConverter(ref x4);
        }

        public static double DlCalculate(double f1, double f2, double v1, double v2)
        {
            var sinF = Math.Sin((f2 - f1) / 2) * Math.Sin((f2 - f1) / 2);
            var sinV = Math.Sin((v2 - v1) / 2) * Math.Sin((v2 - v1) / 2);
            var underSquareRoot = sinF + Math.Sin(f1) * Math.Sin(f2) * sinV;
            var squareRoot = Math.Sqrt(underSquareRoot);
            var b = 2 * Math.Asin(squareRoot);

            return b;
        }

        public static double DlsResult(double f1, double f2, double v1, double v2, double s1, double s2)
        {
            DegreeToRadianConverter(ref f1, ref f2, ref v1, ref v2);

            var dl = DlCalculate(f1, f2, v1, v2);
            var dls = DlsCalculate(dl, s1, s2);

            RadianToDegreeConverter(ref dls);

            var result = Math.Round(dls, 2);

            return result;
        }
    }
}
