using UnityEngine;
using System.Collections;

public class AnimationTransition : MonoBehaviour
{   
    //store the animator in a variable
    private Animator _animator;

	//use this for initialization
	void OnEnable()
    {
        KeyboardInput.OnMoveForward += SetRunningAnimation;
        KeyboardInput.OnStopMoving += SetIdleAnimation;
        _animator = GetComponent<Animator>();
	}
	
	//switches to the idle animation
	void SetIdleAnimation()
    {
        _animator.SetBool("isRunning", false);
    }

    //switches to the running animation
    void SetRunningAnimation()
    {
        _animator.SetBool("isRunning", true);
    }

    //use this for the exit
    void OnDisable()
    {
        KeyboardInput.OnMoveForward -= SetRunningAnimation;
        KeyboardInput.OnStopMoving -= SetIdleAnimation;
    }
}
