using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnT : MonoBehaviour
{
    public GameObject text;
    public bool Selected = false;

    public bool aliens;
    public bool putin;
    public bool bonya;

    public tButtons tB;

    public bool plusOne;
    public bool minusOne;



    // Start is called before the first frame update

    void Start()
    {

    }

    void Update()
    {
        



    }
    public void ClickMe()
    {
        if (Selected)
        {
            text.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
            Selected = false;
        }
        else
        {
            text.GetComponent<SpriteRenderer>().color = new Color(0.6886f, 0.6886f, 0.6886f, 1f);
            Selected = true;
        }

    }

    public void OnMouseEnter()
    {
        if (Selected)
        {
            
        }

        else
        {
            text.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 0.5f);
            
        }
          
    }

    public void OnMouseExit()
    {
        if (Selected)
        {

        }

        else
        {
            text.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
        }

        
    }

    public void OnMouseDown()
    {
        if (Selected)
        {
            if (plusOne is true)
            {
                tB.score -= 1f;
            }

            if (minusOne is true)
            {
                tB.score += 1f;
            }

        }
        else
        {
            if (plusOne is true)
            {
                tB.score += 1f; 
            }

            if (minusOne is true)
            {
                tB.score -= 1f;
            }
        }
        
        
        if (aliens is true)
        {
            aliens = false;
        }
        else
        {
            aliens = true;
        }

        if (bonya is true)
        {
            bonya = false;
        }
        else
        {
            bonya = true;
        }

        if (putin is true)
        {
            putin = false;
        }
        else
        {
            putin = true;
        }

    }

    
}
