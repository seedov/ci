using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField]
    private Character _character;

    Vector3 moveVector;
    void Update()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        moveVector.y = Input.GetAxis("Vertical");
        _character.Move(moveVector);
    }
}
