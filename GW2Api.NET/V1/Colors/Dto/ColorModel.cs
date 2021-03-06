﻿using System.Numerics;

namespace GW2Api.NET.V1.Colors.Dto
{
    public record ColorModel(
        int Brightness,
        double Contrast,
        int Hue,
        double Saturation,
        double Lightness,
        Vector3 Rgb
    );
}
