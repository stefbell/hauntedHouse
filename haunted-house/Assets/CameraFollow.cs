using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationX = 0f;
    float rotationY = 0f;
    public float sensitivity = 15f;
    public Camera mainCamera;


    // Update is called once per frame
    void Update()
    {
        rotationY += Input.GetAxis("Mouse X") * sensitivity;
        rotationX += Input.GetAxis("Mouse Y") * -1 * sensitivity;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);  
        transform.localEulerAngles = new Vector3(rotationX, rotationY, 0);
        mainCamera.transform.position = transform.position;
    }
}
