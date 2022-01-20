using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    public Canvas defaultCanvas;
    public Canvas selectedObjectCanvas;

    public GameObject kubas;

    public Vector3 pos;
    public Image colorUi;
    public Canvas controlCanvas;

    public Transform _selection;

    public GameObject selected ;

    public Color colorAply;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(ray, out hit))
            {

                var selection = hit.transform;

                if (selection.CompareTag("Furniture"))
                {
                    var selectionRenderer = selection.GetComponent<Renderer>();

                    if (selectionRenderer != null)
                    {
                        //selectedObjectCanvas.gameObject.SetActive(true);
                    }
                    
                    //_selection = selection;



                    if (Input.GetMouseButtonDown(0))
                    {
                        Debug.Log(selection);
                        
                        defaultCanvas.gameObject.SetActive(false);
                        controlCanvas.gameObject.SetActive(true);
                        
                    }


                    selected = selection.gameObject;

                }
            }
        }
        
    }
}
