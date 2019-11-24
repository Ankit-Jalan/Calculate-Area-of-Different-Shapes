using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ShapingProgram
{
    interface IShape
    {
        /// <summary>
        /// Area method definition.
        /// </summary>
        float Area();

        /// <summary>
        /// Perimeter method definition.
        /// </summary>
        float Perimeter();
    }
}
