using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private PuzzlePiece[] puzzlePieces;  
    public PuzzleIndicator[] indicators;  
    public GameObject completionUI;  
    public Button finishButton;  

    private void Update()
    {
        if (AllIndicatorsCorrect())
        {
            completionUI.SetActive(true);  
        }
    }

    private bool AllIndicatorsCorrect()
    {
        foreach (PuzzleIndicator indicator in indicators)
        {
            if (!indicator.IsPieceCorrect())
                return false;
        }
        return true;
    }

    public void OnFinishButtonClicked()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("CabinInterior");
    }
}
