public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    public Reference(string book, int chapterNumber, int verseFrom)
    {
        _book = book;
        _chapter = chapterNumber;
        _verse = verseFrom;
        _endVerse = verseFrom;
    }

    public Reference(string book, int chapterNumber, int verseFrom, int verseTo)
    {
        _book = book;
        _chapter = chapterNumber;
        _verse = verseFrom;
        _endVerse = verseTo;
    }
    public string GetDisplayText()
    {
        if (_endVerse == _verse)
        {
            return $"{_book} {_chapter}: {_verse}: ";
        }
        else
        {
            return $"{_book} {_chapter}: {_verse}-{_endVerse}: ";
        }
    }



}