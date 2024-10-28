using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GiftsCollectedBar : MonoBehaviour
{
    // Start is called before the first frame update
    int giftsCollected;
    
    void Start()
    {
        giftsCollected = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Gift")
        {
            //other.gameObject.SetActive(false);
            transform.Find("Canvas").GetChild(0).GetChild(2).GetComponent<Image>().fillAmount+=0.1f;
            Debug.Log("nigga");
        }


    }
}
