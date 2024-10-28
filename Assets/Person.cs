using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro; // Include TextMeshPro namespace

public class Person : MonoBehaviour
{
    private int giftCount = 0; // Keeps track of collected gifts

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Gift")) // Ensure the object has the "Gift" tag
        {
            other.gameObject.SetActive(false); // Deactivate the gift

            // Find the Text (TMP) component in the hierarchy
            GameObject canvas = GameObject.Find("Canvas"); // Find the Canvas by name
            Transform canvasTransform = transform.Find("Canvas");
            if (canvasTransform != null)
            {
                Transform progressBarTransform = canvasTransform.GetChild(0).GetChild(2); // Adjust based on the exact hierarchy
                Image progressBar = progressBarTransform.GetComponent<Image>();

                if (progressBar != null)
                {
                    progressBar.fillAmount += 0.1f;
                }
                else
                {
                    Debug.LogWarning("ProgressBar Image component not found!");
                }
            }
            else
            {
                Debug.LogWarning("Canvas not found!");
            }

            Debug.Log("Gift Collected!");
        
        if (canvas != null)
            {

                // Navigate through the hierarchy to find the Text (TMP)
                Transform panel = canvas.transform.GetChild(0); // Assuming the panel is the 10th child of Canvas
                TextMeshProUGUI textTMP = panel.GetChild(panel.childCount - 1).GetComponent<TextMeshProUGUI>(); // Last child of the panel

                if (textTMP != null)
                {
                    // Increase gift count and update the text
                    giftCount++;
                    textTMP.text ="10/"+ giftCount.ToString(); // Update the TMP text to display the new count
                }
                else
                {
                    Debug.LogWarning("Text (TMP) component not found!");
                }
            }
            else
            {
                Debug.LogWarning("Canvas not found in the scene!");
            }

            Debug.Log("Gift Collected!");
        }
    }
}
