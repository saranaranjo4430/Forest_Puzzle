using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzlePiece : MonoBehaviour
{
    public Transform correctPosition;  
    public float threshold = 0.5f; 

    private bool isCorrect = false;

    private void Update()
    {
        
        if (Vector3.Distance(transform.position, correctPosition.position) < threshold)
        {
            isCorrect = true;
        }
        else
        {
            isCorrect = false;
        }
    }

    public bool IsCorrect()
    {
        return isCorrect;
    }
}

