using System;

namespace lab_03_library_files
{
    // class is a container
    public class MyClass
    {
        // method/function
        public int DoubleUp(int number)
        {
            return 2 * number;
        }

        // field
        public double GravitationalConstant = 9.81;

        // static equivalent: read directly from class
        public static int ALsoTripleUp(int number)
        {
            return 3 * number;
        }

        // field
        public static double NaturalLogarithmicE = 2.71;


    }
}
