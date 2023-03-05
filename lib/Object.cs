using UnityEngine;
using System.Collections.Generic;

namespace UnityNull
{
    public static class UnityNullObject
    {
        public static Object Or(this Object self)
        {
            if (self == null) return null;
            return self;
        }

        public static HideFlags? OrHideFlags(this Object self)
        {
            if (self == null) return null;
            return self.hideFlags;
        }

        public static void OrSetHideFlags(this Object self, HideFlags? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.hideFlags = val.Value;
        }

        public static string OrName(this Object self)
        {
            if (self == null) return null;
            return self.name;
        }

        public static void OrSetName(this Object self, string val)
        {
            if (self == null) return;
            self.name = val;
        }

        public static int? OrGetInstanceID(this Object self)
        {
            if (self == null) return null;
            return self.GetInstanceID();
        }

        public static string OrToString(this Object self)
        {
            if (self == null) return null;
            return self.ToString();
        }
    }
}