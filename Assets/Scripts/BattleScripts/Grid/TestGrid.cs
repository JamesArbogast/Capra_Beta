using UnityEngine;
using CodeMonkey.Utils;

public class TestGrid : MonoBehaviour
{

    [SerializeField] private HeatMapViz heatMapVisual;
    private GridField grid;
    void Start()
    {
        grid = new GridField(12, 12, 19f, new Vector3(0, 0));

/*        heatMapVisual.SetGrid(grid);*/
    }

    // Update is called once per frame
    void Update()
    {   
        //for clicking on grid to set value
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 position = UtilsClass.GetMouseWorldPosition();
            int value = grid.GetValue(position);
            grid.SetValue(position, value + 5);
        }

        if(Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
        

    }
}
