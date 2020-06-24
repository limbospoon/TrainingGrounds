using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Opsive.UltimateCharacterController.Character.Abilities;

[DefaultStartType(AbilityStartType.ButtonDown)]
[DefaultStopType(AbilityStopType.ButtonToggle)]
public class OpenGameMenu : Ability
{
    public override void Start()
    {
        base.Start();
    }

    /// <summary>
    /// Called when the ablity is tried to be started. If false is returned then the ability will not be started.
    /// </summary>
    /// <returns>True if the ability can be started.</returns>
    public override bool CanStartAbility()
    {
        return base.CanStartAbility();
    }

    /// <summary>
    /// The ability has started.
    /// </summary>
    protected override void AbilityStarted()
    {
        base.AbilityStarted();
        Debug.Log("OpeningMenu");
    }

    /// <summary>
    /// Can the ability be stopped?
    /// </summary>
    /// <returns>True if the ability can be stopped.</returns>
    public override bool CanStopAbility()
    {
        return base.CanStopAbility();
    }

    /// <summary>
    /// Called when another ability is attempting to start and the current ability is active.
    /// Returns true or false depending on if the new ability should be blocked from starting.
    /// </summary>
    /// <param name="startingAbility">The ability that is starting.</param>
    /// <returns>True if the ability should be blocked.</returns>
    public override bool ShouldBlockAbilityStart(Ability startingAbility)
    {
        return base.ShouldBlockAbilityStart(startingAbility);
    }

    /// <summary>
    /// Called when the current ability is attempting to start and another ability is active.
    /// Returns true or false depending on if the active ability should be stopped.
    /// </summary>
    /// <param name="activeAbility">The ability that is currently active.</param>
    public override bool ShouldStopActiveAbility(Ability activeAbility)
    {
        return base.ShouldStopActiveAbility(activeAbility);
    }

    /// <summary>
    /// The ability has stopped running.
    /// </summary>
    /// <param name="force">Was the ability force stopped?</param>
    protected override void AbilityStopped(bool force)
    {
        Debug.Log("Stopped!!!");
        base.AbilityStopped(force);
    }
}
