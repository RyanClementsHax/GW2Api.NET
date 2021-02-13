namespace GW2Api.NET.V1.Colors
{
    public record ColorModel(
        int Brightness,
        double Contrast,
        int Hue,
        double Saturation,
        double Lightness,
        int[] Rgb
    );
}
