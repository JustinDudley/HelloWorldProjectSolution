using System;

namespace HelloWorldProject {
    class Program {
        public static void XMain(string[] args) {
            Console.WriteLine("Hello C# Boot Camp World!");
            Console.WriteLine("At MAX Technical Training");

            int daysInBootcamp = 6;
            if(daysInBootcamp == 6) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }
            //technically, the "if-statement" is everything including the else and its {}
            //"block".  Need to get this word in my head.  I need flashcards!  My brain is yearning 
            // for flashcards.  C'mon Justin, let's LEARN

            string instructor = "";   //"empty string"
            //best practice:  Give your variable value right away, even if you know the value will change soon
            instructor = "Greg";  // again, = doesn't mean equals.  Stuff on R.H. side always gets
                                  // stuffed into the thing on the L.H. side
            Console.WriteLine(instructor);
            string lastname = "Doud";
            Console.WriteLine(instructor + " " + lastname);

            // if(boolTest = false) //this is valid, but will give unexpected, crazy results.
            // You used a single =, not ==, so you aren't testing for equality.  You're assigning
            // false to your boolTest var.

            // = is assignment
            // == means 'Check for equality'
            //if(true)

            // program ends when you reach end of Main
            // "Shut this program down now!"
        }
    }
}
