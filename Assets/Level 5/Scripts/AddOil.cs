using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddOil : MonoBehaviour
{
	public GameObject Oil; //Oil property
						   // Update is called once per frame
	void Update()
	{
		if (GetComponent<Toggle>().isOn) //check if Toggle is on
		{
			if (!TickObject.instance.Paused) // check if game is paused
			{
				Oil.transform.localScale += new Vector3(0.035f, 0, 0.035f); //increase size of the oil
			}
		}
		else
		{
			if (Oil.transform.localScale.x > 0 && Oil.transform.localScale.z > 0) //check if oil size is bigger than 0
			{
				Oil.transform.localScale -= new Vector3(0.035f, 0, 0.035f); //if it is greater than 0, then shrink oil
			}
		}
	}
}
