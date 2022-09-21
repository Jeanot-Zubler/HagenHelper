namespace HagenHelper.Core;

internal interface ITransaction
{
    IEnumerable<IOrder> Orders { get; }

    int TotalPrice { get; }
}
