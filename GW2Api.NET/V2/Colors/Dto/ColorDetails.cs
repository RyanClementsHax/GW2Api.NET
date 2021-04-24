using System.Numerics;

namespace GW2Api.NET.V2.Colors.Dto
{
    public record ColorDetails(
        int Brightness,
        double Contrast,
        int Hue,
        double Saturation,
        double Lightness,
        Vector3 Rgb
    );
}