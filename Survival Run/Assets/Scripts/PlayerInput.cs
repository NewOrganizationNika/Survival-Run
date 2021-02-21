using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private void Update()
    {
        if (InputController.Up)
        {
            var transform1 = transform;
            var pos = transform1.position;
            pos.y += 1;
            transform1.position = pos;
        }

        if (InputController.Down)
        {
            var transform1 = transform;
            var pos = transform1.position;
            pos.y -= 1;
            transform1.position = pos;
        }
    }
}

public static class InputController
{
    public static bool Up => Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow);
    public static bool Down => Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.DownArrow);
}