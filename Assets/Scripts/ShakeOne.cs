using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeOne : MonoBehaviour
{
    public bool shk = false;

    [Header("Info")]
    private Vector3 _startPos;
    private float _timer;
    private Vector3 _randomPos;

    [Header("Settings")]
    [Range(0f, 2f)]
    public float _time = 0.2f;
    [Range(0f, 2f)]
    public float _distance = 0.1f;
    [Range(0f, 0.1f)]
    public float _delayBetweenShakes = 0f;

    private Rigidbody2D rb;
    private bool isShaking;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        _startPos = transform.position;
    }

    private void OnValidate()
    {
        if (_delayBetweenShakes > _time)
            _delayBetweenShakes = _time;
    }

    private void Start()
    {
        Invoke("ChangeShake", 10f);
    }
    private void Update()
    {

        if (shk == true && !isShaking)
        {
            Begin();
            isShaking = true;
        }

    }

    void ChangeShake()
    {
        shk = true;
    }

    public void Begin()
    {
        StopAllCoroutines();
        StartCoroutine(Shake());
    }

    private IEnumerator Shake()
    {
        _timer = 0f;

        while (_timer < _time)
        {
            _timer += Time.fixedDeltaTime;

            _randomPos = _startPos + (Random.insideUnitSphere * _distance);

            rb.position = _randomPos;
            // transform.position = _randomPos;

            if (_delayBetweenShakes > 0f)
            {
                yield return new WaitForSeconds(_delayBetweenShakes);
            }
            else
            {
                yield return null;
            }
        }


        rb.position = _startPos;
        Begin();
    }
}
