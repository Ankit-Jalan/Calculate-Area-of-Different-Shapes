using System;

namespace ShapingProgram
{
    /// <summary>
    /// This class is for Rectangle shape, 
    /// it provides implimentation of shape abstract 
    /// method like Area, Perimeter and DisplayName.
    /// </summary>
    internal class Rectangle : Shape
    {                            

        /// <summary>
        /// Display class name.
        /// </summary>
        internal override void DisplayName()
        {
            base.DisplayName();
            Console.Write(ConstantValues.ClassName,ConstantValues.StrRectangle);
        }

        /// <summary>
        /// Area finding and printing method
        /// </summary>
        /// <param name="rlength">Rectangle length</param>
        /// <param name="rwidth"> Rectangle width</param>
        internal float Area(float rlength, float rwidth)
        {            
            return rlength * rwidth;
        }

        /// <summary>
        /// Perimeter finding and printing method
        /// </summary>
        /// <param name="rlength">Rectangle length</param>
        /// <param name="rwidth"> Rectangle width</param>
        internal float Perimeter(float rlength, float rwidth)
        {          
            return 2 * (rlength + rwidth);
        }        
    }
}
