using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicStateExample : MonoBehaviour
{
    public enum ObjectState
    {
        Happy,
        Sad,
        Angry
    }
    public ObjectState objectState;

    public void Jump()
    {
        switch(objectState)
        {
            case ObjectState.Happy:
                {
                    Debug.Log("You jump with joy!!");
                    break;
                }
            case ObjectState.Angry:
                {
                    Debug.Log("You are too angry to jump!!");
                    break;
                }
            case ObjectState.Sad:
                {
                    Debug.Log("You try to jump but you are too sad!!");
                    break;
                }
        }
    }

    public void Cry()
    {
        switch (objectState)
        {
            case ObjectState.Happy:
                {
                    Debug.Log("You are too happy to cry");
                    break;
                }
            case ObjectState.Angry:
                {
                    Debug.Log("You punch a wall instead of crying!!");
                    break;
                }
            case ObjectState.Sad:
                {
                    Debug.Log("You ball your eyes out!!");
                    break;
                }
        }
    }

    public void Laugh()
    {
        switch (objectState)
        {
            case ObjectState.Happy:
                {
                    Debug.Log("You jump while laughing!!");
                    break;
                }
            case ObjectState.Angry:
                {
                    Debug.Log("You try to laugh but have too much rage to do so!!");
                    break;
                }
            case ObjectState.Sad:
                {
                    Debug.Log("You cant laugh the world sucks!!");
                    break;
                }
        }
    }

    void PreformAction(int action)
    {
        switch(action)
        {
            case 0:
                {
                    Jump();
                    break;
                }
            case 1:
                {
                    Cry();
                    break;
                }
            case 3:
                {
                    Laugh();
                    break;
                }
        }
    }

    void ChangeMood(int mood)
    {
        switch(mood)
        {
            case 0:
                {
                    objectState = ObjectState.Angry;
                    break;
                }
            case 1:
                {
                    objectState = ObjectState.Happy;
                    break;
                }
            case 2:
                {
                    objectState = ObjectState.Sad;
                    break;
                }

        }
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            PreformAction(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PreformAction(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            PreformAction(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            ChangeMood(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            ChangeMood(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            ChangeMood(2);
        }

    }
}
