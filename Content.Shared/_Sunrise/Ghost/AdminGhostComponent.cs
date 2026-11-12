using System;
using Content.Shared.Actions;
using Robust.Shared.GameStates;
using Robust.Shared.Prototypes;

namespace Content.Shared._Sunrise.Ghost;

/// <summary>
/// Marks an admin ghost (aghost) and stores its personal settings.
/// </summary>
[RegisterComponent, NetworkedComponent, AutoGenerateComponentState]
[Access(typeof(AdminGhostSystem))]
public sealed partial class AdminGhostComponent : Component
{
    /// <summary>
    /// Action that toggles the self-restriction on interacting with the world.
    /// </summary>
    [DataField]
    public EntProtoId InteractionToggleAction = "SunriseActionAghostToggleInteraction";

    [DataField, AutoNetworkedField]
    public EntityUid? InteractionToggleActionEntity;

    /// <summary>
    /// Whether the ghost is forbidden from interacting with the world.
    /// Prevents picking up and using items during an event by accident.
    /// </summary>
    /// <remarks>
    /// Enabled by default: the restriction is active immediately after entering aghost.
    /// </remarks>
    [DataField, AutoNetworkedField]
    public bool InteractionRestricted = true;

    /// <summary>
    /// Cooldown of the toggle button after it is pressed.
    /// </summary>
    /// <remarks>
    /// The state changes immediately, but the next press is only available after this delay,
    /// so the button cannot be spam-clicked.
    /// </remarks>
    [DataField]
    public TimeSpan ToggleCooldown = TimeSpan.FromSeconds(3);
}

/// <summary>
/// Event that toggles the self-restriction on interacting with the world.
/// </summary>
public sealed partial class ToggleAdminGhostInteractionActionEvent : InstantActionEvent;
