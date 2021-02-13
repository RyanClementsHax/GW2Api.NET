namespace GW2Api.NET.V1.Colors
{
    public record Color(
        string Name,
        int[] BaseRgb,
        ColorModel Cloth,
        ColorModel Leather,
        ColorModel Metal,
        int ItemId,
        string[] Categories
    );
}
