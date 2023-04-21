using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
[AddComponentMenu("Corgi Engine/Items/Fuel")]
public class Fuel : PickableItem
{

    /* private int gemaitas = 0;
     public int congemitas = 0;*/
   
    public GameObject fuelCounter;
  
    [SerializeField]
    private int valor_fuel;



  
    [SerializeField] private FuelCounter fuel;




    private void Start()
    {





    }
    private void Update()
    {

    }
    protected override void Pick(GameObject picker)
    {
        //congemitas += 1;

       
        FuelCounter.scoreValueF += valor_fuel;
        //contador_gemas = contador_gemas +1 ;
        // anim.SetInteger("gemC", contador_gemas);





        //contador_gemas += valor_gema;







    }


}

