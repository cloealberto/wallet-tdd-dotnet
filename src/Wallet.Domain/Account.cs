namespace Wallet.Domain;

public class Account
{
    public decimal Balance { get; private set; }

    public Account(decimal initialBalance = 0m)
    {
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0m)
            throw new ArgumentOutOfRangeException(nameof(amount), "Deposit amount must be greater than zero.");

        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0m)
            throw new ArgumentOutOfRangeException(nameof(amount), "Withdraw amount must be greater than zero.");

        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");

        Balance -= amount;
    }

public void TransferTo(Account target, decimal amount)
{
    if (target is null)
        throw new ArgumentNullException(nameof(target));

    if (ReferenceEquals(this, target))
        throw new InvalidOperationException("Cannot transfer to the same account.");

    Withdraw(amount);
    target.Deposit(amount);
}
}
