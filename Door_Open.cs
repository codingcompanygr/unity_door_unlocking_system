using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door_Open : MonoBehaviour
{
    float minDist = 5f;

    public bool hasKey;

    DoorOpening dO;

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, minDist))
        {
            if(hit.transform.gameObject.tag == "Door")
            {
                dO = hit.transform.gameObject.GetComponent<DoorOpening>();
                if (Input.GetKeyDown(KeyCode.F))
                {
                    if (hasKey)
                    {
                        if (dO.isClose)
                        {
                            dO.Open();
                        }
                        else if (dO.isOpen)
                        {
                            dO.Close();
                        }
                    }
                }
            }
        }
    }
}
