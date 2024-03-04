using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public GameObject Prompt;
    public Vector2 speed = new Vector2(50, 50);
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        //player movement
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(speed.x * inputX, speed.y * inputY, 0);

        movement *= Time.deltaTime;

        transform.Translate(movement);
    }

    // On Enter press, triggers prompt.
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Interactable")
        {
            Prompt.SetActive(true);
        }
    }
    
    void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Interactable")
        {
            Prompt.SetActive(false);
        }
    }

}
