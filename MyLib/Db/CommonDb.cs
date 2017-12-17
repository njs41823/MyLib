using System;

namespace MyLib.Db
{
    public class CommonDb
    {
        public static T DBNullHandler<T>(object value)
        {
            if (DBNull.Value.Equals(value) || !(value is T valueAsT))
            {
                return default(T);
            }
            return valueAsT;
        }
    }
}
