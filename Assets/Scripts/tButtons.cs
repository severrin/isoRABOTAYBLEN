using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 

public class tButtons : MonoBehaviour
{
    
    public GameObject everythingSelected;
    public GameObject nothingSelected;
    public GameObject best;
    public GameObject good;
    public GameObject bad;
    public GameObject worst;
    public GameObject UFO;
    public GameObject bunker;
    // public GameObject putinbunker;
    public GameObject fiveG;

    public ClickOnT aS;
    public ClickOnT bS;
    public ClickOnT pS;

    public float score;


    // Update is called once per frame
    void Update()
    {
        if (aS.aliens)
        {
            UFO.GetComponent<TextMeshProUGUI>().color = new Color(1f, 1f, 1f, 1f);
        }
        else
        {
            UFO.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 0f);
        }

        if (bS.bonya)
        {
            fiveG.GetComponent<TextMeshProUGUI>().color = new Color(1f, 1f, 1f, 1f);
        }
        else
        {
            fiveG.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 0f);
        }

        if (pS.putin)
        {
            bunker.GetComponent<TextMeshProUGUI>().color = new Color(1f, 1f, 1f, 1f);
            //putinbunker.GetComponent<TextMeshProUGUI>().color = new Color(1f, 1f, 1f, 1f);
        }
        else
        {
            bunker.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 0f);
           // putinbunker.GetComponent<Image>().color = new Color(0f, 0f, 0f, 0f);
        }

        
        
        if (score == 0f)
        {
            nothingSelected.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
        }
        else
        {
            if (score == -1f)
            {
                nothingSelected.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
            }
            else
            {
                if (score == 1f)
                {
                    nothingSelected.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
                }
                else
                {
                    if (score == 2f)
                    {
                        nothingSelected.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
                    }
                    else
                    {
                        nothingSelected.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 0f);
                    }
                }
            }
            
        }


        if (score == 3f)
        {
            good.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
        }
        else
        {
            if (score == 4f)
            {
                good.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
            }
            else
            {
                good.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 0f);
            }
        }

        
        if (score == 5f)
        {
            best.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
        }
        else
        {
            if (score == 6f)
            {
                best.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
            }
            else
            {
                best.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 0f);
            }
        }

       
        if (score == -2f)
        {
            bad.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
        }
        else
        {
            if (score == -3f)
            {
                bad.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
            }
            else
            {
                if (score == -4f)
                {
                    bad.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
                }
                else
                {
                    bad.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 0f);
                }
            }
        }

       
        if (score == -5f)
        {
            worst.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
        }
        else
        {

            if (score == -6f)
            {
                worst.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 1f);
            }
            else
            {
                worst.GetComponent<TextMeshProUGUI>().color = new Color(0f, 0f, 0f, 0f);
            }
        }

        

    }
}
