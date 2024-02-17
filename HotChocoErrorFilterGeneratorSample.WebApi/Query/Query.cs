using HotChocoErrorFilterGeneratorSample.WebApi.Types;

namespace HotChocoErrorFilterGeneratorSample.WebApi.Query;

public class Query
{
    public Book GetBook()
        => throw new NullReferenceException();
}