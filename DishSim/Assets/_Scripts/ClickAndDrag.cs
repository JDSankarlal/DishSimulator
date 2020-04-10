using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickAndDrag : MonoBehaviour
{
    bool isPicked = false;

    void Update()
    {
        if (isPicked)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition); 
            //if MouseOver is true, and MouseButton(0) is true, move plate to mouse position
            transform.position = (pos);
        }

        if (Input.GetMouseButtonUp(0))
        {
            isPicked = false; //If mousebutton released, isPicked = false. Should stop plate tracking mouse pos?
        }       
    }
   
    void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            isPicked = true;   //Basic shit.
        }   
    }

    void OnMouseExit() //Also self explanatory
    {
        
        isPicked = false;
    }


}
