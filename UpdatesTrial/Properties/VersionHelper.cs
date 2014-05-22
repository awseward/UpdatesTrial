using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace UpdatesTrial.Properties
{
    public static class VersionHelper
    {
        public static String VersionString
        {
            get { return GetVersionString(); }
        }

        private static String GetVersionString()
        {
            var assembly = typeof(VersionHelper).Assembly;
            return FileVersionInfo.GetVersionInfo(assembly.Location).ProductVersion;
        }
    }
}
