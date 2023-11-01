namespace Square;

/// <summary>
/// Круг
/// </summary>
public class Circle : Figure
{
    /// <summary>
    /// Длина радиуса треугольника
    /// </summary>
    private readonly double _radius;

    /// <summary>
    /// Создает экземпляр <see cref="Circle"/>
    /// </summary>
    /// <param name="radius">Длина радиуса треугольника</param>
    public Circle(double radius)
    {
        _radius = radius;
    }

    /// <inheritdoc/>
    public override double GetSquare()
    {
        return Math.PI * _radius * _radius;
    }
}
