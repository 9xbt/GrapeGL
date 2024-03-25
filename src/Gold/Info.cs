using Gold.Graphics;
using IL2CPU.API.Attribs;

namespace Gold;

public class Info
{
    [ManifestResourceStream(ResourceName = "GoGL.Resources.logo.bmp")]
    static byte[] GoldLogoRaw;

    public Canvas GoldLogo;

    public String getVersion()
    {
        return "0.0.1";
    }

    public String getApiVersion()
    {
        return "1.3";
    }

    public Canvas getLogo()
    {
        GoldLogo = Image.FromBitmap(GoldLogoRaw, false);
        return GoldLogo;
    }
}