namespace MPILibrary
{
    public interface IRepair
    {
        string Description { get; set; }
        string Name { get; set; }
        int OPCode { get; set; }
    }
}