using UnityEngine;
using System.Collections;

public class CharacterMovement : MonoBehaviour
{
    //character movement speed
    private float _moveSpeed = 10.0F;
    //character rotation speed
    private float _rotationSpeed = 2.0F;
    //character controller variable
    private CharacterController _characterController;

    //use this for initialization
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }
    //update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Vertical") > 0)
        {
            Vector3 forward = transform.TransformDirection(Vector3.forward);
            float curSpeed = _moveSpeed * Input.GetAxis("Vertical");
            _characterController.SimpleMove(forward * curSpeed);
        }
        transform.Rotate(0, Input.GetAxis("Horizontal") * _rotationSpeed, 0);
    }
}
