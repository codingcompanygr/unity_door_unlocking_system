//has to be attached to the door

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{
    public GameObject moveTarget;

    Vector3 startingPosition;

    public bool isOpen;
    public bool isClose;

    private void Awake()
    {
        startingPosition = transform.position;
        isClose = true;
    }

    public void Close()
    {
        transform.position = startingPosition;
        isClose = true;
        isOpen = false;
    }

    public void Open()
    {
        transform.position = moveTarget.transform.position;
        isClose = false;
        isOpen = true;
    }
}
