using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteScript : MonoBehaviour
{
    int End = 21;
    bool goodEnd = false;
    public GameObject love;
    public GameObject love2;
    public GameObject alone;
    public GameObject tooMuch;

    public AudioSource triggered;

    public AudioSource delete;

    public GameObject cat;
    public GameObject human1;
    public GameObject human2;

    // Start is called before the first frame update
    void Start()
    {
   
        Invoke("Trigger", 10f);
        Invoke("Ending", 35f);
    }

    // Update is called once per frame
    void Update()
    {
       if(End == 0)
        {
            goodEnd = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject == cat)
        {
            Destroy(other.gameObject);
            delete.Play();
        }
        else
        {
            if (other.gameObject == human1 || other.gameObject ==  human2)
            {
                Destroy(other.gameObject);
                End = 100;
                delete.Play();

            }
            else
            {
                Destroy(other.gameObject);

                End = End - 1;
                Debug.Log(End);

                delete.Play();
            }
               
        }
        
    }

    void Ending()
    {
        if (End == 0)
        {
            Love();
            triggered.Stop();
        }
        else
        {
            if (End > 50)
            {
                Alone();
            }
            else
            {
                TooMuch();
            }
        }
    }

    void Love()
    {
        love.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        love2.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }

    void Alone()
    {
        alone.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }

    void TooMuch()
    {
        tooMuch.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }

    void Trigger()
    {
        triggered.Play();
    }
}

