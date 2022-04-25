using System.Collections;
using Assets.SimpleLocalization;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiLanguage : MonoBehaviour
{
    [SerializeField] Dropdown dropdown;
    private void Awake()
    {
        LocalizationManager.Read();
        switch (Application.systemLanguage)
        {
            case SystemLanguage.English:
                LocalizationManager.Language = "English";
                break;
            case SystemLanguage.Spanish:
                LocalizationManager.Language = "Spanish";
                break;
            case SystemLanguage.Turkish:
                LocalizationManager.Language = "Turkish";
                break;
            default:
                LocalizationManager.Language = "English";
                break;
        }
       
    }

    public void Language()
    {
        if (dropdown.value == 0)
        {
            LocalizationManager.Language = "English";
            Debug.Log(LocalizationManager.Language);
        }
        if (dropdown.value == 1)
        {
            LocalizationManager.Language = "Spanish";
            Debug.Log(LocalizationManager.Language);
        }
        if (dropdown.value == 2)
        {
            LocalizationManager.Language = "Turkish";
            Debug.Log(LocalizationManager.Language);
        }
    }
}
