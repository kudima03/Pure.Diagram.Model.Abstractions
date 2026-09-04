# Changelog

All notable changes to Pure.Diagram.Model.Abstractions are documented here.

Format follows [Keep a Changelog](https://keepachangelog.com/en/1.1.0/).

---

## [0.1.0-preview.1.0.0] — 2026-04-19

### Changed

- **`IDiagramSeries`** replaces `ISeries` (renamed). `IDiagram.Series` is
  now `IEnumerable<IDiagramSeries>` instead of `IEnumerable<ISeries>`.

### Removed

- **`ISeries`** — replaced by `IDiagramSeries`.

## [0.1.0-preview.0.1.0] — 2026-02-06

Initial release.

### Added

- **`IDiagram`** — root diagram abstraction with `Title`, `Description`,
  `Type`, and `Series` (`IEnumerable<ISeries>`).
- **`IDiagramType`** — diagram type abstraction exposing `Name`.
- **`ISeries`** — diagram series abstraction with `Label` and `Source`.
- Dependency on `Pure.Primitives.Abstractions` for the `IString` type used
  throughout the model.
