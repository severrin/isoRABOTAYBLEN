using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggeredSound : MonoBehaviour
{

    public AudioSource triggered;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("trigger", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void trigger()
    {
        triggered.Play();
    }
}
