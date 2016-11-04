using UnityEngine;
using System.Collections;

public class Candy : MonoBehaviour
{
    //event for sending the candy pickup action
    public delegate void OnCandyPickupAction(float fatAmount);
    public static event OnCandyPickupAction OnCandyPickup;
    //amount of fat to add to the player
    private float _fatAmount = 0.05f;
    //function for candy pickup
    void CandyPickup(string colliderTag)
    {
        if(OnCandyPickup != null && colliderTag == "Player")
        {
            OnCandyPickup(_fatAmount);
            Destroy(this.gameObject);
        }
    }
}
