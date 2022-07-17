using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody        _rigidbody;
    [SerializeField] private FloatingJoystick joystick;
    [SerializeField] private Animator         _animator;
    [SerializeField] private float            _moveSpeed;

    private void FixedUpdate()
    {

        _rigidbody.velocity = new Vector3(joystick.Horizontal, 0, joystick.Vertical) * _moveSpeed;

        if (joystick.Horizontal != 0 || joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
            _animator.SetBool("isRunning",true);
        }
        else
        {
            _animator.SetBool("isRunning",false);
        }

        
    }
}
