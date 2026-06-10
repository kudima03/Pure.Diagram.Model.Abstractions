# Pure.Diagram.Model.Abstractions

Diagram model interfaces for the **Pure** ecosystem — immutable, composable abstractions over diagram data structures.

[![.NET build & test](https://github.com/kudima03/Pure.Diagram.Model.Abstractions/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.Model.Abstractions/actions/workflows/build-and-test.yml)
[![Build and Deploy](https://github.com/kudima03/Pure.Diagram.Model.Abstractions/actions/workflows/publish-nuget.yml/badge.svg?branch=main)](https://github.com/kudima03/Pure.Diagram.Model.Abstractions/actions/workflows/publish-nuget.yml)
[![NuGet](https://img.shields.io/nuget/v/Pure.Diagram.Model.Abstractions)](https://www.nuget.org/packages/Pure.Diagram.Model.Abstractions)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

## Overview

`Pure.Diagram.Model.Abstractions` defines a set of minimal, read-only interfaces that represent the structural components of a diagram. Each interface exposes only getters — no mutation, no side effects. All string properties are typed as `IString` from `Pure.Primitives.Abstractions`.

## Interfaces

| Interface | Namespace | Description |
|-----------|-----------|-------------|
| `IDiagram` | `Pure.Diagram.Model.Abstractions` | Root diagram model — title, description, type, and series |
| `IDiagramType` | `Pure.Diagram.Model.Abstractions` | Named category of diagram (e.g. flow, sequence, class) |
| `IDiagramSeries` | `Pure.Diagram.Model.Abstractions` | A single data series — label and source binding |

## Design Principles

- **Immutable** — all interfaces expose only `get` properties; no setters, no methods that mutate state.
- **Composable** — `IDiagram` is built from `IDiagramType` and `IEnumerable<IDiagramSeries>`; complex structure is expressed through composition.
- **Primitive-typed** — string properties use `IString` from `Pure.Primitives.Abstractions`, not `System.String`.
- **AOT-compatible** — the library is fully compatible with Native AOT compilation.

## Dependencies

- [`Pure.Primitives.Abstractions`](https://github.com/kudima03/Pure.Primitives.Abstractions) — `IString` and other primitive interfaces
