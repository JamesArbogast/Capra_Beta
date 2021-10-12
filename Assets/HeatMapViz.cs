using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class HeatMapViz : MonoBehaviour
{
    // Start is called before the first frame update
    private GridField grid;
    private Mesh mesh;

    private void Awake()
    {
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
    }
    public void SetGrid(GridField grid)
    {
        this.grid = grid;
    }

    private void UpdateHeatMapViz()
    {
        
    }

}
