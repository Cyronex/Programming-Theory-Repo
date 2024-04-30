using UnityEngine;
using System.Collections;

public class Gem : MonoBehaviour {

    public bool isAnimated = false;

    public bool isRotating = false;
    public bool isFloating = false;
    public bool isScaling = false;
    
    public Vector3 rotationAngle;
    public float rotationSpeed;

    public float floatSpeed;
    public bool goingUp = true; //protection
    public float floatRate;
    public float floatTimer; //protection
   
    public Vector3 startScale;
    public Vector3 endScale;

    private bool scalingUp = true;
    public float scaleSpeed;
    public float scaleRate;
    private float scaleTimer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update()
    {
        if (isAnimated)
        {
            Animate();
        }
    }
	
    public void Animate()
    {
        if (isRotating)
        {
            Rotate();
        }
        if (isFloating)
        {
            Float();
        }
        if (isScaling)
        {
            Scale();
        }
    }

    public virtual void Rotate()
    {
        Debug.Log("Rotate");
    }

    public void Float()
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

    public void Scale()
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
}
