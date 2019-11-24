using System;
using System.IO;

namespace ShapingProgram
{
    /// <summary>
    /// This is an abstrate class which contains 
    /// Definition of Area, Perimeter  and DisplayName methods
    /// and Implimentation of GetValue method and Property Serial
    /// </summary>
    class Shape : IDisposable , IShape
    {
        /// <summary>
        /// Constructor of shape which 
        /// increamets counter value.
        /// </summary>
        internal Shape()
        {
            serial++;
            liveserial++;
        }

        bool is_disposed = false;

        /// <summary>
        /// virtual Dispose method
        /// </summary>
        /// <param name="disposing"> disposing status.</param>
        protected  void Dispose(bool disposing)
        {
            if (!is_disposed) // only dispose once!
            {
                if (disposing)
                {
                    GC.Collect(2,GCCollectionMode.Forced);
                    GC.WaitForPendingFinalizers();                    
                }
                liveserial--;       
            }
            this.is_disposed = true;            
        }

        /// <summary>
        /// overloaded Dispose method.
        /// Which tells GC to not process 
        /// Garbage collection of this object
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            // tell the GC not to finalize
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Shape class Destructor.
        /// </summary>
        ~Shape()
        {
            Dispose(false);
        }


        /// <summary>
        /// Implimentation of abstract Area method.
        /// </summary>>
        public float Area()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implimentation of abstract Perimeter method.
        /// </summary>
        public float Perimeter()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Display class name.
        /// </summary>     
        internal virtual void DisplayName()
        {
            Console.Write(ConstantValues.StrShape);
        }
        
        /// <summary>
        /// Counter of shapes instanses
        /// </summary>
        private static int serial=0;
        
        /// <summary>
        /// Property which specify the no of time class object created.
        /// </summary>
        internal static int Serial
        {
            get
            {
                return serial;
            }
        }

        private static int liveserial=0;

        internal static int LiveSerial
        {
            get
            {
                return liveserial;
            }
        }        
    }
}
