using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public SpriteRenderer m_renderer;

    public Sprite m_frontSprite;
    public Sprite m_leftSprite;
    public Sprite m_rightSprite;
    public Sprite m_backSprite;

    public float speed = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 newPos = rb2D.position;
        if (Input.GetAxis("Horizontal") < 0f)
        {
            newPos += Time.fixedDeltaTime * speed * Vector2.left;
            m_renderer.sprite = m_leftSprite;
        }
        if (Input.GetAxis("Horizontal") > 0f)
        {
            newPos += Time.fixedDeltaTime * speed * Vector2.right;
            m_renderer.sprite = m_rightSprite;
        }
        if (Input.GetAxis("Vertical") > 0f)
        {
            newPos += Time.fixedDeltaTime * speed * Vector2.up;
            m_renderer.sprite = m_backSprite;
        }
        if (Input.GetAxis("Vertical") < 0f)
        {
            newPos += Time.fixedDeltaTime * speed * Vector2.down;
            m_renderer.sprite = m_frontSprite;
        }

        rb2D.MovePosition(newPos);
    }

    /*void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            score++;
            Destroy(collision.gameObject);
        }
    }*/
}
