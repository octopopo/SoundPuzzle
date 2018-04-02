using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeBehavior : MonoBehaviour {
    public int cubeNumber = 0;
    public float dropSpeed;
    public AudioClip m_Clip;
    public Text cubeNumText;
	// Use this for initialization
	void Start () {
        cubeNumText = transform.GetComponentInChildren<Text>();
        cubeNumText.text = cubeNumber.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    
    public void cubeTouched()
    {
        Debug.Log("Touch the cube" + cubeNumber);
    }
}
