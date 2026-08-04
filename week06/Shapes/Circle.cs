public class Circle : Shape
{
    private float _radius;
    public float GetRadius()
    {
        return _radius;
    }
    public void SetRadius(float radius)
    {
        _radius = radius;
    }
    public override float GetArea()
    {
        return _radius * _radius * 22 / 7;
    }

    internal void SetRadius(double v)
    {
        throw new NotImplementedException();
    }
}