using UnityEngine;

namespace NeatWolf.Extensions
{
    public static class Vector2Utils
    {
        public static float ToDegreeLocalAngle(this Vector2 vector2)
        {
            return Mathf.Atan2(vector2.y, vector2.x) * Mathf.Rad2Deg;
        }

        public static Vector2 WithX(this Vector2 vector, float value)
        {
            vector.x = value;
            return vector;
        }

        public static Vector2 WithY(this Vector2 vector, float value)
        {
            vector.y = value;
            return vector;
        }

        public static Vector2 InvertingX(this Vector2 vector)
        {
            vector.x *= -1;
            return vector;
        }
        
        public static Vector2 InvertingY(this Vector2 vector)
        {
            vector.y *= -1;
            return vector;
        }
    }
}