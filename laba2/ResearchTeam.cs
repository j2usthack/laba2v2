namespace AllStaffNet6.laba2;

public class ResearchTeam
{
    private readonly string _researchName;
    private readonly string _organizationName;
    private readonly int _regNumber;
    private readonly TimeFrame _researchDuration;
    private Paper[] _papers;
    public ResearchTeam(string researchName, string organizationName, int regNumber, TimeFrame researchDuration, Paper[] papers)
    {
        _researchName = researchName;
        _organizationName = organizationName;
        _regNumber = regNumber;
        _researchDuration = researchDuration;
        _papers = papers;
    }
    public ResearchTeam()
    {
        _researchName = "Исследования Акакия";
        _organizationName = "ООО \"АкакийЦарьГрад\"";
        _regNumber = 123456;
        _researchDuration = TimeFrame.Long;
        _papers = new Paper[3]
        {
            new("Титул 1", new Person(), DateTime.Now),
            new("Титул 2", new Person(), DateTime.Now),
            new("Титул 3", new Person(), DateTime.Now),
        };
    }
    public string ResearchName => _researchName;
    public string OrganizationName => _organizationName;
    public int RegNumber => _regNumber;
    public TimeFrame ResearchDuration => _researchDuration;
    public Paper[]? Papers => _papers;
    public Paper? PaperLast => _papers?.OrderBy(x => x.PublicationDate).LastOrDefault();
    public void AddPapers(params Paper[] newPapers)
    {
        _papers = _papers.Concat(newPapers).ToArray();
    }
    public string ToFullString()
    {
        string full = $"Тема: {_researchName}\n" +
            $"Название: {_organizationName}\n" +
            $"Рег. номер: {_regNumber}\n" +
            $"Продолжительность исследований: {_researchDuration}\n" +
            $"Список публикаций: \n";
        foreach (var item in _papers)
        {
            full += $"{item.ToFullString()} \n";
        }
        full += $"Последняя публикация:\n{PaperLast.ToFullString()}";
        return full;
    }
    public string ToShortString()
    {
        return $"Тема: {_researchName}\n" +
            $"Название: {_organizationName}\n" +
            $"Рег. номер: {_regNumber}\n" +
            $"Продолжительность исследований: {_researchDuration}\n" +
            $"Список публикаций: ";
    }
}