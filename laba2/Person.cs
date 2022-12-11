using System.Text.RegularExpressions;

namespace AllStaffNet6.laba2;

public class Person
{
    private string _firstName;
    private readonly string _lastName;
    private DateTime _birthDate;
    public Person(string firstName, string lastName, DateTime birthDate)
    {
        _firstName = firstName;
        _lastName = lastName;
        _birthDate = birthDate;
    }
    public Person()
    {
        _firstName = "акаКиЙ";
        _lastName = "Викторович";
        _birthDate = new(1995, 6, 23);
    }
    public string FirstName
    {
        get { return _firstName.Substring(0,1).ToUpper() + _firstName.Substring(1).ToLower(); }
        set 
        {
            if (Regex.IsMatch(value, "^[A-ZА-ЯЁ][a-zа-яё]{2,}$"))
            {
                _firstName = value;
            }
            else
            {
                throw new ArgumentException($"Invalid first name value {value}");
            }
        }
    }
    public string LastName => _lastName;
    public DateTime BirthDate => _birthDate;
    public int BirthYear
    {
        get => _birthDate.Year;
        set => _birthDate = new(value, _birthDate.Month, _birthDate.Day, _birthDate.Hour, _birthDate.Minute, _birthDate.Second);
    }
    public string ToFullString()
    {
        return $"Фамилия: {_lastName}\n" +
            $"Имя: {_firstName}\n" +
            $"Дата рождения: {_birthDate:dd.MM.yyyy}";
    }
    public string ToShortString() => $"Фамилия: {_lastName}\nИмя: {_firstName}";
}