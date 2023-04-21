using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
[AddComponentMenu("Corgi Engine/Items/Gem")]
public class Gem : PickableItem
{

    /* private int gemaitas = 0;
     public int congemitas = 0;*/
    public GameObject gemCounter;
    
   
    [SerializeField]
    public int valor_gema;
    
    
    
    
    [SerializeField] private GemCounter puntaje;
    




    private void Start()
    {
        
        
       
     

    }                   
    private void Update()
    {
       
    }
    protected override void Pick(GameObject picker)
    {
        //congemitas += 1;

        GemCounter.scoreValue += valor_gema;
        
        //contador_gemas = contador_gemas +1 ;
        // anim.SetInteger("gemC", contador_gemas);





        //contador_gemas += valor_gema;







    }

    
}
