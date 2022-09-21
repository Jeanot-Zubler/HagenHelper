namespace HagenHelper.Core;

public interface IUser
{
    string Name { get; set;}

    string Email { get; set;}

    OrderOptions Preferences { get; set; }

    int TimesOrdered { get; set; }

    int TimesPickedUp { get; set; }

    int Paid { get; set; }

    int OrderAmount { get; set; }
}
