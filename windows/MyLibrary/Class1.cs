using Microsoft.ReactNative.Managed;


namespace MyLibrary
{
    [ReactModule]
    public sealed class Class1
    {
        [ReactMethod("add")]
        public double Add(double a, double b)
        {
            double result = a + b;
            return result;
        }
    }
}
