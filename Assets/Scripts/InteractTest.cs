using System.Collections;
using System.Collections.Generic;
using Opsive.UltimateCharacterController.Traits;
using UnityEngine;

public class InteractTest : MonoBehaviour, IInteractableTarget, IInteractableMessage
{
    public void Interact(GameObject character)
    {
        Debug.Log("Interacted!!");
    }

    public bool CanInteract(GameObject character)
    {
        return true;
    }

    public string AbilityMessage()
    {
        return string.Empty;
    }
}
