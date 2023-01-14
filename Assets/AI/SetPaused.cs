using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SetPaused : MonoBehaviour
{
	public Object PauzeMenu;
	public Object Canvas;

	void Start()
	{
		if (PauzeMenu == null)
		{
			PauzeMenu = GameObject.FindGameObjectWithTag("PauzeMenu");
		}
		if (Canvas == null)
		{
			Canvas = GameObject.Find("Canvas");
		}
		PauzeMenu.GetComponent<Canvas>().enabled = false;
	}

	public void ToggleTick()
	{
		if (TickObject.instance.Paused)
		{
			TickObject.instance.Paused = false;
			PauzeMenu.GetComponent<Canvas>().enabled = false;
			Canvas.GetComponent<Canvas>().enabled = true;
		}
		else
		{
			TickObject.instance.Paused = true;
			PauzeMenu.GetComponent<Canvas>().enabled = true;
			Canvas.GetComponent<Canvas>().enabled = false;
		}
	}
}
