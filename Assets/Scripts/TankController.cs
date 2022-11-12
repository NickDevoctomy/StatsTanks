using UnityEngine;

public class TankController : MonoBehaviour
{
    public float RotationSpeed = 0.5f;
    public float MovementSpeed = 10.0f;

    private Rigidbody _rigidBody;

    void Start()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        var horizontalAxis = Input.GetAxis("Horizontal");
        if(horizontalAxis != 0)
        {
            transform.Rotate(0.0f, horizontalAxis * RotationSpeed, 0.0f);
        }

        var verticalAxis = Input.GetAxis("Vertical");
        if(verticalAxis != 0)
        {
            _rigidBody.position += transform.forward * Time.deltaTime * (verticalAxis * MovementSpeed);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.forward * 5 + transform.position);
    }
}
