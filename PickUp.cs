using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    float minDist = 2f;

    Door_Open DO;

    // Start is called before the first frame update
    void Start()
    {
        DO = GetComponent<Door_Open>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;

        if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, minDist))
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                if(hit.transform.gameObject.tag == "Key")
                {
                    hit.transform.gameObject.SetActive(false);
                    DO.hasKey = true;
                }
            }
        }
    }
}
