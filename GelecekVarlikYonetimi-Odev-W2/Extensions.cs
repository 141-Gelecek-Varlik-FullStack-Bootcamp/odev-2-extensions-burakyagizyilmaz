using System.Linq;
using System;
using System.Web;
using System.Globalization;
using System.Text.RegularExpressions;

namespace GelecekVarlikYonetimi_Odev_W2
{
    public static class Extensions
    {
        // Seo yapısına uygun arama motoru dostu linkler oluşturmak için extension hazırlanmıştır.
        // Bir ürün adını veya bir blog başlığını sayfa linki olarak kullanmak istediğimizde kullanabiliriz.

        public static string ToSeoFriendlyLink(this string text)
        {
            //Boşlukları ve slash işaretlerini "-" ile değiştirdik
            text = text.Replace("/", "-");
            text = text.Replace(" ", "-");

            //Türkçe karakterleri ingilizce karaktere çevirdik
            text = text.Replace("ı", "i");
            text = text.Replace("İ", "I");
            text = text.Replace("Ş", "S");
            text = text.Replace("Ğ", "G");
            text = text.Replace("Ü", "U");
            text = text.Replace("Ç", "C");

            text = String.Join("", text.Normalize(System.Text.NormalizationForm.FormD)
                    .Where(c => char.GetUnicodeCategory(c) != UnicodeCategory.NonSpacingMark));

            text = HttpUtility.UrlEncode(text);
            text = Regex.Replace(text, @"\%[0-9A-Fa-f]{2}", "");
            return text;
        }
    }
}
