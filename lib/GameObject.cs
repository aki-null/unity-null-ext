using UnityEngine;
using System.Collections.Generic;

namespace UnityNull
{
    public static class UnityNullGameObject
    {
        public static GameObject Or(this GameObject self)
        {
            if (self == null) return null;
            return self;
        }

        public static Transform OrTransform(this GameObject self)
        {
            if (self == null) return null;
            return self.transform;
        }

        public static bool? OrIsStatic(this GameObject self)
        {
            if (self == null) return null;
            return self.isStatic;
        }

        public static void OrSetIsStatic(this GameObject self, bool? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.isStatic = val.Value;
        }

        public static bool? OrActiveInHierarchy(this GameObject self)
        {
            if (self == null) return null;
            return self.activeInHierarchy;
        }

        public static int? OrLayer(this GameObject self)
        {
            if (self == null) return null;
            return self.layer;
        }

        public static void OrSetLayer(this GameObject self, int? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.layer = val.Value;
        }

        public static UnityEngine.SceneManagement.Scene? OrScene(this GameObject self)
        {
            if (self == null) return null;
            return self.scene;
        }

        public static ulong? OrSceneCullingMask(this GameObject self)
        {
            if (self == null) return null;
            return self.sceneCullingMask;
        }

        public static string OrTag(this GameObject self)
        {
            if (self == null) return null;
            return self.tag;
        }

        public static void OrSetTag(this GameObject self, string val)
        {
            if (self == null) return;
            self.tag = val;
        }

        public static Component OrAddComponent(this GameObject self, System.Type componentType)
        {
            if (self == null) return null;
            return self.AddComponent(componentType);
        }

        public static T OrAddComponent<T>(this GameObject self) where T : Component
        {
            if (self == null) return null;
            return self.AddComponent<T>();
        }

        public static void OrBroadcastMessage(this GameObject self, string methodName, object parameter = null, SendMessageOptions options = SendMessageOptions.RequireReceiver)
        {
            if (self == null) return;
            self.BroadcastMessage(methodName, parameter, options);
        }

        public static bool OrCompareTag(this GameObject self, string tag)
        {
            if (self == null) return false;
            return self.CompareTag(tag);
        }

        public static T OrGetComponent<T>(this GameObject self) where T : class
        {
            if (self == null) return null;
            return self.GetComponent<T>();
        }

        public static Component OrGetComponent(this GameObject self, System.Type type)
        {
            if (self == null) return null;
            return self.GetComponent(type);
        }

        public static Component OrGetComponent(this GameObject self, string type)
        {
            if (self == null) return null;
            return self.GetComponent(type);
        }

        public static T OrGetComponentInChildren<T>(this GameObject self, bool includeInactive = false) where T : class
        {
            if (self == null) return null;
            return self.GetComponentInChildren<T>(includeInactive);
        }

        public static Component OrGetComponentInChildren(this GameObject self, System.Type type)
        {
            if (self == null) return null;
            return self.GetComponentInChildren(type);
        }

        public static Component OrGetComponentInChildren(this GameObject self, System.Type type, bool includeInactive)
        {
            if (self == null) return null;
            return self.GetComponentInChildren(type, includeInactive);
        }

        public static T OrGetComponentInParent<T>(this GameObject self) where T : class
        {
            if (self == null) return null;
            return self.GetComponentInParent<T>();
        }

        public static Component OrGetComponentInParent(this GameObject self, System.Type type)
        {
            if (self == null) return null;
            return self.GetComponentInParent(type);
        }

        public static Component OrGetComponentInParent(this GameObject self, System.Type type, bool includeInactive)
        {
            if (self == null) return null;
            return self.GetComponentInParent(type, includeInactive);
        }

        public static T[] OrGetComponents<T>(this GameObject self) where T : class
        {
            if (self == null) return null;
            return self.GetComponents<T>();
        }

        public static void OrGetComponents<T>(this GameObject self, List<T> results) where T : class
        {
            if (self == null) return;
            self.GetComponents<T>(results);
        }

        public static Component[] OrGetComponents(this GameObject self, System.Type type)
        {
            if (self == null) return null;
            return self.GetComponents(type);
        }

        public static void OrGetComponents(this GameObject self, System.Type type, List<Component> results)
        {
            if (self == null) return;
            self.GetComponents(type, results);
        }

        public static T[] OrGetComponentsInChildren<T>(this GameObject self) where T : class
        {
            if (self == null) return null;
            return self.GetComponentsInChildren<T>();
        }

        public static T[] OrGetComponentsInChildren<T>(this GameObject self, bool includeInactive) where T : class
        {
            if (self == null) return null;
            return self.GetComponentsInChildren<T>(includeInactive);
        }

        public static void OrGetComponentsInChildren<T>(this GameObject self, List<T> result) where T : class
        {
            if (self == null) return;
            self.GetComponentsInChildren<T>(result);
        }

        public static void OrGetComponentsInChildren<T>(this GameObject self, bool includeInactive, List<T> result) where T : class
        {
            if (self == null) return;
            self.GetComponentsInChildren<T>(includeInactive, result);
        }

        public static Component[] OrGetComponentsInChildren(this GameObject self, System.Type type, bool includeInactive = false)
        {
            if (self == null) return null;
            return self.GetComponentsInChildren(type, includeInactive);
        }

        public static T[] OrGetComponentsInParent<T>(this GameObject self) where T : class
        {
            if (self == null) return null;
            return self.GetComponentsInParent<T>();
        }

        public static T[] OrGetComponentsInParent<T>(this GameObject self, bool includeInactive) where T : class
        {
            if (self == null) return null;
            return self.GetComponentsInParent<T>(includeInactive);
        }

        public static void OrGetComponentsInParent<T>(this GameObject self, bool includeInactive, List<T> results) where T : class
        {
            if (self == null) return;
            self.GetComponentsInParent<T>(includeInactive, results);
        }

        public static Component[] OrGetComponentsInParent(this GameObject self, System.Type type, bool includeInactive = false)
        {
            if (self == null) return null;
            return self.GetComponentsInParent(type, includeInactive);
        }

        public static void OrSendMessage(this GameObject self, string methodName, object value = null, SendMessageOptions options = SendMessageOptions.RequireReceiver)
        {
            if (self == null) return;
            self.SendMessage(methodName, value, options);
        }

        public static void OrSendMessageUpwards(this GameObject self, string methodName, object value = null, SendMessageOptions options = SendMessageOptions.RequireReceiver)
        {
            if (self == null) return;
            self.SendMessageUpwards(methodName, value, options);
        }

        public static void OrSetActive(this GameObject self, bool value)
        {
            if (self == null) return;
            self.SetActive(value);
        }

        public static bool OrTryGetComponent<T>(this GameObject self, out T component) where T : class
        {
            component = default;

            if (self == null) return false;
            return self.TryGetComponent<T>(out component);
        }

        public static bool OrTryGetComponent(this GameObject self, System.Type type, out Component component)
        {
            component = default;

            if (self == null) return false;
            return self.TryGetComponent(type, out component);
        }
    }
}