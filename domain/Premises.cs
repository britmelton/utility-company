using Jgs.Errors.Results;

namespace Domain;

public class Premises : Aggregate
{
    private Premises(Address address)
    {
        Address = address;
    }

    public Address Address { get; private set; }

    //factory method takes place of constructor bc constructor can't return Result
    public static Result<Premises> New(Address address) 
    {
        var premises = new Premises(address);

        return premises;
    }
}
