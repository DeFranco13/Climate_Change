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
		if (GetComponent<Toggle>().isOn) //check if toggle is on
		{
			if (!TickObject.instance.Paused) //check if game is paused
			{
				int drop = Random.Range(0, 10); //generate random int
				if (drop == 1) //if random is 1 then generate a random fish, which is added in the menu, and assign generated position .
				{
					int fishIndex = Random.Range(0, Fish.Length);
					fishClone = GameObject.Instantiate(Fish[fishIndex]);
					fishClone.GameObject().transform.localRotation = new Quaternion(0, 0, 90, 0); // turn fish upside down to imitate a dead fish
					int posX = Random.Range(-50, 20);
					int posZ = Random.Range(-40, 40);
					fishClone.GameObject().transform.localPosition = new Vector3(posX, 6, posZ);
				}
			}
		}
	}
}