using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public SpriteRenderer m_renderer;

    public Sprite m_frontSprite;
    public Sprite m_leftSprite;
    public Sprite m_rightSprite;
    public Sprite m_backSprite;
    public Animator animator;

    public GameObject Steps;

    public float speed = 100f;

    void FixedUpdate()
    {
        float horizontalOffset = Input.GetAxis("Horizontal");
        float verticalOffset = Input.GetAxis("Vertical");

        Vector2 newPos = rb2D.position;

        animator.SetFloat("Speed", verticalOffset);
        animator.SetFloat("SpeedHorizontal", horizontalOffset);
        animator.SetInteger("SpeedHorizontal 0", Mathf.RoundToInt(horizontalOffset));
        animator.SetInteger("Speed 0", Mathf.RoundToInt(verticalOffset));
if (horizontalOffset != 0 || verticalOffset != 0)
{
    Steps.SetActive(true);
}else
{
    Steps.SetActive(false);
}
        if (horizontalOffset < 0f)
        {
            newPos += Time.fixedDeltaTime * speed * Vector2.left;
            m_renderer.sprite = m_leftSprite;
            animator.SetBool("isLeft", true);
            animator.SetBool("isFront", false);
            animator.SetBool("isBack", false);
            animator.SetBool("isRight", false);
           
        }
        if (horizontalOffset > 0f)
        {
            newPos += Time.fixedDeltaTime * speed * Vector2.right;
            m_renderer.sprite = m_rightSprite;
            animator.SetBool("isRight", true);
            animator.SetBool("isFront", false);
            animator.SetBool("isBack", false);
            animator.SetBool("isLeft", false);
        }
        if (verticalOffset > 0f)
        {
            newPos += Time.fixedDeltaTime * speed * Vector2.up;
            m_renderer.sprite = m_backSprite;
            animator.SetBool("isBack", true);
            animator.SetBool("isFront", false);
            animator.SetBool("isRight", false);
            animator.SetBool("isLeft", false);
        }
        if (verticalOffset < 0f)
        {
            newPos += Time.fixedDeltaTime * speed * Vector2.down;
            m_renderer.sprite = m_frontSprite;
            animator.SetBool("isFront", true);
            animator.SetBool("isRight", false);
            animator.SetBool("isBack", false);
            animator.SetBool("isLeft", false);
        }

        rb2D.MovePosition(newPos);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            AudioManager.instance.PlayFX();
        }
    }
}
