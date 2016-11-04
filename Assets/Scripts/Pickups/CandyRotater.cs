using UnityEngine;
using System.Collections;

public class CandyRotater : MonoBehaviour
{
    //FixedUpdate is called once at the end of the frame
    void FixedUpdate()
    {
        RotateCandy();
    }
    //rotate the candy
    void RotateCandy()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
