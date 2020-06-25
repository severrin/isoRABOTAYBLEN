using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LAscript : MonoBehaviour
{
    public Sprite la2;
    public Sprite la3;
    public Sprite la4;
    public Sprite la5;

    public Virus bS;
    public GameObject win;
    public GameObject win2;
    public GameObject lose;
    public GameObject lose2;



    public GameObject a;
    int la = 0;

    bool vir = true;
    public AudioSource crack;




    // Start is called before the first frame update
    void Start()
    {
        Invoke("Help", 50f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == a)
        {
            la = la + 1;
            GetComponent<AudioSource>().Play();

            if(la == 2)
            {
                GetComponent<SpriteRenderer>().sprite = la2;
            }
            else
            {
                if (la == 3)
                {
                    GetComponent<SpriteRenderer>().sprite = la3;
                }
                else
                {
                    if (la == 4)
                    {
                        GetComponent<SpriteRenderer>().sprite = la4;
                    }
                    else
                    {
                        if (la == 5)
                        {
                            GetComponent<SpriteRenderer>().sprite = la5;
                            Destroy(GetComponent<BoxCollider2D>());
                            WinOrLose();
                        }
                      
                    }
                }
            }
        }
        
    }

    void Help()
    {
        vir = false;
    }

    void WinOrLose()
    {

        if (vir == false)
        {
            win.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            win2.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }

        else
        {
            lose.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            lose2.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);

            a.GetComponent<SpriteRenderer>().color = new Color(217f, 0f, 0f, 255f);
        }
    }
    

}
