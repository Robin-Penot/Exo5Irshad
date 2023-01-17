using UnityEngine;

public class Waypoints : MonoBehaviour
{
    [SerializeField] float guismoSize = 0.5f;

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position, guismoSize);
    }
}
