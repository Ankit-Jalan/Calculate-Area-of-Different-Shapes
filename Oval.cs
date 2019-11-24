using System;

namespace ShapingProgram
{
    /// <summary>
    /// This class is for Oval shape, 
    /// it provides implimentation of shape abstract 
    /// method like Area, Perimeter and DisplayName.
    /// </summary>
    class Oval : Shape
    {               

        /// <summary>
        /// Display class name.
        /// </summary>
        internal override void DisplayName()
        {
            base.DisplayName();
            Console.Write(ConstantValues.ClassName, ConstantValues.StrOval);
        }

        /// <summary>
        /// Area finding and printing method
        /// </summary>
        /// <param name="rlength">Oval X-radius</param>
        /// <param name="rwidth">Oval Y-radius</param>
        internal float Area(float xradius, float yradius)
        {            
            return (float)Math.PI * xradius * yradius;
        }
                
        /// <summary>
        /// Perimeter finding and printing method
        /// </summary>
        /// <param name="rlength">Oval X-radius</param>
        /// <param name="rwidth">Oval Y-radius</param>
        internal float Perimeter(float xradius, float yradius)
        {            
            return (float)(2 * Math.PI * Math.Sqrt(((xradius * xradius) + (yradius * yradius)) / 2));
        }                
    }
}
