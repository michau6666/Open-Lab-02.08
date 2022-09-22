using System;

namespace Open_Lab_02._08
{
    public class Checker
    {
        public bool IsEmpty(string str)
        {
            if (String.IsNullOrEmpty(str))
                return true;
            else
                return false;

        }
    }
}
