using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;

public class ControlAleatorio : MonoBehaviour
{
    [SerializeField] private List<Gem> gemas;

    private int[] indices = { 0, 1};

    private void Start()
    {
        Shuffle();
        OcultarGem();
        MostrarGem(2);


    }

    public void MostrarGem(int total)
    {
        int indice_gem;
        if(total >=0 && total<gemas.Count){

            for(int i=0; i<total;i++){
                    indice_gem = indices[i];
                gemas[indice_gem].Mostrar();
            }        
        }
    }

    public void OcultarGem()
    {
        for (int i = 0; i < gemas.Count; i++)
        {
            gemas[i].Ocultar();
        }
    }

    public void Shuffle()
    {
        for(int t = 0; t<indices.Length; t++)
        {
            int tmp = indices[t];
            int r = Random.Range(t, indices.Length);
            indices[t] = indices[r];
            indices[r] = tmp;
        }
    }
}
