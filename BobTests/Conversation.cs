using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BobTests
{
    public class Conversation
    {
        public static string Reply(string statement)
        {
            if (IsSayingNothing(statement))
                return "Whatever.";

            if (IsYelling(statement) && IsAskingQuestion(statement))
                return "I don't like you.";
          
            if (IsYelling(statement))
                return "Stop yelling!";

            if (IsAskingQuestion(statement))
                return "Sure.";

            else
                return "Find be that way!";


        }

        private static bool IsSayingNothing(string statement)
        {
            return statement == null || statement == "" || statement == " ";
        }

        private static bool IsAskingQuestion(string statement)
        {
            if (statement.EndsWith("?"))
                return true;
            return false;
        }

        public static bool IsYelling(string statement)
        {
            if (statement.ToUpperInvariant()== statement)
                return true;
            return false;
        }
    }
}
