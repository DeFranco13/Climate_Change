using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SpreadFire : TickTrigger
{
    public GameObject Fire;
    
   
    
    private Toggle toggle;

    // call the methodes
    
    internal override void OnTickTrigger()
    {
        
       IncreaseFire();
       StopFire();
        //DecreaseFire();
    }

    
    // limiet voor vuur
    private void StopFire()
    {
        if (TickObject.instance.TotalCO2 <= 0)
        {
            Fire.gameObject.SetActive(false);
        }

        if (TickObject.instance.TotalCO2 >= 1000)
        {
            SceneManager.LoadScene("EndScreen");
        }

    }
    // als toggle is aangeduid en pauzeknop niet is ingedrukt , vergroot het vuur ( normaal moet de regen het vuur verkleinen maar dat werkt niet)
    [System.Obsolete]
    private void IncreaseFire()
    {
        if (GetComponent<Toggle>().isOn)
        {
            if (!TickObject.instance.Paused)
            {
                
                if (TickObject.instance.TotalCO2 % 10 == 0)
                {
                    Fire.active = true;
                    Fire.transform.localScale += new Vector3((float)0.08f, (float)0.08f ,0.08f);
                   

                }
               
               

            }
            else
            {
                Fire.active = false;
            }
        }
      
       
    }
   



   
}
