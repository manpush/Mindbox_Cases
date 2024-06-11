using FigureCalc;

namespace FigureCalcTests;

public class TriangleTests
{
    private Figure _testFigure; 

    [Test]
    public void Test1()
    {
        //Приводим к состоянию для тестирования
        _testFigure = new Triangle(1,1,1);
        //проверяем результат тестирования
        Assert.That(0.43, Is.EqualTo(_testFigure.Square).Within(0.01));
    }
    [Test]
    public void Test2()
    {
        try
        {
            //Приводим к состоянию для тестирования
            _testFigure = new Triangle(0,0,0);
            Assert.Fail();
        }
        catch (Exception e)
        {
            //проверяем результат тестирования
            Assert.Pass();
        }
    }
    [Test]
    public void Test3()
    {
        try
        {
            //Приводим к состоянию для тестирования
            _testFigure = new Triangle(-1,-1,-1);
            Assert.Fail();
        }
        catch (Exception e)
        {
            //проверяем результат тестирования
            Assert.Pass();
        }
    }

    [Test]
    public void Test4()
    {

        //Приводим к состоянию для тестирования
        _testFigure = new Triangle(3, 4, 5);
        Assert.That(true, Is.EqualTo(((Triangle)_testFigure).IsRectangular));
    }
    [Test]
    public void Test5()
    {

        //Приводим к состоянию для тестирования
        _testFigure = new Triangle(6, 6, 5);
        Assert.That(false, Is.EqualTo(((Triangle)_testFigure).IsRectangular));
    }
}