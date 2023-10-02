namespace Domain;

public class Account : Entity
{
    public Account()
    {
        Premises = new();
    }
    public List<Premises> Premises { get; set; }


    public void Add(Premises premises)
    {
        Premises.Add(premises);
    }
}