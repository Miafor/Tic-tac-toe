using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    public class Person
    {
        public char Id { get; set; }

        public Person(char id)
        {
            Id = id;
        }

        public char[] Move(char [] arrayToChange, char number, char Id) 
        {
            for (int i = 0; i < arrayToChange.Length; i++)
            {
                    if(number == arrayToChange [i] ) 
                    {
                        arrayToChange[i] = Id;
                    }
                
            }
          return arrayToChange;
        }
        public bool PlayerWin(char[] play,char Id)
        {
            if (play[0].Equals(Id) && play[1].Equals(Id) && play[2].Equals(Id))
            {
                return true;
            }
            else if (play[0].Equals(Id) && play[4].Equals(Id) && play[8].Equals(Id))
            {
                return true;
            }
            else if (play[2].Equals(Id) && play[4].Equals(Id) && play[6].Equals(Id))
            {
                return true;
            }
            else if (play[1].Equals(Id) && play[4].Equals(Id) && play[7].Equals(Id))
            {
                return true;
            }
            else if (play[0].Equals(Id) && play[3].Equals(Id) && play[6].Equals(Id))
            {
                return true;
            }
            else if (play[2].Equals(Id) && play[5].Equals(Id) && play[8].Equals(Id))
            {
                return true;
            }
            else if (play[6].Equals(Id) && play[7].Equals(Id) && play[8].Equals(Id))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}
