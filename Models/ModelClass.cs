using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IntegerChecker.Models
{
    public class IntegerRead
    {
        
        // Accessor and mutator for float variable types in order to check if user input is whole or decimal
        public float Input  // Grab user input
        { get;set;  }

        // Accessor and mutator for float variable in order to push input into the result and print back to user
        public float Result // Print result after checking cases
        { get; set; }

        // Accessor and mutator for string variables in order to communicate specific output or error
        public string Output 
        { get; set; }

    }
}

