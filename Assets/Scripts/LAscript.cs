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




    // Start is called before the first frame update
    void Start()
    {
        
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

    void WinOrLose()
    {

        if (bS.Spreading)
        {
            win.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            win2.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }

        else
        {
            lose.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            lose2.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);

        }
    }
    

}
