using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomScript : MonoBehaviour
{
    public GameObject room;

    bool bigroom = true;
    public float s = -0.0001f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Smaller", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if (bigroom == true)
        {
            room.transform.localScale += Vector3.one * s;
        }
        
        if (room.transform.localScale.x < 0.2f)
        {
            bigroom = false;
        }
       
            

    }

    void Smaller()
    {
        s = -0.0003f;
        Invoke("Smallest", 5f);
    }

    void Smallest()
    {
        s = -0.0005f;
    }
}
