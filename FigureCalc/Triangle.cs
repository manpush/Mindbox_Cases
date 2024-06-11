namespace FigureCalc;

public class Triangle:Figure
{
    public Triangle(double l1, double l2, double l3)
    {
        if ((l1 == 0 && l2 == 0 && l3 == 0) || (l1 < 0 || l2 < 0 || l3 < 0)) throw new Exception();
        _l[0] = l1;
        _l[1] = l2;
        _l[2] = l3;
    }

    #region Fields&Propeties
    
    private readonly List<double> _l = new(3){0,0,0};
    /// <summary>
    /// Признак прямоугольного треугольника
    /// </summary>
    /*
     * определяю по теореме обратной теореме пифагора:
     * если квадрат самой длинной стороны треугольника равен сумме квадратов
     * двух других сторон, то этот треугольник прямоугольный
     */
    public bool IsRectangular
    {
        get
        {
            double maxVal = _l.Max();
            return Math.Pow(maxVal, 2) == _l.FindAll(x=>x!=maxVal).Sum( x=>Math.Pow(x,2));
        }
    }

    #endregion
    /*
     * вынесу ка эти вычисления в lazyload, не будем лишний раз брать корень :)
     */
    public override double Square
    {
        get
        {
            if (_square is not null) return (double)_square; //если ранее подсчитали, то выводим старый подсчёт
            double p = (_l[0]+_l[1]+_l[2]) * 0.5; //полупериметр
            return (double)(_square = Math.Sqrt(p * (p - _l[0]) * (p - _l[1]) * (p - _l[2]))); //честно, герона гуглил :)
        }
    }

    private double? _square;
    
    public override string TypeName
    {
        get => "Треугольник";
    }
}