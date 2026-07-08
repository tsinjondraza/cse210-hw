public class Job
{
    public string _function = "";
    public string _startDate = "";
    public string _endDate = "";
    public string _companyName = "";
    public void DisplayJob()
    {
        Console.WriteLine($"{_function} ({_companyName}) {_startDate}-{_endDate},");
    }
}
