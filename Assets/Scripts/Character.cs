using UnityEngine;

public class Character : MonoBehaviour
{
    public void Move(Vector3 deltaPosition)
    {
        transform.position += deltaPosition;
    }
}
