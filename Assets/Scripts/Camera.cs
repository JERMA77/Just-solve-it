using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;
    void FixedUpdate()
    {
        transform.position = new Vector3(player.position.x + 6, transform.position.y, -10);
    }
}
