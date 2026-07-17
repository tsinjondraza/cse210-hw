using System.ComponentModel.DataAnnotations;

public class Word
{
    private string _text;
    private bool _isHidden;
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        string text;
        if (_isHidden)
        {
            text = new string('_', _text.Length);
        }
        else
        {
            text = _text;
        }
        return text;
    }
}
