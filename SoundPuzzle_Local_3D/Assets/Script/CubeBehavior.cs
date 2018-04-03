using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeBehavior : MonoBehaviour {
    public int cubeNumber = 0;
    public float dropSpeed = 1.0f;
    public AudioClip m_Clip;
    public Text cubeNumText;
    public bool isMovable = true;
	// Use this for initialization
	void Start () {
        cubeNumText = transform.GetComponentInChildren<Text>();
        cubeNumText.text = cubeNumber.ToString();
	}
	
	// Update is called once per frame
	/*void Update () {
        cubeMove();
    }*/

    private void FixedUpdate()
    {
        if(isMovable)
            cubeMove();
    }

    void cubeMove()
    {
        transform.Translate(dropSpeed * Time.deltaTime * Vector3.back);
    }


    public void cubeTouched()
    {
        Debug.Log("Touch the cube" + cubeNumber);
    }
}
