using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SphereJewel : Gem
{
    public TextMeshProUGUI screenText2;
    public Vector3 startScale;
    public Vector3 endScale;

    public bool scalingUp = true; //protection
    public float scaleSpeed;
    public float scaleRate;
    public float scaleTimer; //protection
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ScaleShape();
    }

    private void ScaleShape()
    {
        scaleTimer += Time.deltaTime;

        if (scalingUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, endScale, scaleSpeed * Time.deltaTime);
        }
        else if (!scalingUp)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, startScale, scaleSpeed * Time.deltaTime);
        }

        if (scaleTimer >= scaleRate)
        {
            if (scalingUp) { scalingUp = false; }
            else if (!scalingUp) { scalingUp = true; }
            scaleTimer = 0;
        }
    }
    public override void DisplayText()
    {
        screenText2.SetText("IS");
    }
}
