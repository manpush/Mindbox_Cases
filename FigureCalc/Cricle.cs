namespace FigureCalc;

public class Cricle:Figure
{
    #region Constructors
    /// <summary>
    /// Конструтктор класса "Круг"
    /// </summary>
    /// <param name="radius"></param>
    public Cricle(double radius)
    {
        Radius = radius;
    }

    #endregion
    

    #region Fields&Propeties
    
    /// <summary>
    /// Радиус окружности
    /// </summary>
    /*
     Не сказано про особенности фигур, считаем что речь про некий круг
     вне пространства, для его определения достаточно знать только радиус 
    */
    public double Radius
    {
        get => _radius;
        set => _radius = value;
    }
    private double _radius;
    
    /*
     TODO: В качестве расширения можно накинуть длину окружности (даже вместе с
     сеттером потому что по длине окружности можно определить радиус, соответственно всю фигуру) 
    */

    /// <summary>
    /// Площадь круга
    /// </summary>
    /*
        А кто мне запретит вести расчёты здесь? :) 
    */
    public override double Square
    {
        get => Math.PI * Math.Pow(Radius, 2);
    }

    public override string TypeName
    {
        get => "Круг";
    }
    
    #endregion

    
}