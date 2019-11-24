using System;

namespace ShapingProgram
{
    /// <summary>
    /// This class is for Circle shape, 
    /// it provides implimentation of shape abstract 
    /// method like Area, Perimeter and DisplayName.
    /// </summary>
    class Circle : Oval
    {        

        /// <summary>
        /// Display class name.
        /// </summary>
        internal override void DisplayName()
        {
            base.DisplayName();
            Console.Write(ConstantValues.ClassName, ConstantValues.StrCircle);
        }

        /// <summary>
        /// Area finding and printing method
        /// </summary>
        /// <param name="rlength">Circle radius</param>        
        internal float Area(float radius)
        {            
            return (float)Math.PI * radius * radius;
        }

        /// <summary>
        /// Perimeter finding and printing method
        /// </summary>
        /// <param name="rlength">Circle radius</param>
        internal float Perimeter(float radius)
        {            
            return (float)(2 * Math.PI * radius);
        }                       
    }
}
