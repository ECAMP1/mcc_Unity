using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passing_Lights_delay : MonoBehaviour
{
    public GameObject Lightbulb;
    public float delaySpeed;
    

    // Start is called before the first frame update
    void Start()
    {
        Lightbulb.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Invoke("lighton", delaySpeed);
    }

    void lighton ()
    {
        Lightbulb.SetActive(true);
    }
}
