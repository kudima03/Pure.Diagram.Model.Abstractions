using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.Model.Abstractions;

public interface ISeries
{
    public IString Label { get; }

    public IString Source { get; }
}
