using UnityEngine;
using System.Collections.Generic;

namespace UnityNull
{
    public static class UnityNullTransform
    {
        public static Transform Or(this Transform self)
        {
            if (self == null) return null;
            return self;
        }

        public static int? OrChildCount(this Transform self)
        {
            if (self == null) return null;
            return self.childCount;
        }

        public static Vector3? OrEulerAngles(this Transform self)
        {
            if (self == null) return null;
            return self.eulerAngles;
        }

        public static void OrSetEulerAngles(this Transform self, Vector3? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.eulerAngles = val.Value;
        }

        public static Vector3? OrForward(this Transform self)
        {
            if (self == null) return null;
            return self.forward;
        }

        public static void OrSetForward(this Transform self, Vector3? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.forward = val.Value;
        }

        public static bool? OrHasChanged(this Transform self)
        {
            if (self == null) return null;
            return self.hasChanged;
        }

        public static void OrSetHasChanged(this Transform self, bool? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.hasChanged = val.Value;
        }

        public static int? OrHierarchyCapacity(this Transform self)
        {
            if (self == null) return null;
            return self.hierarchyCapacity;
        }

        public static void OrSetHierarchyCapacity(this Transform self, int? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.hierarchyCapacity = val.Value;
        }

        public static int? OrHierarchyCount(this Transform self)
        {
            if (self == null) return null;
            return self.hierarchyCount;
        }

        public static Vector3? OrLocalEulerAngles(this Transform self)
        {
            if (self == null) return null;
            return self.localEulerAngles;
        }

        public static void OrSetLocalEulerAngles(this Transform self, Vector3? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.localEulerAngles = val.Value;
        }

        public static Vector3? OrLocalPosition(this Transform self)
        {
            if (self == null) return null;
            return self.localPosition;
        }

        public static void OrSetLocalPosition(this Transform self, Vector3? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.localPosition = val.Value;
        }

        public static Quaternion? OrLocalRotation(this Transform self)
        {
            if (self == null) return null;
            return self.localRotation;
        }

        public static void OrSetLocalRotation(this Transform self, Quaternion? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.localRotation = val.Value;
        }

        public static Vector3? OrLocalScale(this Transform self)
        {
            if (self == null) return null;
            return self.localScale;
        }

        public static void OrSetLocalScale(this Transform self, Vector3? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.localScale = val.Value;
        }

        public static Matrix4x4? OrLocalToWorldMatrix(this Transform self)
        {
            if (self == null) return null;
            return self.localToWorldMatrix;
        }

        public static Vector3? OrLossyScale(this Transform self)
        {
            if (self == null) return null;
            return self.lossyScale;
        }

        public static Transform OrParent(this Transform self)
        {
            if (self == null) return null;
            return self.parent;
        }

        public static void OrSetParent(this Transform self, Transform val)
        {
            if (self == null) return;
            self.parent = val;
        }

        public static Vector3? OrPosition(this Transform self)
        {
            if (self == null) return null;
            return self.position;
        }

        public static void OrSetPosition(this Transform self, Vector3? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.position = val.Value;
        }

        public static Vector3? OrRight(this Transform self)
        {
            if (self == null) return null;
            return self.right;
        }

        public static void OrSetRight(this Transform self, Vector3? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.right = val.Value;
        }

        public static Transform OrRoot(this Transform self)
        {
            if (self == null) return null;
            return self.root;
        }

        public static Quaternion? OrRotation(this Transform self)
        {
            if (self == null) return null;
            return self.rotation;
        }

        public static void OrSetRotation(this Transform self, Quaternion? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.rotation = val.Value;
        }

        public static Vector3? OrUp(this Transform self)
        {
            if (self == null) return null;
            return self.up;
        }

        public static void OrSetUp(this Transform self, Vector3? val)
        {
            if (self == null) return;
            if (val == null) return;
            self.up = val.Value;
        }

        public static Matrix4x4? OrWorldToLocalMatrix(this Transform self)
        {
            if (self == null) return null;
            return self.worldToLocalMatrix;
        }

        public static void OrDetachChildren(this Transform self)
        {
            if (self == null) return;
            self.DetachChildren();
        }

        public static Transform OrFind(this Transform self, string n)
        {
            if (self == null) return null;
            return self.Find(n);
        }

        public static Transform OrGetChild(this Transform self, int index)
        {
            if (self == null) return null;
            return self.GetChild(index);
        }

        public static void OrGetLocalPositionAndRotation(this Transform self, out Vector3 localPosition, out Quaternion localRotation)
        {
            localPosition = default;

            localRotation = default;

            if (self == null) return;
            self.GetLocalPositionAndRotation(out localPosition, out localRotation);
        }

        public static void OrGetPositionAndRotation(this Transform self, out Vector3 position, out Quaternion rotation)
        {
            position = default;

            rotation = default;

            if (self == null) return;
            self.GetPositionAndRotation(out position, out rotation);
        }

        public static int? OrGetSiblingIndex(this Transform self)
        {
            if (self == null) return null;
            return self.GetSiblingIndex();
        }

        public static Vector3? OrInverseTransformDirection(this Transform self, Vector3 direction)
        {
            if (self == null) return null;
            return self.InverseTransformDirection(direction);
        }

