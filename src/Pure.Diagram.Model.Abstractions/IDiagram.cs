using System.Collections.Generic;
using Pure.Primitives.Abstractions.String;

namespace Pure.Diagram.Model.Abstractions;

public interface IDiagram
{
    public IString Title { get; }

    public IString Description { get; }

    public IDiagramType Type { get; }

    public IEnumerable<ISeries> Series { get; }
}
