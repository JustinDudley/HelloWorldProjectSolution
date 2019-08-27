using System;

namespace Contact {
    class NewProgram {
        public static void Main(string[] args) {
            string Name = "Justin Dudley";
            string Address = "502 Park Ave.";
            string City = "Loveland";
            string State = "OH";
            string Zip = "45140";
            string Phone = "555-555-5555";
            string Email = "justin@gmail.com";

            Console.WriteLine("My name is " + Name);
            Console.WriteLine("My address is " + Address + ", " + City + ", " + State + " " + Zip);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("email: " + Email);
            
        }
    }
}
