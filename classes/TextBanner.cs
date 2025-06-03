namespace generics.classes;

public class TextBanner()
{
    private Ring<string> _textBanner = new Ring<string>();

    public void Fill(string phrase)
    {
        foreach (string word in phrase.Split(' '))
        {
            System.Console.WriteLine(_textBanner!.Count + " : " + word);
            _textBanner.Push(word);
        }
    }

    public void Show()
    {
        for (int i = 0; i < _textBanner.Count; i++)
        {
            Console.Write($" {_textBanner[i]}");
        }
        Console.WriteLine();
    }
    public void RotateLeft() => _textBanner.RotateLeft();

    public void RotateRight() => _textBanner.RotateRight();

    public int Count() => _textBanner.Count;

    public string Peek() => _textBanner.Peek();

    public string Pop() => _textBanner.Pop();

    public void Push(string item) => _textBanner.Push(item);


}