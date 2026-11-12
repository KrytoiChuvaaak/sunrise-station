using System;
using Robust.Shared.Prototypes;

// ReSharper disable once CheckNamespace
namespace Content.Shared.Procedural;

public sealed partial class SalvageDifficultyPrototype
{
    [DataField]
    public string LootPrototype = "SalvageLoot";

    /// <summary>
    /// Minimum round time after which this difficulty can appear.
    /// </summary>
    [DataField]
    public TimeSpan Delay = TimeSpan.Zero;

    /// <summary>
    /// How long an expedition of this difficulty lasts. Zero falls back to the salvage.expedition_duration CVar.
    /// </summary>
    [DataField]
    public TimeSpan Duration = TimeSpan.Zero;

    /// <summary>
    /// Weighted chance for this difficulty when generating offers.
    /// </summary>
    [DataField]
    public float Probability = 1f;
}
