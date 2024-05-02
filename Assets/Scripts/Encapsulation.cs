using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Encapsulation : Gem
{
    [SerializeField] GameObject colorInput;
    private string colorRequest;
    //Button activates the method
    public void EnterRequest()
    {
        colorRequest = colorInput.GetComponent<TMP_InputField>().text;
        Debug.Log(colorRequest);
        if (!materialName.Equals(colorRequest))
        {
            CheckValidColor(colorRequest);
            ChangeMat();
        }
    }

    private void ChangeMat()
    {
        GetComponent<MeshRenderer>().material = colorArray[index];
    }

}
