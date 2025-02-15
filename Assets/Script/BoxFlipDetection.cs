using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class BoxFlipDetection : MonoBehaviour
{
    public GameObject puzzle;
    public Transform spawnPoint;
    private bool hasFlipped = false;

    private void Update()
    {
        if (!hasFlipped && transform.rotation.eulerAngles.x > 90)
        {
            hasFlipped = true;
            DetachPuzzle();
        }
    }



    private void DetachPuzzle()
    {
        if (puzzle != null)
        {
            Debug.Log("Detaching puzzle from box...");


            puzzle.transform.parent = null;


            foreach (Transform piece in puzzle.transform)
            {
                piece.parent = null;

                Rigidbody rb = piece.GetComponent<Rigidbody>();
                if (rb == null)
                {
                    rb = piece.gameObject.AddComponent<Rigidbody>();
                }

                rb.isKinematic = false;
                rb.useGravity = true;
                rb.mass = 1f;
                rb.drag = 0.5f;
                rb.angularDrag = 0.5f;


                XRGrabInteractable interactable = piece.GetComponent<XRGrabInteractable>();
                if (interactable != null)
                {
                    interactable.enabled = true;
                }
            }

            Debug.Log("Puzzle successfully detached!");
        }
    }


}