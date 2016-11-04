using UnityEngine;
using System.Collections;

public class TriggerCollision : MonoBehaviour
{
    //on trigger enter collision
    void OnTriggerEnter(Collider coll)
    {
        this.SendMessage("CandyPickup", coll.tag);
    }
}