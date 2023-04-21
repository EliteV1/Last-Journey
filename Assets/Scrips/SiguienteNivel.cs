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
		
			
		
		if (LevelManager.HasInstance)
		{
			LevelManager.Instance.GotoLevel(LevelName, (DelayBeforeTransition == 0f));
		}
		else
		{
			MMSceneLoadingManager.LoadScene(LevelName);
		}
		
        
	}
}
