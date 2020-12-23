namespace КурсовойПроект.Service
{
    public static class Extensions
    {    // метод для входной строки, где вырезаем вхождение котроллер (бывает полезно для RedirectToAction)
        public static string CutController(this string str)
        {
            return str.Replace("Controller", "");
        }
    }
}
