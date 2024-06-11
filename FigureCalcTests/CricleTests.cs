using FigureCalc;

namespace FigureCalcTests;

public class CricleTests
{
    private Figure _testFigure; 

    [Test]
    public void Test1()
    {
        //Приводим к состоянию для тестирования
        _testFigure = new Cricle(3);
        //проверяем результат тестирования
        Assert.AreEqual(_testFigure.Square, 28.27, 0.01);
    }
    [Test]
    public void Test2()
    {
        //Приводим к состоянию для тестирования
        _testFigure = new Cricle(0);
        //проверяем результат тестирования
        Assert.AreEqual(_testFigure.Square, 0, 0.01);
    }
    [Test]
    public void Test3()
    {
        //Приводим к состоянию для тестирования
        _testFigure = new Cricle(-10);
        //проверяем результат тестирования
        Assert.AreEqual(_testFigure.Square, 314.15, 0.01);
    }
}