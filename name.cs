internal class Name
{
    private string surname;
    private string name;
    private string patronym;

    public Name()
    {
        this.surname = "Иванов";
        this.name = "Иван";
        this.patronym = "Иванович";
    }
    public Name(string surname, string name, string patronym) {
        this.surname = surname;
        this.name = name;
        this.patronym = patronym;
    }
    public Name(string name, string surname)
    {
        this.surname = surname;
        this.name = name;
        this.patronym = "";
    }
    public Name(string name)
    {
        this.surname = "";
        this.name = name;
        this.patronym = "";
    }

    public override string ToString()
    {
        string s = this.surname + " " + this.name + " " + this.patronym;
        return s.Trim();
    }
}
