using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SpawnFish : MonoBehaviour
{
	public Object[] Fish;
	Object fishClone;
	// Update is called once per frame
	void Update()
	{
		if (GetComponent<Toggle>().isOn)
		{
			if (!TickObject.instance.Paused)
			{
				if (TickObject.instance.TotalCO2 % 50 == 0)
				{
					int drop = Random.Range(0, 10);
					if (drop == 1)
					{
						int fishIndex = Random.Range(0, Fish.Length);
						fishClone = GameObject.Instantiate(Fish[fishIndex]);
						fishClone.GameObject().transform.localRotation = new Quaternion(0, 0, 90, 0);
						int posX = Random.Range(-50, 20);
						int posZ = Random.Range(-40, 40);
						fishClone.GameObject().transform.localPosition = new Vector3(posX, 6, posZ);
					}
				}
			}
		}
		
	}
}