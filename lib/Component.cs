using UnityEngine;
using System.Collections.Generic;

namespace UnityNull
{
    public static class UnityNullComponent
    {
        public static Component Or(this Component self)
        {
            if (self == null) return null;
            return self;
        }

        public static GameObject OrGameObject(this Component self)
        {
            if (self == null) return null;
            return self.gameObject;
        }

        public static string OrTag(this Component self)
        {
            if (self == null) return null;
            return self.tag;
        }

        public static void OrSetTag(this Component self, string val)
        {
            if (self == null) return;
            self.tag = val;
        }

        public static Transform OrTransform(this Component self)
        {
            if (self == null) return null;
            return self.transform;
        }

        public static void OrBroadcastMessage(this Component self, string methodName, object parameter = null, SendMessageOptions options = SendMessageOptions.RequireReceiver)
        {
            if (self == null) return;
            self.BroadcastMessage(methodName, parameter, options);
        }

        public static void OrBroadcastMessage(this Component self, string methodName, SendMessageOptions options)
        {
            if (self == null) return;
            self.BroadcastMessage(methodName, options);
        }

        public static bool OrCompareTag(this Component self, string tag)
        {
            if (self == null) return false;
            return self.CompareTag(tag);
        }

        public static T OrGetComponent<T>(this Component self) where T : class
        {
            if (self == null) return null;
            return self.GetComponent<T>();
        }

        public static Component OrGetComponent(this Component self, System.Type type)
        {
            if (self == null) return null;
            return self.GetComponent(type);
        }

        public static Component OrGetComponent(this Component self, string type)
        {
            if (self == null) return null;
            return self.GetComponent(type);
        }

        public static T OrGetComponentInChildren<T>(this Component self, bool includeInactive = false) where T : class
        {
            if (self == null) return null;
            return self.GetComponentInChildren<T>(includeInactive);
        }

        public static Component OrGetComponentInChildren(this Component self, System.Type type)
        {
            if (self == null) return null;
            return self.GetComponentInChildren(type);
        }

        public static Component OrGetComponentInChildren(this Component self, System.Type type, bool includeInactive)
        {
            if (self == null) return null;
            return self.GetComponentInChildren(type, includeInactive);
        }

        public static T OrGetComponentInParent<T>(this Component self) where T : class
        {
            if (self == null) return null;
            return self.GetComponentInParent<T>();
        }

        public static T OrGetComponentInParent<T>(this Component self, bool includeInactive = false) where T : class
        {
            if (self == null) return null;
            return self.GetComponentInParent<T>(includeInactive);
        }

        public static Component OrGetComponentInParent(this Component self, System.Type type)
        {
            if (self == null) return null;
            return self.GetComponentInParent(type);
        }

        public static Component OrGetComponentInParent(this Component self, System.Type type, bool includeInactive)
        {
            if (self == null) return null;
            return self.GetComponentInParent(type, includeInactive);
        }

        public static T[] OrGetComponents<T>(this Component self) where T : class
        {
            if (self == null) return null;
            return self.GetComponents<T>();
        }

        public static void OrGetComponents<T>(this Component self, List<T> results) where T : class
        {
            if (self == null) return;
            self.GetComponents<T>(results);
        }

        public static Component[] OrGetComponents(this Component self, System.Type type)
        {
            if (self == null) return null;
            return self.GetComponents(type);
        }

        public static void OrGetComponents(this Component self, System.Type type, List<Component> results)
        {
            if (self == null) return;
            self.GetComponents(type, results);
        }

        public static T[] OrGetComponentsInChildren<T>(this Component self) where T : class
        {
            if (self == null) return null;
            return self.GetComponentsInChildren<T>();
        }

        public static T[] OrGetComponentsInChildren<T>(this Component self, bool includeInactive) where T : class
        {
            if (self == null) return null;
            return self.GetComponentsInChildren<T>(includeInactive);
        }

        public static void OrGetComponentsInChildren<T>(this Component self, List<T> result) where T : class
        {
            if (self == null) return;
            self.GetComponentsInChildren<T>(result);
        }

        public static void OrGetComponentsInChildren<T>(this Component self, bool includeInactive, List<T> result) where T : class
        {
            if (self == null) return;
            self.GetComponentsInChildren<T>(includeInactive, result);
        }

        public static Component[] OrGetComponentsInChildren(this Component self, System.Type type, bool includeInactive)
        {
            if (self == null) return null;
            return self.GetComponentsInChildren(type, includeInactive);
        }

        public static T[] OrGetComponentsInParent<T>(this Component self) where T : class
        {
            if (self == null) return null;
            return self.GetComponentsInParent<T>();
        }

        public static T[] OrGetComponentsInParent<T>(this Component self, bool includeInactive) where T : class
        {
            if (self == null) return null;
            return self.GetComponentsInParent<T>(includeInactive);
        }

        public static void OrGetComponentsInParent<T>(this Component self, bool includeInactive, List<T> results) where T : class
        {
            if (self == null) return;
            self.GetComponentsInParent<T>(includeInactive, results);
        }

        public static Component[] OrGetComponentsInParent(this Component self, System.Type type, bool includeInactive = false)
        {
            if (self == null) return null;
            return self.GetComponentsInParent(type, includeInactive);
        }

        public static void OrSendMessage(this Component self, string methodName)
        {
            if (self == null) return;
            self.SendMessage(methodName);
        }

        public static void OrSendMessage(this Component self, string methodName, object value)
        {
            if (self == null) return;
            self.SendMessage(methodName, value);
        }

        public static void OrSendMessage(this Component self, string methodName, object value, SendMessageOptions options)
        {
            if (self == null) return;
            self.SendMessage(methodName, value, options);
        }

        public static void OrSendMessage(this Component self, string methodName, SendMessageOptions options)
        {
            if (self == null) return;
            self.SendMessage(methodName, options);
        }

        public static void OrSendMessageUpwards(this Component self, string methodName, SendMessageOptions options)
        {
            if (self == null) return;
            self.SendMessageUpwards(methodName, options);
        }

        public static void OrSendMessageUpwards(this Component self, string methodName, object value = null, SendMessageOptions options = SendMessageOptions.RequireReceiver)
        {
            if (self == null) return;
            self.SendMessageUpwards(methodName, value, options);
        }

        public static bool OrTryGetComponent<T>(this Component self, out T component) where T : class
        {
            component = default;

            if (self == null) return false;
            return self.TryGetComponent<T>(out component);
        }

        public static bool OrTryGetComponent(this Component self, System.Type type, out Component component)
        {
            component = default;

            if (self == null) return false;
            return self.TryGetComponent(type, out component);
        }
    }
}