        public static Vector3? OrInverseTransformDirection(this Transform self, float x, float y, float z)
        {
            if (self == null) return null;
            return self.InverseTransformDirection(x, y, z);
        }

        public static Vector3? OrInverseTransformPoint(this Transform self, Vector3 position)
        {
            if (self == null) return null;
            return self.InverseTransformPoint(position);
        }

        public static Vector3? OrInverseTransformPoint(this Transform self, float x, float y, float z)
        {
            if (self == null) return null;
            return self.InverseTransformPoint(x, y, z);
        }

        public static Vector3? OrInverseTransformVector(this Transform self, Vector3 vector)
        {
            if (self == null) return null;
            return self.InverseTransformVector(vector);
        }

        public static Vector3? OrInverseTransformVector(this Transform self, float x, float y, float z)
        {
            if (self == null) return null;
            return self.InverseTransformVector(x, y, z);
        }

        public static bool OrIsChildOf(this Transform self, Transform parent)
        {
            if (self == null) return false;
            return self.IsChildOf(parent);
        }

        public static void OrLookAt(this Transform self, Transform target)
        {
            if (self == null) return;
            self.LookAt(target);
        }

        public static void OrLookAt(this Transform self, Transform target, Vector3 worldUp)
        {
            if (self == null) return;
            self.LookAt(target, worldUp);
        }

        public static void OrRotate(this Transform self, Vector3 eulers, Space relativeTo)
        {
            if (self == null) return;
            self.Rotate(eulers, relativeTo);
        }

        public static void OrRotate(this Transform self, float xAngle, float yAngle, float zAngle, Space relativeTo)
        {
            if (self == null) return;
            self.Rotate(xAngle, yAngle, zAngle, relativeTo);
        }

        public static void OrRotate(this Transform self, Vector3 axis, float angle, Space relativeTo)
        {
            if (self == null) return;
            self.Rotate(axis, angle, relativeTo);
        }

        public static void OrRotate(this Transform self, Vector3 eulers)
        {
            if (self == null) return;
            self.Rotate(eulers);
        }

        public static void OrRotate(this Transform self, float xAngle, float yAngle, float zAngle)
        {
            if (self == null) return;
            self.Rotate(xAngle, yAngle, zAngle);
        }

        public static void OrRotate(this Transform self, Vector3 axis, float angle)
        {
            if (self == null) return;
            self.Rotate(axis, angle);
        }

        public static void OrRotateAround(this Transform self, Vector3 point, Vector3 axis, float angle)
        {
            if (self == null) return;
            self.RotateAround(point, axis, angle);
        }

        public static void OrSetAsFirstSibling(this Transform self)
        {
            if (self == null) return;
            self.SetAsFirstSibling();
        }

        public static void OrSetAsLastSibling(this Transform self)
        {
            if (self == null) return;
            self.SetAsLastSibling();
        }

        public static void OrSetLocalPositionAndRotation(this Transform self, Vector3 localPosition, Quaternion localRotation)
        {
            if (self == null) return;
            self.SetLocalPositionAndRotation(localPosition, localRotation);
        }

        public static void OrSetParent(this Transform self, Transform parent, bool worldPositionStays)
        {
            if (self == null) return;
            self.SetParent(parent, worldPositionStays);
        }

        public static void OrSetPositionAndRotation(this Transform self, Vector3 position, Quaternion rotation)
        {
            if (self == null) return;
            self.SetPositionAndRotation(position, rotation);
        }

        public static void OrSetSiblingIndex(this Transform self, int index)
        {
            if (self == null) return;
            self.SetSiblingIndex(index);
        }

        public static Vector3? OrTransformDirection(this Transform self, Vector3 direction)
        {
            if (self == null) return null;
            return self.TransformDirection(direction);
        }

        public static Vector3? OrTransformDirection(this Transform self, float x, float y, float z)
        {
            if (self == null) return null;
            return self.TransformDirection(x, y, z);
        }

        public static Vector3? OrTransformPoint(this Transform self, Vector3 position)
        {
            if (self == null) return null;
            return self.TransformPoint(position);
        }

        public static Vector3? OrTransformPoint(this Transform self, float x, float y, float z)
        {
            if (self == null) return null;
            return self.TransformPoint(x, y, z);
        }

        public static Vector3? OrTransformVector(this Transform self, Vector3 vector)
        {
            if (self == null) return null;
            return self.TransformVector(vector);
        }

        public static Vector3? OrTransformVector(this Transform self, float x, float y, float z)
        {
            if (self == null) return null;
            return self.TransformVector(x, y, z);
        }

        public static void OrTranslate(this Transform self, Vector3 translation)
        {
            if (self == null) return;
            self.Translate(translation);
        }

        public static void OrTranslate(this Transform self, Vector3 translation, Space relativeTo)
        {
            if (self == null) return;
            self.Translate(translation, relativeTo);
        }

        public static void OrTranslate(this Transform self, Vector3 translation, Transform relativeTo)
        {
            if (self == null) return;
            self.Translate(translation, relativeTo);
        }

        public static void OrTranslate(this Transform self, float x, float y, float z, Transform relativeTo)
        {
            if (self == null) return;
            self.Translate(x, y, z, relativeTo);
        }
    }
}