using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleSamples : MonoBehaviour
{
    [SerializeField] private GameObject _mainMenu;
    [SerializeField] private GameObject _singleSamples;
    [SerializeField] private int _whichPlayer;

    public void DropDownUI(int index)
    {
        switch (index)
        {
            case 0:
                _singleSamples.SetActive(false);
                _mainMenu.SetActive(true);
                break;
            case 1:
                ClapManager._instance.WhichSample(_whichPlayer, 9);
                break;
            case 2:
                ClapManager._instance.WhichSample(_whichPlayer, 10);
                break;
            case 3:
                ClapManager._instance.WhichSample(_whichPlayer, 11);
                break;
            case 4:
                ClapManager._instance.WhichSample(_whichPlayer, 12);
                break;
            case 5:
                ClapManager._instance.WhichSample(_whichPlayer, 13);
                break;
            case 6:
                ClapManager._instance.WhichSample(_whichPlayer, 14);
                break;
            case 7:
                ClapManager._instance.WhichSample(_whichPlayer, 15);
                break;
        }
    }
}
