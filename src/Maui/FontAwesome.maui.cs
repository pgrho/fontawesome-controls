using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Hosting;

namespace Shipwreck.FontAwesomeControls;

partial class FontAwesome
{
    public static void Init() { }

    public static IFontCollection AddFontAwesome(this IFontCollection fonts)
    {
        fonts.AddEmbeddedResourceFont(typeof(FontAwesome).Assembly, "fa-brands-400.ttf", "fa-brands-400");
        fonts.AddEmbeddedResourceFont(typeof(FontAwesome).Assembly, "fa-regular-400.ttf", "fa-regular-400");
        fonts.AddEmbeddedResourceFont(typeof(FontAwesome).Assembly, "fa-solid-900.ttf", "fa-solid-900");

        return fonts;
    }
}
