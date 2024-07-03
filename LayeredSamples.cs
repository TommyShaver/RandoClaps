using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LayeredSamples : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _layerSamples;
    [SerializeField] private int _whichPlayer;
    public void DropDownUI(int index)
    {
        switch (index)
        {
            case 0:
                _layerSamples.SetActive(false);
                _mainMenu.SetActive(true);
                break;
            case 1:
                ClapManager._instance.WhichSample(_whichPlayer, 0);
                break;
            case 2:
                ClapManager._instance.WhichSample(_whichPlayer, 1);
                break;
            case 3:
                ClapManager._instance.WhichSample(_whichPlayer, 2);
                break;
            case 4:
                ClapManager._instance.WhichSample(_whichPlayer, 3);
                break;
            case 5:
                ClapManager._instance.WhichSample(_whichPlayer, 4);
                break;
            case 6:
                ClapManager._instance.WhichSample(_whichPlayer, 5);
                break;
            case 7:
                ClapManager._instance.WhichSample(_whichPlayer, 6);
                break;
            case 8:
                ClapManager._instance.WhichSample(_whichPlayer, 7);
                break;
            case 9:
                ClapManager._instance.WhichSample(_whichPlayer, 8);
                break;
        }
    }
}
