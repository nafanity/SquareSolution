using FluentAssertions;
using Xunit;

namespace Square.Tests;

public class FigureTests
{
    [Theory(DisplayName = "Проверяет вычисление площади фигур")]
    [MemberData(nameof(GetTestDataCheckSquare))]
    public void CheckSquare_ReturnSuccess(Figure figure, double expected)
    {
        // Arrange

        // Act
        var result = figure.GetSquare();

        // Assert
        result.Should().Be(expected);
    }

    [Theory(DisplayName = "Проверяет, является ли треугольник прямоугольным")]
    [MemberData(nameof(GetTestDataCheckTrinagleIsRectangular))]
    public void CheckTrinagleIsRectangular(double a, double b, double c, bool expected)
    {
        // Arrange
        var triange = new Triangle(a, b, c);

        // Act
        var result = triange.IsRectangular();

        // Assert
        result.Should().Be(expected);
    }

    /// <summary>
    /// Генерирует тестовые данные для <see cref="CheckSquare_ReturnSuccess"/>
    /// </summary>
    /// <returns></returns>
    public static TheoryData<Figure, double> GetTestDataCheckSquare()
    {
        return new TheoryData<Figure, double>
        {
            { new Circle(5), 78.53981633974483 },
            { new Triangle(3, 4, 5), 6 }
        };
    }

    /// <summary>
    /// Генерирует тестовые данные для <see cref="CheckTrinagleIsRectangular"/>
    /// </summary>
    /// <returns></returns>
    public static TheoryData<double, double, double, bool> GetTestDataCheckTrinagleIsRectangular()
    {
        return new TheoryData<double, double, double, bool>
        {
            { 3, 4, 5, true },
            { 3, 3, 5, false }
        };
    }
}
