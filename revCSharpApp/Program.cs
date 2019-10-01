using System;

namespace revCSharpApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // make bool, string, and int variables (with values)
            bool itsABool = true;
            string itsAString = "It's a string";
            int rent = 525600;

            // change their values to something else
            itsABool = false;
            itsAString = "It's another string";
            rent *= 2;

            // print their values with Console
            Console.WriteLine("The 3 values are " + itsABool + ", " + itsAString +  ", and " + rent +  ".");

            // do something in a for loop
            for(int i=0 ; i<10 ; i++){
                Console.WriteLine(i);
            }

            // do something in a while loop
            int m = 10;
            while(m>0){
                Console.WriteLine(m);
                m--;
            }
            // do something with a switch statement
            switch (m)
            {
                case 1:
                    Console.WriteLine("m is " + m);
                    break;
                case 0:
                    Console.WriteLine("m is " + m);
                    break;
                default:
                    Console.WriteLine("we've hit the default");                    
                    break;

            }

            // do something with if, else if, else
            if(m==1){
                Console.WriteLine("m is 1");                    
            }
            else if(m==2){
                Console.WriteLine("m is 2");                    
            }
            else if(m==0){
                Console.WriteLine("m is still 0");
            }
            else{
                Console.WriteLine("this is the 'else'");                    
            }


            // figure out how to make multi-line comments in C#
            
            /*
            this
            is 
            a
            multiline
            comment 
            */


            // figure out how to format your document in VS Code


            // extra: make a new static method to do something and call it
            static void methodName(string string1){
                 Console.WriteLine(string1);
            }

            methodName("I'm in the method!");

            // extra: learn what "var" means in C# and try it out.
            var itsanothertring = "This is what a var is...";
            var def = "Beginning in Visual C# 3.0, variables that are declared at method"
                         + "scope can have an implicit type var. An implicitly typed local "
                         + "variable is strongly typed just as if you had declared the type "
                         + "yourself, but the compiler determines the type.";

            var concatStrings = itsanothertring + def;
            // methodName(concatStrings);
            methodName(itsanothertring + def);
        }
    }
}
