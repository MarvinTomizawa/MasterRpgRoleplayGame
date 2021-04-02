using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float MovementSpeed = 5;

    private CharacterController _characterController;

    private Vector3 direction;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;
    private float height = 0;

    private void Start()
    {
        _characterController = GetComponent<CharacterController>();
        direction = Vector3.zero;
    }

    void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), height, Input.GetAxis("Vertical")) * MovementSpeed;

        if (_characterController.isGrounded)
        {       
            if (Input.GetButton("Jump"))
            {
                height = jumpSpeed;
            }
        }

        height -= gravity * Time.deltaTime;

        direction.y = height;

        _characterController.Move(direction * Time.deltaTime);
    }
}
