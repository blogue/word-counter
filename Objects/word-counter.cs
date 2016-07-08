using System;
using System.Collections.Generic;


 namespace WordCounter
{
  public class Counter
  {


    public int FindWord(string userString, string userWord)
    {
      int wordCounter = 0;
      char[] delimCharacters = {' ', ','};
      string[] userStringArray = userString.Split(delimCharacters);

      for(int i=0; i<userStringArray.Length; i++)
      {
        if (userStringArray[i].ToLower().Contains(userWord.ToLower()))
        {
          wordCounter++;
        }
      }
      return wordCounter;
    }
  }
}
