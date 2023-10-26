using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class EcoBrick : MonoBehaviour
{
    [SerializeField]
    public Image pickUpButton;
    //public TextMeshProUGUI pickUpText;
    
    private bool pickUpAllowed;

    private void Start()
    {
        pickUpButton.gameObject.SetActive(false);
               
    }

    private void Update()
    {
        if(pickUpAllowed && Input.GetKeyDown(KeyCode.E))
            PickUp();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {   
        
        if(collision.gameObject.name.Equals("Playar Rigidbody"))
        {   //Debug.Log("nabrak");
            pickUpButton.gameObject.SetActive(true);
            
 
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.name.Equals("Playar Rigidbody"))
        {
            pickUpButton.gameObject.SetActive(false);

        }
    }

    private void PickUp()
    {
        Destroy(gameObject);
    }
}
