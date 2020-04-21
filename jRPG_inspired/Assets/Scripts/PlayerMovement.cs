using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 5f;
    // ItemPanel_Animation animation = new ItemPanel_Animation();
    public GameObject inventoryPanel;


    
    private Rigidbody2D rbody2D;
    // Start is called before the first frame update
    void Start()
    {
        // finds the rigidbody attached to this gameobject
        rbody2D = GetComponent<Rigidbody2D>();
        
    }

    // Update happens regardless of framerate
    private void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); // a number between -1 and 1
        float moveVertical = Input.GetAxis("Vertical"); // a number between -1 and 1

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rbody2D.velocity = movement * speed;
        //rbody2D.AddForce(movement * speed);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            if(!inventoryPanel.activeInHierarchy)
            {
                inventoryPanel.SetActive(true);
            }
            else
            {
                inventoryPanel.SetActive(false);
            }
            // animation.AnimateIn();
            

        }
    }
}
