using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CreateObject : MonoBehaviour
{
    public GameObject[] prefabs;
    private Vector3 offset = new Vector3(2, 0, -1);

    int chairsCount = 0;
    int sofaCount = 0;
    int tableCount = 0;
    

   

    //public Vector3 chairPos;
    Quaternion rotations;

    private void Start()
    {
        
    }

    public void Update()
    {
        
    }

    public void CreateObjectFromName(Button btn)
    {
        for (int i = 0; i < prefabs.Length; i++)
        {
            if (btn.name == prefabs[i].name)
            {
                if (prefabs[i].name == "CharTest")
                {
                    var objected = Instantiate(prefabs[i], offset, prefabs[i].transform.rotation);
                    objected.name = prefabs[i].name + chairsCount;
                    chairsCount++;
                }
                
                if (prefabs[i].name == "Sofa") 
                {
                    var objected = Instantiate(prefabs[i], offset, prefabs[i].transform.rotation);
                    objected.name = prefabs[i].name + sofaCount;
                    sofaCount++;
                }

                if (prefabs[i].name == "Table") 
                {
                    var objected = Instantiate(prefabs[i], offset, prefabs[i].transform.rotation);
                    objected.name = prefabs[i].name + tableCount;
                    tableCount++;
                }

                /*if (prefabs[i].name == "BedPrefab")
                {
                    var objected = Instantiate(prefabs[i], offset, prefabs[i].transform.rotation);
                    objected.name = prefabs[i].name + bedCount;
                    bedCount++;
                }*/

                offset = Vector3.forward + offset;

                if (offset.z >= 4) 
                {
                    offset.z = -1;
                }
            }
        }
    }

    /*public void DeleteAll()
    {
        prefabs = GameObject.FindGameObjectsWithTag("Furniture");

        for (int i = 0; i <prefabs.Length; i++)
        {
            Destroy(prefabs[i]);
        }
    }*/

    public void LoadPrefs() 
    {
        
        for(int i = 0; i < PlayerPrefs.GetInt("ChairCount"); i++)
        {
            offset = new Vector3(PlayerPrefs.GetFloat("ChairPositionX" +i), 0, PlayerPrefs.GetFloat("ChairPositionZ" + i));
            var objected = Instantiate(prefabs[1], offset, prefabs[i].transform.rotation);
            objected.name = prefabs[1].name + chairsCount;
            chairsCount++;
        }

        for (int i = 0; i < PlayerPrefs.GetInt("SofaCount"); i++) 
        {
            offset = new Vector3(PlayerPrefs.GetFloat("SofaPositionX" + i), 0, PlayerPrefs.GetFloat("SofaPositionZ" + i));
            var objected = Instantiate(prefabs[0], offset, prefabs[i].transform.rotation);
            objected.name = prefabs[0].name + sofaCount;
            sofaCount++;
        }

        for (int i = 0; i < PlayerPrefs.GetInt("TableCount"); i++)
        {
            offset = new Vector3(PlayerPrefs.GetFloat("TablePositionX" + i), 0, PlayerPrefs.GetFloat("TablePositionZ" + i));
            var objected = Instantiate(prefabs[3], offset, prefabs[i].transform.rotation);
            objected.name = prefabs[3].name + tableCount;
            tableCount++;
        }
        
        
    }

    public void SavePrefs() 
    {
        PlayerPrefs.SetInt("ChairCount", chairsCount);
        PlayerPrefs.SetInt("SofaCount", sofaCount);
        PlayerPrefs.SetInt("TableCount", tableCount);

        GameObject objectToFind;
        
        for (int i = 0; i < PlayerPrefs.GetInt("ChairCount"); i++)
        {
            if (objectToFind = GameObject.Find("CharTest" + i))
            {
                Debug.Log(objectToFind);
                PlayerPrefs.SetFloat("ChairPositionX" + i, objectToFind.transform.position.x);
                PlayerPrefs.SetFloat("ChairPositionZ" + i, objectToFind.transform.position.z);
            }   
        }

        for (int i = 0; i < PlayerPrefs.GetInt("SofaCount"); i++)
        {
            if (objectToFind = GameObject.Find("Sofa" + i))
            {
                Debug.Log(objectToFind);
                PlayerPrefs.SetFloat("SofaPositionX" + i, objectToFind.transform.position.x);
                PlayerPrefs.SetFloat("SofaPositionZ" + i, objectToFind.transform.position.z);
            }
        }

        for (int i = 0; i < PlayerPrefs.GetInt("TableCount"); i++)
        {
            if (objectToFind = GameObject.Find("Table" + i))
            {
                Debug.Log(objectToFind);
                PlayerPrefs.SetFloat("TablePositionX" + i, objectToFind.transform.position.x);
                PlayerPrefs.SetFloat("TablePositionZ" + i, objectToFind.transform.position.z);
            }
        }
        PlayerPrefs.Save();
    }

    /*public void StartSavedRoom()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        

    }

    public void StartScene() 
    {
        
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }

    public void Back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }*/

}
