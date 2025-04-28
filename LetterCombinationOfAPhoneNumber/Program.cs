 IList<string> LetterCombinations(string digits)
 {
        
     char[] digitArray = digits.ToCharArray();
     double countOfDigits = 0;

     for (int i = 0; i < digits.Length; i++)
     {
         countOfDigits *= char.GetNumericValue(digitArray[i]);

     }

     for (int i = 0; i < countOfDigits; i++)
     {
         
     }

     return new List<string>();
 }