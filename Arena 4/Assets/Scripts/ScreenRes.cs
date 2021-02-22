using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenRes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        Screen.SetResolution(768, 432, true, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
