namespace generics.interfaces;

public interface IPoppable<out T>

{
    T Pop();
}