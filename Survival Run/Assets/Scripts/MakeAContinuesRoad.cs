using UnityEngine;

[ExecuteAlways]
public class MakeAContinuesRoad : MonoBehaviour
{
    private void Update()
    {
        for (var i = 0; i < transform.childCount; i++)
        {
            var child = transform.GetChild(i);
            var pos = child.position;
            pos.x = i * 10;//child.GetComponent<SpriteRenderer>().sprite.border.x;
            child.position = pos;
            Debug.Log("1: " + child.name);
        }
    }
}