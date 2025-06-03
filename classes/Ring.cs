using System.Collections;
using System.Dynamic;
using System.Runtime.CompilerServices;
using generics.interfaces;

namespace generics.classes;

public class Ring<T>() : IRotable, IEnumerable, IPushable<T>, IPoppable<T>
{
    public int Position { get; set; } = 0;
    public int Count { get; set; } = 0;

    private List<T> _ring = new List<T>();  //Storage list


    public T? this[int index] => _ring[index];
    // {
    //     get => Count == 0 ? default(T) : _ring[(Position + index) % Count];
    //     set
    //     {
    //         if (Count == 0)
    //         {
    //             _ring[0] = value!;
    //             Position = 0;
    //             Count++;
    //         }
    //         else
    //         {
    //             _ring[(Position + index) % Count] = value!;
    //         }
    //     }
    // }

    public void Push(T item)
    {
        if (Count == 0) { _ring.Insert(Position, item); }
        else
        {
            _ring.Insert(++Position, item);
        }
        Count++;
    }

    public void RotateLeft()   // => Position = (Position - 1 + Count) % Count;
    {
        Position--;
        if (Position < 0) Position = Count - 1;
    }

    public void RotateRight() //=> Position = (Position + 1) % Count;
    {
        Position++;
        if (Position == Count) Position = 0;
    }

    public T Peek() => _ring[Position];

    public T Pop()
    {
        if (Count > 0)
        {
            T item = _ring[Position];
            _ring.RemoveAt(Position);
            Count--;
            return item;
        }
        return default(T)!;

    }

    public IEnumerator GetEnumerator()
    {
        if (Count == 0) yield return null;
        else
        {
            for (int i = 0; i < Count; i++)
            {
                yield return _ring[(Position + i) % Count];
            }
        }
    }
}
