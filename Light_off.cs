using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_off : MonoBehaviour
{
    public GameObject lightOBJ;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        lightOBJ.SetActive(false);
    }
}
