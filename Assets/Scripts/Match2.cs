using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Match2 : MonoBehaviour
{


    #region Variables

    private Grid<GemGridPosition> grid;

    [SerializeField] private int gridWidth;

    [SerializeField] private int gridHeight;
    [SerializeField] private float gridCellSize;


    #endregion


    
    // Preconstruct
    // private void Awake() {


        

    // }

    private void Start() {


        Vector3 originPosition = Vector3.zero;
        
        grid = new Grid<GemGridPosition>( GameObject.Find("Board"), gridWidth, gridHeight, gridCellSize, originPosition, (Grid<GemGridPosition> g, int x, int y) => new GemGridPosition(g, x, y));
        
    }


    
    
    public class GemGridPosition{

        private Grid<GemGridPosition> grid;

        private int x;

        private int y;

        public GemGridPosition(Grid<GemGridPosition> grid, int x , int y){

            this.grid = grid;
            this.x = x;
            this.y = y;


        }


    }

}
