// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Performance", "CA1848:Use the LoggerMessage delegates", Justification = "Performance improvement is not worth the extra work to create delegates.", Scope = "module")]
//TODO: Solve warning
[assembly: SuppressMessage("Naming", "CA1716:Identifiers should not match keywords", Justification = "<Pending>", Scope = "module")]
