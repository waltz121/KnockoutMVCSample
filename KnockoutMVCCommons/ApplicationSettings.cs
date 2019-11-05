using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnockoutMVCCommons
{
    public static class ApplicationSettings
    {
        private static string url;

        public static string Url
        {
            get { return url; }
            set { url = value; }
        }
    }
}
