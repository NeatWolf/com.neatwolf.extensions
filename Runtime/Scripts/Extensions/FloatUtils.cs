using System;

namespace NeatWolf.Extensions
{
    public static class FloatUtils
    {
        public static int Floor(this float value)
        {
            return (int)MathF.Floor(value);
        }
    }
}