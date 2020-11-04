using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyTech
{
    static class Recruiter
    {
        private static string email;
        
        public static void SetEmail (string value)
        {
            email = value;
        }

        public static string GetEmail ()
        {
            return email;
        }
    }
}
