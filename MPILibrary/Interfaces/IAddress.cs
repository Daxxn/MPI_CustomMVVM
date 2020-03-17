namespace MPILibrary
{
    public interface IAddress
    {
        string AppartmentNumber { get; set; }
        string City { get; set; }
        string Country { get; set; }
        string State { get; set; }
        string StreetName { get; set; }
        int StreetNumber { get; set; }
        int ZipCode { get; set; }
    }
}