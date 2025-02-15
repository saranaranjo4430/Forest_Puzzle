using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleTrigger : MonoBehaviour
{
    [SerializeField] private GameObject puzzleUI;  
    [SerializeField] private string puzzleSceneName = "PuzzleGame";  

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag("Player"))
        {
            puzzleUI.SetActive(true); 
        }
    }

    public void OnYesButtonClicked()
    {
        
        SceneManager.LoadScene(puzzleSceneName);
    }

    public void OnNoButtonClicked()
    {
        
        puzzleUI.SetActive(false);
    }
}
