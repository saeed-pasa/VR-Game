using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountS : MonoBehaviour
{

    private GameObject countText;

    // Start is called before the first frame update
    void Start()
    {
        countText = GameObject.Find("count");
        Debug.Log("Text: " + countText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
