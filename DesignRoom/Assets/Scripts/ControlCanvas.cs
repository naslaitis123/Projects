using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCanvas : MonoBehaviour
{
    Selection selection;

    // Start is called before the first frame update
    void Start()
    {
        
        selection = GetComponent<Selection>();
    }

    // Update is called once per frame
    void Update()
    {
        
       // selection.selected.transform.position = transform.up * 10;
    }

    public void MoveRight() 
    {
        selection.selected.transform.parent.Translate(Vector3.forward * 0.2f);
    }

    public void MoveLeft()
    {
        
        selection.selected.transform.parent.Translate(Vector3.back * 0.2f);
        
    }

    public void MoveUp()
    {
        selection.selected.transform.parent.Translate(Vector3.left * 0.2f);
    }

    public void MoveDown()
    {
       
        
        selection.selected.transform.parent.Translate(Vector3.right * 0.2f);
        
        
    }

    public void DestroyObject() 
    { 
        Destroy(selection.selected);
    }

    public void RotateObjectPlus() 
    {
        selection.selected.transform.Rotate(0, 0, 90);
    }

    public void RotateObjectMinus() 
    {
        selection.selected.transform.Rotate(0, 0, -90);
    }

    public void Back() 
    {
        selection.defaultCanvas.gameObject.SetActive(true);
        selection.controlCanvas.gameObject.SetActive(false);
    }

}
