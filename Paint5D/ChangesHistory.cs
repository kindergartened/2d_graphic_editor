namespace Paint5D;

public class ChangesHistory
{
    private List<Bitmap> _changes;
    private int _currentIndex;

    /// <summary>
    /// В конструкторе инициализируется список 
    /// _changes и текущий индекс _currentIndex.
    /// </summary>
    public ChangesHistory()
    {
        _currentIndex = -1;
        _changes = new();
    }

    /// <summary>
    /// Метод позволяет отменить последнее действие пользователя. 
    /// Если в списке _changes есть предыдущее состояние, 
    /// то текущий индекс уменьшается, и состояние из списка применяется к PictureBox.
    /// </summary>
    /// <param name="pictureBox1">область рисования</param>
    /// <param name="graphics">графика</param>
    /// <param name="map">битмапа</param>
    public void Undo(ref PictureBox pictureBox1, ref Graphics? graphics, ref Bitmap map)
    {
        if (_changes.Count > 0 && _currentIndex - 1 >= 0)
        {
            _currentIndex--;
            ApplyMap(ref pictureBox1, ref graphics, ref map);
        }
    }

    /// <summary>
    /// Метод позволяет повторить последнее отмененное действие пользователя. 
    /// Если в списке _changes есть следующее состояние, то текущий индекс увеличивается, 
    /// и состояние из списка применяется к PictureBox.
    /// </summary>
    /// <param name="pictureBox1">область рисования</param>
    /// <param name="graphics">графика</param>
    /// <param name="map">битмапа</param>
    public void Redo(ref PictureBox pictureBox1, ref Graphics? graphics, ref Bitmap map)
    {
        if (_changes.Count > 0 && _currentIndex + 1 <= _changes.Count - 1 && _currentIndex >= 0)
        {
            _currentIndex++;
            ApplyMap(ref pictureBox1, ref graphics, ref map);
        }
    }

    /// <summary>
    /// Метод ApplyMap применяется для применения состояния из списка _changes к PictureBox. 
    /// Он создает новый экземпляр Bitmap из состояния в списке, 
    /// устанавливает его как изображение PictureBox и очищает графику.
    /// </summary>
    /// <param name="pictureBox1">область рисования</param>
    /// <param name="graphics">графика</param>
    /// <param name="map">битмапа</param>
    private void ApplyMap(ref PictureBox pictureBox1, ref Graphics? graphics, ref Bitmap map)
    {
        map = new Bitmap(_changes[_currentIndex]);
        pictureBox1.Image = map;
        graphics.Clear(Color.White);
        graphics = Graphics.FromImage(map);
    }

    /// <summary>
    /// Метод AddToHistory добавляет новое состояние в список _changes и увеличивает текущий индекс.
    /// </summary>
    /// <param name="bitmap">битмапа</param>
    public void AddToHistory(Bitmap bitmap)
    {
        _changes.Add(new Bitmap(bitmap));
        _currentIndex++;
    }
}