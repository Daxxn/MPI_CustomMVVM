namespace MPILibrary.Interfaces
{
    public interface IRepair
    {
        System.String Description { get; set; }
        System.String Name { get; set; }
        System.Int32 OPCode { get; set; }
    }
}