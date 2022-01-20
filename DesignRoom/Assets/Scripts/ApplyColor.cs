using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyColor : MonoBehaviour
{

    Selection selection;
    
    Renderer rend;

    public void RedColor() 
    {
        selection = GetComponent<Selection>();
        rend = selection.selected.GetComponent<Renderer>();
        rend.material.color = Color.red;
    }

    public void GreenColor()
    {
        selection = GetComponent<Selection>();
        rend = selection.selected.GetComponent<Renderer>();
        rend.material.color = Color.green;
    }

    public void GreyColor()
    {
        selection = GetComponent<Selection>();
        rend = selection.selected.GetComponent<Renderer>();
        rend.material.color = Color.grey;
    }

    public void BlackColor()
    {
        selection = GetComponent<Selection>();
        rend = selection.selected.GetComponent<Renderer>();
        rend.material.color = Color.black;
    }

    public void BlueColor()
    {
        selection = GetComponent<Selection>();
        rend = selection.selected.GetComponent<Renderer>();
        rend.material.color = Color.blue;
    }

    public void WhiteColor()
    {
        selection = GetComponent<Selection>();
        rend = selection.selected.GetComponent<Renderer>();
        rend.material.color = Color.white;
    }

    public void YellowColor()
    {
        selection = GetComponent<Selection>();
        rend = selection.selected.GetComponent<Renderer>();
        rend.material.color = Color.yellow;
    }

    public void DefaultColor() 
    {
        selection = GetComponent<Selection>();
        rend = selection.selected.GetComponent<Renderer>();
        rend.material = rend.material;
        
    }
}
