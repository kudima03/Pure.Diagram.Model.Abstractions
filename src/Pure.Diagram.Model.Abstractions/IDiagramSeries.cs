using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.Model.Abstractions;

public interface IDiagramSeries
{
    public IString Label { get; }

    public IString Source { get; }
}
