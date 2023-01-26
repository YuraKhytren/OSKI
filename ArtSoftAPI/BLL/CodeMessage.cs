using ArtSoftAPI.ProxyClases;

namespace ArtSoftAPI.BLL
{
    /// <summary>
    /// Клас для кодів відповіді
    /// </summary>
    public class CodeMessage
    {
        /// <summary>Успішна обробка</summary>
        public static ResponseBody SW_0001 => new ResponseBody { Code = "0001", Type = "SUCCESS", Message = "Повідомлення успішно оброблено" };
        /// <summary>Системна помилка при обробці повідомлення</summary>
        public static ResponseBody SW_0002 => new ResponseBody { Code = "0002", Type = "ERROR", Message = "Системна помилка при обробці повідомлення" };
        /// <summary>Перевищено час очікування при обробці повідомлення</summary>
        public static ResponseBody SW_0003 => new ResponseBody() { Code = "0003", Type = "TIMEOUT", Message = "Перевищено час очікування при обробці повідомлення" };
        public static ResponseBody SW_0004 => new ResponseBody() { Code = "0004", Type = "ERROR", Message = "Неіснує тесту з таким ID" };
        public static ResponseBody SW_0005 => new ResponseBody() { Code = "0005", Type = "ERROR", Message = "Неіснує питань та відповідей за таким ID" };
    }
}
