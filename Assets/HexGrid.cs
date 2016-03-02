using UnityEngine;
using System.Collections;

public class HexGrid : MonoBehaviour {

    public GameObject tilePrefab;

    public int horizontalSize = 5;
    public int verticalSize = 5;

    public float radius = 0.5f;
    public bool useAsInnerCircleRadius = false;

    private float offsetX, offsetY;

    void Start()
    {
        float unitLength = (useAsInnerCircleRadius) ? (radius / (Mathf.Sqrt(3) / 2)) : radius;

        offsetX = unitLength * Mathf.Sqrt(3);
        offsetY = unitLength * 1.5f;

        for (int i = 0; i < horizontalSize; i++)
        {
            for (int j = 0; j < verticalSize; j++)
            {
                Vector2 hexpos = HexOffset(i, j);
                Vector3 pos = new Vector3(hexpos.x, 0, hexpos.y);
                Instantiate(tilePrefab, pos, Quaternion.identity);
            }
        }
    }

    Vector2 HexOffset(int x, int y)
    {
        Vector2 position = Vector2.zero;

        if (y % 2 == 0)
        {
            position.x = x * offsetX;
            position.y = y * offsetY;
        }
        else {
            position.x = (x + 0.5f) * offsetX;
            position.y = y * offsetY;
        }

        return position;
    }
}
