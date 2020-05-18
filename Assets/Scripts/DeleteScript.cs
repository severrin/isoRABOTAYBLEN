using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScript : MonoBehaviour
{
    int End = 21;
    public bool GoodEnd = false;
    public GameObject love;
    public AudioSource triggered;

    public AudioSource delete;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Love", 25f);
        Invoke("Trigger", 10f);
    }

    // Update is called once per frame
    void Update()
    {
        if(End == 0)
        {
            GoodEnd = true;
            Invoke("Love", 5f);
            triggered.Stop();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        
        End = End-1;
        Debug.Log(End);

        delete.Play(); 
    }

    void Love()
    {
        if(End==0)
        {
            love.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }
        
    }

    void Trigger()
    {
        triggered.Play();
    }
}

