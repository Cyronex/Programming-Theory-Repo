using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DiamondJewel : Gem
{
    public TextMeshProUGUI screenText;
    public bool isRotating = false;
    public bool isFloating = false;
    public bool isScaling = false;

    public Vector3 rotationAngle;
    public float rotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RotateShape();
    }

    public void RotateShape()
    {
        transform.Rotate(rotationAngle * rotationSpeed * Time.deltaTime);
    }

    public override void DisplayText()
    {
        screenText.SetText("THIS");
    }

}
