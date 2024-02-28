using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform playerCamera;
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
        transform.position = playerCamera.position + offset;
    }
}
