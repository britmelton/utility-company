using FluentAssertions;

namespace Domain.Spec;

public class WhenAddingPremisesToAccount
{
    [Fact]
    public void ThenAccountContainsPremises()
    {
        var address = new Address("345 main st", "columbus", "ohio", "43228", "Unites States");
        var premises = Premises.New(address).Value;
        var account = new Account();
        account.Add(premises);

        account.Premises.Should().Contain(premises);
        account.Id.Should().NotBeEmpty();
    }
}