namespace Netfluid.Dns.Interfaces
{
    public interface IRecordResolver
    {
        Record Resolve(RecordClass recordClass, RecordType type, string name);
    }
}
