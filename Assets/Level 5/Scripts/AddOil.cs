using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddOil : MonoBehaviour
{
	public GameObject Oil;
	// Update is called once per frame
	void Update()
	{
		if (GetComponent<Toggle>().isOn)
		{
			if (!TickObject.instance.Paused)
			{
				if (TickObject.instance.TotalCO2 % 20 == 0)
				{
					Oil.transform.localScale += new Vector3(0.035f, 0, 0.035f);
				}
			}
		}
	}
}
