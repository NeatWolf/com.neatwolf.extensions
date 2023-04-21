using UnityEngine;

namespace NeatWolf.Extensions
{
    public static class Vector3Utils
    {
        public static Vector3 WithX(this Vector3 vector, float value)
        {
            vector.x = value;
            return vector;
        }

        public static Vector3 WithY(this Vector3 vector, float value)
        {
            vector.y = value;
            return vector;
        }
        
        public static Vector3 WithZ(this Vector3 vector, float value)
        {
            vector.z = value;
            return vector;
        }

        public static Vector2 xy(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.y);
        }
        
        public static Vector2 yx(this Vector3 vector)
        {
            return new Vector2(vector.y, vector.x);
        }

        public static Vector2 xz(this Vector3 vector)
        {
            return new Vector2(vector.x, vector.z);
        }

        public static Vector2 zx(this Vector3 vector)
        {
            return new Vector2(vector.z, vector.x);
        }

        public static Vector2 yz(this Vector3 vector)
        {
            return new Vector2(vector.y, vector.z);
        }

        public static Vector2 zy(this Vector3 vector)
        {
            return new Vector2(vector.z, vector.y);
        }

        public static Vector2 xx(this Vector3 vector)
        {
            return Vector2.one * vector.x;
        }
        
        public static Vector2 yy(this Vector3 vector)
        {
            return Vector2.one * vector.y;
        }

        public static Vector2 zz(this Vector3 vector)
        {
            return Vector2.one * vector.z;
        }
    }
}