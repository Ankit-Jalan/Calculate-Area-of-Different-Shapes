using System;
using System.Threading;

namespace ShapingProgram
{   
    /// <summary>
    /// Main class to handle program flow.
    /// </summary>
    class CreateShape 
    {
        /// <summary>
        /// This method is used to get float value.
        /// </summary>
        /// <returns>Return float value</returns>
        private static float GetValue()
        {
            float uValue;
            bool check;
            while (true)
            {
                //Getting values
                check = float.TryParse(Console.ReadLine(), out uValue);
                if (check == true)
                {
                    //Value Accepted
                    if (uValue < ConstantValues.ValueMaxLimit && uValue > ConstantValues.ValueMinLimit)
                    {
                        break;
                    }
                    //Needed to enter value again.
                    else
                    {
                        Console.WriteLine(ConstantValues.ValueUnfeasible, ConstantValues.ValueMinLimit, ConstantValues.ValueMaxLimit);
                    }
                }
                //Needed to enter value again.
                else
                {
                    Console.WriteLine(ConstantValues.ValueIncorrect);
                }
            }
            return uValue;
        }

        /// <summary>
        /// This method show status of active and total object available.
        /// </summary>
        private static void ObjectStatus()
        {
            Console.WriteLine();
            Console.WriteLine(ConstantValues.Desh);
            Console.WriteLine(ConstantValues.Tab + ConstantValues.ObjectCount, Shape.Serial);
            Console.WriteLine(ConstantValues.Tab + ConstantValues.ActiveObject, Shape.LiveSerial);
            Console.WriteLine(ConstantValues.Desh);
        }

        /// <summary>
        /// This method handles computation of Rectangle.
        /// </summary>
        private static void RectangelCall()
        {
            Console.Clear();
            Rectangle rectangleshape = new Rectangle();
            Console.WriteLine(ConstantValues.ObjectCreated, ConstantValues.StrRectangle);
            rectangleshape.DisplayName();
            ObjectStatus();
            Console.WriteLine(ConstantValues.RectangleLength);
            float rlength = GetValue();
            Console.WriteLine(ConstantValues.RectangleWidth);
            float rwidth = GetValue();
            float area = rectangleshape.Area(rlength, rwidth);
            Console.WriteLine(ConstantValues.AreaStatement, ConstantValues.StrRectangle, rlength, rwidth, area);
            float perimeter = rectangleshape.Perimeter(rlength, rwidth);
            Console.WriteLine(ConstantValues.PerimeterStatement, ConstantValues.StrRectangle, rlength, rwidth, perimeter);
            rectangleshape.Dispose();            
            Console.WriteLine(ConstantValues.ObjectDeleted, ConstantValues.StrRectangle);
            ObjectStatus();
        }

        /// <summary>
        /// This method handles computation of Oval.
        /// </summary>
        private static void OvalCall()
        {
            Console.Clear();
            Oval ovalshape = new Oval();
            Console.WriteLine(ConstantValues.ObjectCreated, ConstantValues.StrOval);
            ovalshape.DisplayName();
            ObjectStatus();
            Console.WriteLine(ConstantValues.XRadius);
            float xradius = GetValue();
            Console.WriteLine(ConstantValues.YRadius);
            float yradius = GetValue();
            float area = ovalshape.Area(xradius, yradius);
            Console.WriteLine(ConstantValues.AreaStatement, ConstantValues.StrOval, xradius, yradius, area);
            float perimeter = ovalshape.Perimeter(xradius, yradius);
            Console.WriteLine(ConstantValues.PerimeterStatement, ConstantValues.StrOval, xradius, yradius, perimeter);
            ovalshape.Dispose();
            Console.WriteLine(ConstantValues.ObjectDeleted, ConstantValues.StrOval);
            ObjectStatus(); 
        }

        /// <summary>
        /// This method handles computation of Circle.
        /// </summary>
        private static void CircleCall()
        {
            Console.Clear();
            Circle circleshape = new Circle();
            Console.WriteLine(ConstantValues.ObjectCreated, ConstantValues.StrCircle);
            circleshape.DisplayName();
            ObjectStatus();
            Console.WriteLine(ConstantValues.CircleRadius);
            float radius = GetValue();
            float area = circleshape.Area(radius);
            Console.WriteLine(ConstantValues.AreaStatementCircle, ConstantValues.StrCircle, radius, area);
            float perimeter = circleshape.Perimeter(radius);
            Console.WriteLine(ConstantValues.PerimeterStatementCircle, ConstantValues.StrCircle, radius, perimeter);
            circleshape.Dispose();
            Console.WriteLine(ConstantValues.ObjectDeleted, ConstantValues.StrCircle);
            ObjectStatus();
        }        

        /// <summary>
        /// Starting method of program.
        /// </summary>
        /// <param name="args">array fo argument</param>
        static void Main(string[] args)
        {
            int optionValue;            
            String exit = null;
            //Rectangle rectangleshape;
            //Oval ovalshape;
            //Circle circleshape;
   
            while (exit !=ConstantValues.Quit)
            {
                try
                {
                    Console.WriteLine(ConstantValues.Menu, ConstantValues.Rectangle, ConstantValues.StrRectangle, ConstantValues.Oval, ConstantValues.StrOval, ConstantValues.Circle, ConstantValues.StrCircle, ConstantValues.Exit, ConstantValues.StrExit);
                    
                    while (true)
                    {
                        bool check = int.TryParse(Console.ReadLine(), out optionValue);

                        // When value is accepted
                        if (optionValue <= ConstantValues.UpperLimitOption && optionValue >= ConstantValues.LowerLimitOption)
                        {
                            break;
                        }
                        // Needed to enter again
                        else if (check == false)
                        {
                            Console.WriteLine(ConstantValues.OptionIncorrect);
                        }
                        // Needed to enter again
                        else
                        {
                            Console.WriteLine(ConstantValues.OptionIncorrect);
                        }
                    }

                    switch (optionValue)
                    {
                        //For handling Rectangle case.
                        case ConstantValues.Rectangle:

                            RectangelCall();
                            break;

                        //For handling Oval case.
                        case ConstantValues.Oval:

                            OvalCall();
                            break;

                        //For handling Circle case.
                        case ConstantValues.Circle:

                            CircleCall();
                            break;

                        //For handling Exit case.
                        case ConstantValues.Exit:

                            exit = ConstantValues.Quit;
                            break;

                    }
                                        
                }
                catch(Exception e)
                {
                    Console.WriteLine(ConstantValues.ExcStatement + e);
                }
            }            
        }
    }
}
