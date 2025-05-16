using System.Collections;
using generics.interfaces;

namespace generics.classes;

public class Ring<T> : IRotable, IEnumerable, IPushable<T>, IPoppable<T>
{
    private int _count = 0;
    public List<T> _ring = [];  //Storage list

    public IEnumerator GetEnumerator()
    {
        return _ring.GetEnumerator();
    }

    public void Push(T item)
    {
        _ring.Add(item);
        _count++;
    }
    public void RotateLeft()
    {
        if (_count > 0)
        {
            _ring.Add(_ring[0]);
            _ring.RemoveAt(0);
        }
    }

    public void RotateRight()
    {
        if (_count > 0)
        {
            _ring.Insert(0, _ring[_count - 1]);
            _ring.RemoveAt(_count);
        }
    }

    public T Pop()
    {
        if (_count > 0)
        {
            T item = _ring[0];
            _ring.RemoveAt(0);
            _count--;
            return item;
        }
        return default(T);

    }
}
