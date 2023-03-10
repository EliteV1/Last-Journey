using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class Fuel : PickableItem
{
    public GameObject fuelCounter;
    private Animator anim;
    [SerializeField]
    private int valor_fuel;
    public int contador_fuel;
    public bool completadof;


    private void Start()
    {
        
        anim = fuelCounter.GetComponent<Animator>();
        
        completadof = false;

    }
    protected override void Pick(GameObject picker)
    {
        //congemitas += 1;

        
        contador_fuel += valor_fuel;
        Debug.Log(contador_fuel);

        
        anim.SetInteger("fuelC", contador_fuel);
    }

    public void Contar()
    {
        if (contador_fuel == 3)
        {

            completadof = true;
            Debug.Log("completado");
        }
    }
}
