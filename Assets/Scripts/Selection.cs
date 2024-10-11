

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SelectionTest : MonoBehaviour
{
    public Material highlightMaterial;
    public Material highlightMaterial2;

    private Material originalMaterialHighlight;
    private Material originalMaterialHighlight2;

    private Transform highlight;
    private Transform highlight2;

    private RaycastHit raycastHit;

    void Update()
    {
        // Highlight
        if (highlight != null)
        {
            highlight.GetComponent<MeshRenderer>().sharedMaterial = originalMaterialHighlight;
            highlight = null;
        }
        if (highlight2 != null)
        {
            highlight2.GetComponent<MeshRenderer>().sharedMaterial = originalMaterialHighlight2;
            highlight2 = null;
        }

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out raycastHit, 100f))
        {
            highlight = raycastHit.transform;
            highlight2 = raycastHit.transform;

            if (highlight.CompareTag("Knife") || highlight.CompareTag("KeyItem")|| highlight.CompareTag("Bolt Cutters") || highlight.CompareTag("Cushion")|| highlight.CompareTag("Terry") || highlight.CompareTag("Stone") || highlight.CompareTag("HandMinute") || highlight.CompareTag("HandHour"))
            {
                if (highlight.GetComponent<MeshRenderer>().material != highlightMaterial)
                {
                    originalMaterialHighlight = highlight.GetComponent<MeshRenderer>().material;
                    highlight.GetComponent<MeshRenderer>().material = highlightMaterial;
                }
            }
            else
            {
                highlight = null;
            }


            if (highlight2.CompareTag("Hatch") || highlight2.CompareTag("Clock") || highlight2.CompareTag("Octopus") || highlight2.CompareTag("Net") ||highlight2.CompareTag("Wheel") || highlight2.CompareTag("CupboardDoor"))
            {
                if (highlight2.GetComponent<MeshRenderer>().material != highlightMaterial2)
                {
                    originalMaterialHighlight2 = highlight2.GetComponent<MeshRenderer>().material;
                    highlight2.GetComponent<MeshRenderer>().material = highlightMaterial2;
                }
            }
            else
            {
                highlight2 = null;
            }

        }

  
    }

}
