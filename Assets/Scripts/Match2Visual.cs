using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Match2Visual : MonoBehaviour
{


    private Match2 match2;
    private Grid<Match2.GemGridPosition> grid;
    public void Setup(Match2 match2, Grid<Match2.GemGridPosition>grid){


        this.match2 = match2;
        this.grid   = grid; 
        

    }
}
