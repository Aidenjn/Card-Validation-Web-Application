using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_Card_Validator.CardValidation
{
    public class CardInputProcessing
    {

        // Function: get_response_string
        // Description: Returns response to inputted card number.
        // Uses Functions: 
        // Parameters: Card number entry.
        // Pre-Conditions: String
        // Post-Conditions: Appropriate string response
        // Return: Response string.
        public static string get_response_string(string input)
        {
            ulong cardNumber;
            bool isNumeric = ulong.TryParse(input, out cardNumber); // Check to see if string can be converted to a number.

            if (!isNumeric) // If not a valid number.
            {
                return "The number you entered is not valid.";
            }
            else if (!CardFunctions.is_correct_length(cardNumber)) // If number is an incorrect length.
            {
                return "The number you entered is not a valid length.";
            }
            else if (CardFunctions.luhn_check(cardNumber))  // If number does not pass luhn's algorithm.
            {
                return "The number you entered does not pass the luhn algorithm. \nMaybe you meant to type " + CardFunctions.get_corrected_number(cardNumber).ToString() + "?";
            }
            else
            {
                return "The number you entered is a valid card number!";
            }
        }
    }
}