using UnityEngine;
using UnityEngine.InputSystem;

public class Testing_Input_System : MonoBehaviour
{
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if(context.performed){
            Debug.Log("Jump " + context.phase);
            rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }
}
