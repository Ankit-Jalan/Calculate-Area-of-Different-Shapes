
namespace ShapingProgram
{
    /// <summary>
    /// This class contain all the constant values used in this program which can be string and integer.
    /// </summary>
    class ConstantValues
    {
        internal const string AreaStatement = "Area of {0}({1},{2}) : {3}\n";
        internal const string AreaStatementCircle = "Area of {0}({1}) : {2}\n";
        internal const string PerimeterStatement = "Perimeter of {0}({1},{2}) : {3}\n";
        internal const string PerimeterStatementCircle= "Perimeter of {0}({1}) : {2}";
        internal const string StrRectangle = " Rectangle ";
        internal const string StrOval = " Oval ";
        internal const string StrCircle = " Circle ";
        internal const string StrExit = " Exit ";
        internal const string Menu = "{0} : {1}\n{2} : {3}\n{4} : {5}\n{6} : {7}\n";
        internal const string ObjectCount = "Object count : {0}";
        internal const string OptionIncorrect = "Your Option input is not Correct. Enter again";
        internal const string ExcStatement = "Exception Occured :";
        internal const string ValueIncorrect = "Only numeric value can be entered. Enter value again";
        internal const string ValueUnfeasible = "Your Entered value is not feasible.Your value can be between {0} and {1}.Enter value again";
        internal const string RectangleLength = " Enter Length of Rectangle";
        internal const string RectangleWidth = " Enter Width of Rectangle";
        internal const string CircleRadius = "Enter Circle Randius";
        internal const string XRadius = " Enter X-radius of Oval";
        internal const string YRadius = " Enter Y-radius of Oval";
        internal const string Quit = "yes";
        internal const string ClassName = " --> {0} Class";
        internal const string StrShape = "Shape class";
        internal const string ActiveObject = "Active Objects : {0}";
        internal const string Tab = "\t\t\t";
        internal const string Desh = "------------------------------------------------------------------------------------";
        internal const string ObjectCreated = "{0} Object Created. ";
        internal const string ObjectDeleted = "{0} Object Deleted. ";

        /// <summary>
        /// Below four constant is for option selection.
        /// </summary>
        internal const int Rectangle = 1;
        internal const int Oval = 2;
        internal const int Circle = 3;
        internal const int Exit = 4;

        /// <summary>
        /// Option Max value.
        /// </summary>
        internal const int UpperLimitOption = 4;

        /// <summary>
        /// Option Lowest value.
        /// </summary>
        internal const int LowerLimitOption = 1;

        /// <summary>
        /// Maximum value can be entered. 
        /// </summary>
        internal const int ValueMaxLimit = 999;

        /// <summary>
        /// Manimum value can be entered. 
        /// </summary>
        internal const int ValueMinLimit = 0;
    }
}
