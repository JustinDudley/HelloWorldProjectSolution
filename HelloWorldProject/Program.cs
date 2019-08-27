using System;

namespace HelloWorldProject {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello C# Boot Camp World!");
            Console.WriteLine("At MAX Technical Training");

            int daysInBootcamp = 6;
            if(daysInBootcamp == 6) {
                Console.WriteLine("Yes");
            } else {
                Console.WriteLine("No");
            }

            // looping
            // 1. you want to initialize index BEFORE you begin the while-loop
            // 2. need SOME mechanism to stop the loop
            // 3. last statement of body:  Increment the value that's going up
            // find sum of squares:   (ans should be 55?)
            var ints = new int[] { 1, 2, 3, 4, 5 };
            var total = 0;  // this is an accumulator
            //too much packed into too little
            var index = 0;  
            while(index < 5) {
                // body
                total = total + (ints[index] * ints[index]);
                index = index + 1; // remember, = is not "equals", it is an ASSIGNMENT OPERATOR
                //index += 1; // +=, LIKE =, IS AN ASSIGNMENT
            }
            Console.WriteLine("Total is " + total);  //C# will convert int to string, then contatenate

            //for-loop.  More recent invention than while loop. Does same thing, but it's less error-prone
            // for (   ;   ;   ) {  body  }
            // for (EXECUTES THIS THE FIRST TIME ONLY ; (bool-cond), then executes body of loop  ; increment the index )  {  body  }
            // nice thing about for-loop:  Body of loop ONLY has what the thing does.  Looks nice
            total = 0;  // didn't need to declare again.  We're just setting the value back to 0
            for (var idx = 0; idx < 5; idx = idx + 1) {
                total = total + (ints[idx] * ints[idx]);
            }
            Console.WriteLine("With for-loop, value is " + total);

            // C#:  integer division:  5/2 == 2
            //asmt:  Compute the average of some numbers:
            var scores = new int[] { 738, 609, 307, 959, 805, 689, 402, 972, 359, 140 };

            var newTotal = 0;
            for (int indx = 0; indx < scores.Length; indx++) {
                newTotal = newTotal + scores[indx];
            }
            int avg = newTotal / scores.Length;
            Console.WriteLine("The average of the ten integers is: " + avg);

            // a while-loop is good for reading from a Db.  While read-Db() == true.
            // so, for-loop is better for when you DO have an index.
            // while-loop is better if you have some other condition

            //  +=    -=     *=      /=      Assignment operators
            //  myInt++   myInt--         when the increment is 1   (for addition and subtraction only)
            //
            //  ++myInt   --myInt    is also valid.  But be careful:  See below:
            var a = 0;
            var b = a++; //1. b is set to a (in this case 0 -zero-)      2. a is incremented

            var apple = 0;
            var c = ++apple; //1. apple is incremented       2. c is set to apple  (in this case 1 -one- )

            // Greg sez:  Do not use single-letter variables, like i  -Too cryptic.  Don't be that guy, who's showing off.
            // use idx instead, for instance

            //technically, the "if-statement" is everything including the else and its {}
            //"block".  Need to get this word in my head.  I need flashcards!  My brain is yearning 
            // for flashcards.  C'mon Justin, let's LEARN

            // Okay, one more way to process this array
            // for-each     (foreach)
            // We use this if we want to look at each item in the collection:
            // Greg uses this much more than the other two. We should use it any time we can.
            // It's great, because it's hard to mess up
            // Pro tip:  You can use the inference term "var" all the time for this structure!
            var tot = 0;
            foreach (var score in scores) {     //instead of score, you might say "item"
                tot += score;
            }
            var average = tot / scores.Length;
            Console.WriteLine("Total, with foreach: " + average);

            string teacher = "";   //"empty string"
            //best practice:  Give your variable value right away, even if you know the value will change soon
            teacher = "Greg";  // again, = doesn't mean equals.  Stuff on R.H. side always gets
                                  // stuffed into the thing on the L.H. side
            Console.WriteLine(teacher);
            string lastname = "Doud";
            Console.WriteLine(teacher + " " + lastname);


            //floating point numbers:
            var distances = new double[] { 5.99, 3.56, 8.99, 7.47, 8.17, 6.78, 6.33, };
            double totality = 0;    // or:  var totality = 0.0;  ensures it's a double  //Note:  doulble, not float, is the default for var, if the system has to decide.
            foreach(var item in distances) {
                totality += item;
            }
            double aver = totality / distances.Length;
            Console.WriteLine("Average of distances: " + aver);

            

            //ARRAYS:
            // can't change number of buckets. Fixed.
            int[] students = new int[5];    // 5 buckets forever
            students[0] = 7;
            students[1] = 3;
            students[2] = 4;
            students[3] = 15;
            students[4] = 5;

            string[] names = new string[7];
            names[0] = "Jeremy";
            names[1] = "Alex";
            //etc. 
            // can even have arrays of arrays


            // One of the primary uses of Arrays: to read data from a database (And you often don't know the amt/length in advance)
            // So, there is a whole library of arrays that's been created, that can grow and shrink.

            //students.GetValue();


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
