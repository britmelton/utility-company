using FluentAssertions;

namespace Domain.Spec;

public class WhenCreatingAPremises
{
    [Fact]
    public void ThenPremisesIsExpected()
    {
        var address = new Address("1600 main st", "Columbus", "Ohio", "43206-6785", "US");
        var premises = Premises.New(address).Value;

        premises.Id.Should().NotBeEmpty();
        premises.Address.Should().Be(address);
    }
}
