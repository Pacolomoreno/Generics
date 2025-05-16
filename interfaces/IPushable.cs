namespace generics.interfaces;

public interface IPushable<in T>

{
    void Push(T item);
}
