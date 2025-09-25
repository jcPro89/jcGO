using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTrf;
    public Vector3 offset;

    void Update()
    {
        transform.position = playerTrf.position + offset;
    }
}
