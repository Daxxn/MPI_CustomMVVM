namespace MPILibrary
{
    public interface IOwner
    {
        IAddress Address { get; set; }
        string FirstName { get; set; }
        string FullName { get; }
        string LastName { get; set; }
        IPhoneNumber Phone { get; set; }
    }
}