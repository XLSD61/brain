using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeUpPanel : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(PanelDeactiveted());
    }


    IEnumerator PanelDeactiveted()
    {
        gameObject.SetActive(true);
        yield return new WaitForSeconds(2f);
        gameObject.SetActive(false);
    }
}
