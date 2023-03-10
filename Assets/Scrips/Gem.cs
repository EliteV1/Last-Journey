using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Gem : PickableItem
{

    /* private int gemaitas = 0;
     public int congemitas = 0;*/
    public GameObject gemCounter;
    public GameObject fuelCounter;
    private Animator anim;
    [SerializeField]
    private int valor_gema;
    [SerializeField]
    private int valor_fuel;
    private GemCounter control_gemas;
    public int contador_gemas;
    public int contador_fuel;
    public bool completado;

    

    private void Start()
    {
        anim = gemCounter.GetComponent<Animator>();
        anim = fuelCounter.GetComponent<Animator>();
        contador_gemas = 0;
        completado = false;

}
    protected override void Pick(GameObject picker)
    {
        //congemitas += 1;
       if(valor_gema > 0)
        {
            contador_gemas += valor_gema;
            anim.SetInteger("gemC", contador_gemas);
        }
        //contador_gemas += valor_gema;

        if (valor_fuel > 0)
        {
            contador_fuel += valor_fuel;
            anim.SetInteger("fuelC", contador_fuel);
        }
        
        Debug.Log(contador_gemas);

       
        
    }

    public void Contar()
    {
        if(contador_fuel == 3 && contador_gemas == 2)
        {
            
            completado=true;
            Debug.Log("completado");
        }
    }
}
