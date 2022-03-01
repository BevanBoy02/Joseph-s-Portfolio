using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public GameObject Door;
    public bool doorIsOpening;
 
    void Update()
    {
        if(doorIsOpening == true)
        {
            Door.transform.Translate(Vector3.up * Time.deltaTime * 5);
            //if the bool is true open the door
        }
        if(Door.transform.position.y>-3783f)
        {
            doorIsOpening = false;
            //if the y of the door is > -3783 we want to stop the door
        }
    }
    void OnMouseDown()
    {
        doorIsOpening = true;
    }
}
