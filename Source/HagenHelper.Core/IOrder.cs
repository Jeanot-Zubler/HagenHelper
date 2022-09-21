namespace HagenHelper.Core;

public interface IOrder
{
    IUser User { get; set; }

    OrderOptions Options { get; set; }

    int Price { get; }
}
