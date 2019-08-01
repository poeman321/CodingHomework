using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// the numbers you gave me were as follows:
//3.1-3.6   4.1-4.7    5.1-5.5      6.1-6.7     7.1-7.5

namespace CodingHomeWork
{
    public class ChapterThree
    {
        static void Main(string[] args)
        {
            //in the first exersize, the questions are as follows (with my answer's below them)

            //1. What is the vocaulary of a language? Give an example of an item in the vocabulary of Java
            //I wasnt terribly sure what the hell an 'Item' was, so im just guessing its something you assign a value to. In which case, the first part of the answer is what words the program will accept as commands, such as (for c#) Console, WriteLine or Readline. The second part of the answer is a string if im not mistaken

            //2. Give an example of a syntax rule in java
            // You said I could use C#, so how everything has to end in ; unless its about to lead into another program, or how you cant have unneccasary spaces

            //3. What does the expression (x + y) * z mean?
            //Add the variable X to Y and then multiply the outcome by Z

            //4. describe two differences between programming languages and natural languages
            // one, programming languages are meant to be a set of instructions for a computer to carry through while natural languages are supposed to be a method of exchanging ideas or feelings. two, breaking a rule in a natural language isnt a very big deal unless jaxon's around, whereas if you make the smallest error like forgetting to capitalize something, the computer shits itself and refuses to cooperate

        }
        static void ExersizeTwo(string[] args)
        {
            //1. what is the difference between 'double' and 'int' data types?
            //an int is much easier to type, but stores far less information. A double can hold such a vast amount of information that you'll never exceed unless you're trying to

            //2.How does the syntax for manipulating numeric data types and objects differ?
            // when one wishes to change the value of a numerical data type, they simply throw in the number and put * / + or - and some more numbers. it can get more complicated, but you get the point. whereas objects have to be assigned a new value instead of just adding things together.

            //3. Convert the following floating-point numbers to exponential notation.  23.5     0.046
            // 2.35E1      4.6E-2

            //4. convert the follwowing numbers from exponential notation to floating-point notation.       32.21E4     55.6E-3
            //322,100       0.0556

            //5. Give two examples of string literals
            // string Name = "Collin"       string Name2 = "Poe" (using c# cuz you said I could hahahhahaha or something)

            //6.declare a floating point variable called 'payRate' and simultaneously initialize it to $35.67
            float payRate = 35.67f;

            //7. declare three integer variables (a,b,c) in a single declaration and simultanieously initialize b to 4
            int a, b = 4, c;

            //8.give two examples of data that cannot be stored in a variable of type 'int'
            // int error = "ur mum gey";        int error2 = false

            //9.there are aproximatly 2.2 pounds in a kilogram. Name and declare a constant to represent this value
            //doing this in green text cuz c# flags it as an error cuz we cool kids dont have constants. but in java its written as  final float kiloPoundWeight = 2.2f;

            //10. it asked me to answer a bunch of questions, so ill just put the answers below cuz i donwanna type out the whole question  :P
            //20    -8          
        }
        static void ExersizeThree(string[] args)
        {
            
        }
    }
}