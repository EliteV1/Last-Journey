using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;
using MoreMountains.CorgiEngine;
public class SiguienteNivel : FinishLevel
{

	private Gem necesario;

	private GemCounter gemitas;
	private FuelCounter combus;


	public virtual void Sepuede()
    {
		if(GemCounter.scoreValue != 2 && FuelCounter.scoreValueF != 3){
			Debug.Log("Nop");
		}

		else
		{ 
			GoToNextLevel();
		}
		}
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
