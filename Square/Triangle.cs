namespace Square;

/// <summary>
/// Треугольник
/// </summary>
public class Triangle : Figure
{
    /// <summary>
    /// Длина первой стороны
    /// </summary>
    private readonly double _a;

    /// <summary>
    /// Длина второй стороны
    /// </summary>
    private readonly double _b;

    /// <summary>
    /// Длина третьей стороны
    /// </summary>
    private readonly double _c;

    /// <summary>
    /// Создает экземпляр <see cref="Triangle"/>
    /// </summary>
    /// <param name="a">Длина первой стороны</param>
    /// <param name="b">Длина второй стороны</param>
    /// <param name="c">Длина третьей стороны</param>
    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    /// <inheritdoc/>
    public override double GetSquare()
    {
        double p = (_a + _b + _c) / 2;
        return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
    }

    /// <summary>
    /// Проверяет является ли треугольник прямоугольным
    /// </summary>
    /// <returns>true если является, иначе false</returns>
    public bool IsRectangular()
    {
        var result = ((_a * _a + _b * _b == _c * _c)
            || (_a * _a + _c * _c == _b * _b)
            || (_c * _c + _b * _b == _a * _a));

        return result;
    }
}
