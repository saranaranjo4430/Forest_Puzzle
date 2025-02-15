using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneTransitionWithUI : MonoBehaviour
{
    [SerializeField] private string targetSceneName = "CabinInterior";
    [SerializeField] private GameObject confirmationUI; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            
            confirmationUI.SetActive(true);
        }
    }

    public void OnYesButtonClicked()
    {
        SceneManager.LoadScene(targetSceneName);  
    }

  
    public void OnNoButtonClicked()
    {
        confirmationUI.SetActive(false); 
}

}
