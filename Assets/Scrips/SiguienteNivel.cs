using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
public class SiguienteNivel : FinishLevel
{

	private Gem necesario;


	
	public virtual void GoToNextLevel()
	{
		if ((necesario.contador_gemas == 2) && (necesario.contador_fuel == 3))
		{
			
		
		if (LevelManager.HasInstance)
		{
			LevelManager.Instance.GotoLevel(LevelName, (DelayBeforeTransition == 0f));
		}
		else
		{
			MMSceneLoadingManager.LoadScene(LevelName);
		}
		}
        else
        {
			Debug.Log("nop");
        }
	}
}
