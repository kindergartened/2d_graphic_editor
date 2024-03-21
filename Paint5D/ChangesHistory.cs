namespace Paint5D;

public class ChangesHistory
{
    private List<Bitmap> _changes;
    private int _currentIndex;

    public ChangesHistory()
    {
        _currentIndex = -1;
        _changes = new();
    }

    public void Undo(ref PictureBox pictureBox1, ref Graphics? graphics, ref Bitmap map)
    {
        if (_changes.Count > 0 && _currentIndex - 1 >= 0)
        {
            _currentIndex--;
            ApplyMap(ref pictureBox1, ref graphics, ref map);
        }
    }

    public void Redo(ref PictureBox pictureBox1, ref Graphics? graphics, ref Bitmap map)
    {
        if (_changes.Count > 0 && _currentIndex + 1 <= _changes.Count - 1 && _currentIndex >= 0)
        {
            _currentIndex++;
            ApplyMap(ref pictureBox1, ref graphics, ref map);
        }
    }

    private void ApplyMap(ref PictureBox pictureBox1, ref Graphics? graphics, ref Bitmap map)
    {
        map = new Bitmap(_changes[_currentIndex]);
        pictureBox1.Image = map;
        graphics.Clear(Color.White);
        graphics = Graphics.FromImage(map);
    }

    public void AddToHistory(Bitmap bitmap)
    {
        _changes.Add(new Bitmap(bitmap));
        _currentIndex++;
    }
}