using Microsoft.Data.SqlClient;

namespace ArtSoftAPI
{
    /// <summary>
    /// Клас з методами розширення
    /// </summary>
    public static partial class ExtendetMetod
    {
        public static object SqlValue<T>(this T item)
        {
            if (item is SqlParameter)
            {
                if ((item as SqlParameter).Value == DBNull.Value)
                    return null;
                else
                    return (item as SqlParameter).Value;
            }    
            else
            {
                if (item == null)
                    return DBNull.Value;
                else
                    return item;
            }
        }
    }
}
