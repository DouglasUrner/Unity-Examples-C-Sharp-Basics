
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*
     * Code outside of any function declares variables
     * that are visible to all of the functions in
     * the class. They are called instance variables.
     */
    public float speed = 1.0f;

    /*
     * The Start() function is called before the first frame update
     */
    void Start()
    {
        /*
         * In Unity we can, but do not have to write code
         * to create sprites, so there is nothing to do
         * here - Rider will tell us that this function is
         * redundant until we add code to it.
         */
    }

    /*
     * The Update() is called once per frame - like the draw()
     * function in Game Lab.
     */
    void Update()
    {
        // Unity clears the background for us.

        // Read the horizontal movement keys (left & right arrows).
        var h = Input.GetAxisRaw("Horizontal");

        // Counter pattern.
        var pos = transform.position;
        pos.x = pos.x + h * speed;
        transform.position = pos;

        // Ditto with drawing the sprites.
    }
}