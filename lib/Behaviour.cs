using UnityEngine;
using System.Collections.Generic;

namespace UnityNull
{
    public static class UnityNullBehaviour
    {
        public static Behaviour Or(this Behaviour self)
        {
            if (self == null) return null;
            return self;
        }

        public static bool? OrEnabled(this Behaviour self)
        {
            if (self == null) return null;
            return self.enabled;
        }

        public static void OrSetEnabled(this Behaviour self, bool? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.enabled = val.Value;
        }

        public static bool? OrIsActiveAndEnabled(this Behaviour self)
        {
            if (self == null) return null;
            return self.isActiveAndEnabled;
        }
    }
}