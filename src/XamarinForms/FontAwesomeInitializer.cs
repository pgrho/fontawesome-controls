using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Shipwreck.FontAwesomeControls
{
    public static class FontAwesomeInitializer
    {
        static FontAwesomeInitializer()
        {
            var asm = typeof(FontAwesomeInitializer).Assembly;

            foreach (var ef in asm.GetCustomAttributes<ExportFontAttribute>())
            {
                var (hf, fn) = FontRegistrar.HasFont(Path.GetFileNameWithoutExtension(ef.FontFileName));
                if (!hf)
                {
                    FontRegistrar.Register(ef, asm);
                }
            }
        }

        public static void RegisterFonts()
        {
        }
    }
}
