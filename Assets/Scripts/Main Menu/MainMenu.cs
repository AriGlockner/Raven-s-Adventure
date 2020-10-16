using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public bool isStart;
    public bool isControl;
    public bool isQuit;

	void Start()
	{
		GetComponent<Renderer>().material.color = Color.black;
	}
	
	void OnMouseEnter()
	{
		GetComponent<Renderer>().material.color = Color.red;
	}
	
	void OnMouseExit()
	{
		if (isStart) start();
		if (isControl) control();
		if (isQuit) quit();
		
	}
	
	void start()
	{
		Debug.Log("Start");
		GetComponent<Renderer>().material.color = Color.black;
	}
	
	void control()
	{
		Debug.Log("Controls");
		GetComponent<Renderer>().material.color = Color.black;
	}
	
	void quit()
	{
		Debug.Log("Quit");
		GetComponent<Renderer>().material.color = Color.black;
	}
}