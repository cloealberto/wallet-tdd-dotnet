using FluentAssertions;
using Wallet.Domain;
using Xunit;

namespace Wallet.Domain.Tests;

public class AccountTests
{
    [Fact]
    public void Deposit_positive_amount_increases_balance()
    {
        var acc = new Account(initialBalance: 10m);

        acc.Deposit(5m);

        acc.Balance.Should().Be(15m);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-1)]
    public void Deposit_zero_or_negative_throws(decimal amount)
    {
        var acc = new Account();

        var act = () => acc.Deposit(amount);

        act.Should().Throw<ArgumentOutOfRangeException>();
    }

    [Fact]
    public void Withdraw_valid_amount_decreases_balance()
    {
        var acc = new Account(initialBalance: 20m);

        acc.Withdraw(5m);

        acc.Balance.Should().Be(15m);
    }
    
[Fact]
public void Transfer_valid_amount_moves_money()
{
    var from = new Account(initialBalance: 50m);
    var to = new Account(initialBalance: 10m);

    from.TransferTo(to, 20m);

    from.Balance.Should().Be(30m);
    to.Balance.Should().Be(30m);
}
[Fact]
public void Transfer_to_same_account_throws()
{
    var acc = new Account(initialBalance: 10m);

    var act = () => acc.TransferTo(acc, 1m);

    act.Should().Throw<InvalidOperationException>()
       .WithMessage("Cannot transfer to the same account.");
}

}