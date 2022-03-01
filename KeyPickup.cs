using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject Door;
    public GameObject KEY;
    public bool doorIsOpening;
    public MeshRenderer seeable;
    public BoxCollider touchable;


    void Update()
    {
        if (doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
            //if the bool is true open the door
        }
        if (Door.transform.position.y > -3783f)
        {
            doorIsOpening = false;
            //if the y of the door is > -3783 we want to stop the door
        }
    }
    void OnTriggerEnter()
    {
        doorIsOpening = true;
        seeable.enabled = false;
        touchable.enabled = false;
    }
}