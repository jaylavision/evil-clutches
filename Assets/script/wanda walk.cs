using UnityEngine;

public class CharacterLoop : MonoBehaviour
{
    public float speed = 5;
    public bool goingRight = true;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        // Get the SpriteRenderer attached to this character
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Move in current direction
        transform.Translate(transform.right * speed * Time.deltaTime);

        // Turn Left
        if (transform.position.x > 8 && goingRight)
        {
            goingRight = false;
            speed *= -1;

            // Flip the sprite horizontally
            spriteRenderer.flipX = true;
        }

        // Turn Right
        if (transform.position.x < -8 && !goingRight)
        {
            goingRight = true;
            speed *= -1;

            // Un-flip the sprite
            spriteRenderer.flipX = false;
        }
    }
}