namespace Stripe
{
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage("Microsoft.Design", "CA1040", Justification = "Used for encoding parameters")]
    public interface INestedOptions
    {
        // this interface just needs to be implemented by any class that is
        // a nested object under any of the primary service options
    }
}
