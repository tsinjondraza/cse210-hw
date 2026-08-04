public class Square : Shape
{
    private float _side;
    public float GetSide()
    {
        return _side;
    }
    public void SetSide(float side)
    {
        _side = side;
    }
    public override float GetArea()
    {
        return _side * _side;
    }

}