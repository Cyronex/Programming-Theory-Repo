using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeJewel : Gem
{
    public TextMeshProUGUI screenText3;
    public float floatSpeed;
    public bool goingUp = true; //protection
    public float floatRate;
    public float floatTimer; //protection
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FloatShape();
    }

    private void FloatShape()
    {
        floatTimer += Time.deltaTime;
        Vector3 moveDir = new Vector3(0.0f, 0.0f, floatSpeed);
        transform.Translate(moveDir);

        if (goingUp && floatTimer >= floatRate)
        {
            goingUp = false;
            floatTimer = 0;
            floatSpeed = -floatSpeed;
        }

        else if (!goingUp && floatTimer >= floatRate)
        {
            goingUp = true;
            floatTimer = 0;
            floatSpeed = +floatSpeed;
        }
    }
    public override void DisplayText()
    {
        screenText3.SetText("POLYMORPHISM");
    }
}

