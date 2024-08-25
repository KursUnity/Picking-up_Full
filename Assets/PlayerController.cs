using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Text _catsCounterTxt;
    public Cat CatPrefab;
    private int _catsCounter;
    
    private void Awake()
    {
        _catsCounterTxt.text = _catsCounter.ToString();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (_catsCounter > 0)
            {
                _catsCounter--;
                _catsCounterTxt.text = _catsCounter.ToString();
                Cat cat = Instantiate(CatPrefab, transform.position, Quaternion.identity);
                cat.Fly();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Cat cat))
        {
            Destroy(collision.gameObject);
            _catsCounter++;
            _catsCounterTxt.text = _catsCounter.ToString();
        }
    }
}
