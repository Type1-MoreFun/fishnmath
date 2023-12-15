using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class LogicScript : MonoBehaviour
{

    public GameObject mapSelection;
    public GameObject menu;
    public GameObject additionMap;
    public GameObject subtractionMap;
    public GameObject multiMap;
    public GameObject divMap;
    public GameObject[] additionlevelObjects;
    public GameObject[] subtractionlevelObjects;
    public GameObject[] multilevelObjects;
    public GameObject[] divlevelObjects;
    public GameObject statsScreen;

    //The generalized toggleMap will make it so that the menu disappears and that the map selection is brought up to choose from:
    // Addition, Subtraction, Multiplication or Division.
    public void toggleMap()
    {
        mapSelection.SetActive(true);
        menu.SetActive(false);
    }

    public void toggleAdditionMap()
    {
        additionMap.SetActive(true);
        mapSelection.SetActive(false);
    }

    public void toggleSubtractionMap()
    {
        subtractionMap.SetActive(true);
        mapSelection.SetActive(false);
    }

    public void toggleMultiMap()
    {
        multiMap.SetActive(true);
        mapSelection.SetActive(false);
    }

    public void toggleDivMap()
    {
        divMap.SetActive(true);
        mapSelection.SetActive(false);
    }

    public void ShowAdditionLevel(int levelIndex)
    {
        //check if the index is within the bounds of the levels array
        if (levelIndex >= 0 && levelIndex < additionlevelObjects.Length)
        {
            // Deactivate all levels
            for (int i = 0; i < additionlevelObjects.Length; i++)
            {
                additionlevelObjects[i].SetActive(i == levelIndex);
            }
            additionMap.SetActive(false);


        }
        else
        {
            Debug.LogError("Invalid level index");
        }
    }

    public void ShowSubtractionLevel(int levelIndex)
    {
        //Check if the index is within the bounds of the levels array
        if (levelIndex >= 0 && levelIndex < subtractionlevelObjects.Length)
        {
            // Deactivate all levels
            for (int i = 0; i < subtractionlevelObjects.Length; i++)
            {
                subtractionlevelObjects[i].SetActive(i == levelIndex);
            }
            subtractionMap.SetActive(false);


        }
        else
        {
            Debug.LogError("Invalid level index");
        }
    }


    public void ShowMultiLevel(int levelIndex)
    {
        // Check if the index is within the bounds of the levels array
        if (levelIndex >= 0 && levelIndex < multilevelObjects.Length)
        {
            //Deactivating all of the levels since only multiplkcation should be showing
            for (int i = 0; i < multilevelObjects.Length; i++)
            {
                multilevelObjects[i].SetActive(i == levelIndex);
            }
            multiMap.SetActive(false);


        }
        else
        {
            Debug.LogError("Invalid level index");
        }
    }

    public void ShowDivLevel(int levelIndex)
    {
        // Check if the index is within the bounds of the levels array
        if (levelIndex >= 0 && levelIndex < divlevelObjects.Length)
        {
            //deactivating all of the levels again
            for (int i = 0; i < divlevelObjects.Length; i++)
            {
                divlevelObjects[i].SetActive(i == levelIndex);
            }
            divMap.SetActive(false);


        }
        else
        {
            Debug.LogError("Invalid level index");
        }
    }
}
