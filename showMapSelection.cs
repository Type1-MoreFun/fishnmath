using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowMapSelection : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject mapSelectionUI; // Reference to the UI element for map selection.

    public void ToggleMapSelection()
    {

        mapSelectionUI.SetActive(true);
        mainMenu.SetActive(false);

    }
}