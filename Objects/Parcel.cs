using System.Collections.Generic;
namespace Boxes.Objects
{
  public class Parcel
  {
    private int _weight;
    private int _height;
    private int _width;
    private int _length;
    private int _volume;

    public Parcel (int newWeight, int newHeight, int newWidth, int newLength)
    {
      _weight = newWeight;
      _height = newHeight;
      _width = newWidth;
      _length = newLength;
    }

    public int GetWeight()
    {
      return _weight;
    }

    public void SetWeight(int newWeight)
    {
      _weight = newWeight;
    }

    public int GetHeight()
    {
      return _height;
    }

    public void SetHeight(int newHeight)
    {
      _height = newHeight;
    }

    public int GetWidth()
    {
      return _width;
    }

    public void SetWidth(int newWidth)
    {
      _width = newWidth;
    }

    public int GetLength()
    {
      return _length;
    }

    public void SetLength(int newLength)
    {
      _length = newLength;
    }

    public int Volume()
    {
      _volume = _width * _length * _height;
      return _volume;
    }

    public int CostToShip()
    {
      int cost = _volume * (_weight / 2);
      return cost;
    }
  }
}
