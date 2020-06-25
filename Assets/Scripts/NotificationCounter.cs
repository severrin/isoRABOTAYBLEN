using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NotificationCounter : MonoBehaviour
{

    GameObject[] enemies;
    public TextMeshProUGUI scoreText;

    public GameObject lose;
    
    void Update()
    {
        
        enemies = GameObject.FindGameObjectsWithTag("Enemy");

        StartCoroutine(Test());

       
    }

    IEnumerator Test()
    {
        yield return new WaitForSeconds(1);

        scoreText.text = enemies.Length.ToString();

        StartCoroutine(Lose());
    }

    IEnumerator Lose()
    {
        yield return new WaitForSeconds(150f);

        lose.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1f);
    }
   

}
