using UnityEngine;
using System.Collections.Generic;

public class SquareGrid : MonoBehaviour {

    public GameObject tilePrefab;
    public int horizontalSize;
    public int verticalSize;

    private GameObject[,] grid;

    private GameObject parentOfCells;

    private GameObject selectedTile;
    private List<GameObject> neighbours; 

    public void Awake()
    {
        selectedTile = null;
        neighbours = new List<GameObject>();
        CreateGrid();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Tile")
                {
                    selectedTile = hit.collider.gameObject;
                    foreach (GameObject o in GetNeighbours(selectedTile))
                    {
                        //TODO
                    }
                }
                    
            }
        }
    }

    public void CreateGrid()
    {
        grid = new GameObject[horizontalSize, verticalSize];
        for (int y = 0; y < verticalSize; y++)
        {
            for (int x = 0; x < horizontalSize; x++)
            {
                Vector3 pos = new Vector3(x, 0, y);
                GameObject newTile = Instantiate(tilePrefab, pos, Quaternion.identity) as GameObject;
                newTile.transform.parent = transform;
                Cell cell = newTile.GetComponent<Cell>();
                cell.columnIndex = x;
                cell.rowIndex = y;
                grid[x, y] = newTile;
            }
        }
    }

    public List<GameObject> GetNeighbours(GameObject selectedTile)
    {
        return null;
    }
}
