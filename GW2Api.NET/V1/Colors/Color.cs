namespace GW2Api.NET.V1.Colors
{
    public record Color(
        string ColorId,
        string Name,
        int[] BaseRgb,
        ColorModel Cloth,
        ColorModel Leather,
        ColorModel Metal,
        int? Item,
        string[] Categories
    );
}
