namespace MPILibrary
{
    public interface IPhoneNumber
    {
        int AreaCode { get; set; }
        int CountryCode { get; set; }
        int Exchange { get; set; }
        int LocalNumber { get; set; }
        string PhoneNumberString { get; set; }
    }
}