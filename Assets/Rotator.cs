using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float rotationSpeed = 100f;

    bool dragging = false;

    void OnMouseDrag()
    {
        dragging = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            dragging = false;
        }
    }

    void FixedUpdate()
    {
        if (dragging)
        {
            float x = Input.GetAxis("Mouse X") * rotationSpeed * Time.fixedDeltaTime;
            rb.AddTorque(Vector3.down * x);
        }
    }
}
