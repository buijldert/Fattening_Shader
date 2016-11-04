using UnityEngine;
using System.Collections;

public class KeyboardInput : MonoBehaviour
{
    //event for moving forward
    public delegate void MoveForwardAction();
    public static event MoveForwardAction OnMoveForward;
    //event for stopping movement
    public delegate void StopMoving();
    public static event StopMoving OnStopMoving;
    
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.W) && OnMoveForward != null)
        {
            OnMoveForward();
        }
        else if (Input.GetKeyUp(KeyCode.W) && OnStopMoving != null) 
        {
            OnStopMoving();
        }

	}
}
