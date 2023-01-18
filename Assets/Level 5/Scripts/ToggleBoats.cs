using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleBoats : MonoBehaviour
{
	public GameObject boats;
	// Update is called once per frame
	void Update()
	{
		if (GetComponent<Toggle>().isOn) // check if element is toggled
			boats.SetActive(true); // enable boats
		else
			boats.SetActive(false); // disable boats
	}
}
