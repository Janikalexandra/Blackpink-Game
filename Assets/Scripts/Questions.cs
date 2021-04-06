using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Questions : MonoBehaviour
{
    SpriteRenderer spriteRenderer;

    /// <booleans>
    public bool lisaEats = false;
    public bool lisaSings = false;
    public bool lisaCamel = false;
    public bool lisaCat = false;
    /// </booleans>
    


    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Lisa Eats")
        {
            Debug.Log("Lisa Eats");
        }

        /*if (Input.GetMouseButtonDown(0))
        {
            if (gameObject.tag == "Lisa Eats")
            {
                Debug.Log("Lisa Eats");
            }
        }*/
    }
    private void OnMouseOver()
    {
        spriteRenderer.color = Color.gray;
    }
    private void OnMouseExit()
    {
        spriteRenderer.color = Color.white;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        lisaEats = true;
    }
    public void OnMouseDown()
    {
        if (gameObject.CompareTag("Lisa Eats"))
        {
            lisaEats = true;

        } else if (gameObject.CompareTag("Lisa Camel"))
        {
            lisaCamel = true;
        }
        
    }
}
