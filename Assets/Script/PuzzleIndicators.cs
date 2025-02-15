using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleIndicator : MonoBehaviour
{
    public GameObject correctPiece;  
    public float threshold = 0.5f; 

    private bool isPieceCorrect = false;

    private void Update()
    {
        if (Vector3.Distance(correctPiece.transform.position, transform.position) < threshold)
        {
            isPieceCorrect = true;
        }
        else
        {
            isPieceCorrect = false;
        }
    }

    public bool IsPieceCorrect()
    {
        return isPieceCorrect;
    }
}
