using UnityEngine;

public class CameraCircleMovement : MonoBehaviour
{
    public Transform centerPoint;   // Dairenin merkezi
    public float radius = 2.0f;     // Dairenin yarıçapı
    public float speed = 1.0f;      // Dönüş hızı

    private Vector3 axis = Vector3.up;  // Dönüş eksenleri

    void Update()
    {
        // Yatayda dairesel hareket
        transform.RotateAround(centerPoint.position, axis, speed * Time.deltaTime);
    }
}