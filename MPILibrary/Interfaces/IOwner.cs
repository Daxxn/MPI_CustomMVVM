namespace MPILibrary.Interfaces
{
    public interface IOwner
    {
        Address Address { get; set; }
        System.String FirstName { get; set; }
        System.String FullName { get; }
        System.String LastName { get; set; }
        PhoneNumber Phone { get; set; }
        System.String PhoneNumberString { get; set; }

        PhoneNumber ParsePhoneNumber(System.String input);
        void ParseStreetAddress(System.String input);
    }
}