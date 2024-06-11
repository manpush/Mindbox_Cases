namespace FigureCalc;

public abstract class Figure
{
    /// <summary>
    /// Площадь фигуры
    /// </summary>
    public abstract double Square { get; } 

    /// <summary>
    /// Название типа фигуры
    /// </summary>
    public abstract string TypeName { get; }
}