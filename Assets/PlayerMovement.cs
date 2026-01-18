using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    void Update()
    {
        Vector3 worldPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        worldPos.z = 0;
        transform.position = worldPos;
    }
}
