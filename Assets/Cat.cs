using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    public Rigidbody2D _rb;

    public void Fly()
    {
        //_rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        //_rb.AddForce(Vector2.right * 15, ForceMode2D.Impulse);

        _rb.AddForce(new Vector2(5,7), ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.TryGetComponent(out Enemy enemy))
        {
            enemy.HurtActivated();
            Destroy(gameObject);
        }
    }
}
