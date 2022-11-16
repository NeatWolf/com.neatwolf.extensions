using UnityEngine;

namespace NeatWolf.Extensions
{
    public static class TransformUtils
    {
        public static Vector3 SetLocalEulerAngleX(this Transform transform, float value)
        {
            Vector3 localEulerAngles = transform.localEulerAngles;
            localEulerAngles.x         = value;
            transform.localEulerAngles = localEulerAngles;

            return localEulerAngles;
        }
        
        public static Vector3 SetLocalEulerAngleY(this Transform transform, float value)
        {
            Vector3 localEulerAngles = transform.localEulerAngles;
            localEulerAngles.y         = value;
            transform.localEulerAngles = localEulerAngles;

            return localEulerAngles;
        }

        public static Vector3 SetLocalEulerAngleZ(this Transform transform, float value)
        {
            Vector3 localEulerAngles = transform.localEulerAngles;
            localEulerAngles.z         = value;
            transform.localEulerAngles = localEulerAngles;

            return localEulerAngles;
        }
    }
}