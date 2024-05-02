using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using TMPro;
public class Gem : MonoBehaviour {

    public bool isAnimated = false;

    public Material[] colorArray;
    public int index = 0;
    //[SerializeField] GameObject colorInput;
    //public string colorInputText;
    public string materialName
    {
        get { return colorArray[index].name; }
        private set { }
    }

    // Use this for initialization
    void Start () 
	{
		isAnimated = true;
	}
	
	// Update is called once per frame
	void Update()
    {

    }
    private void OnMouseDown()
    {
        DisplayText();
    }
    public virtual void DisplayText() { }

    public void CheckValidColor(string color)
    {
        for (int i = 0; i < colorArray.Length; i++)
        {
            if (colorArray[i].name.Equals(color))
            {
                index = i;
                materialName = colorArray[i].name;
            }
        }
    }
}
