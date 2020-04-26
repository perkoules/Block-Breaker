using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {



	public void LoadLevel(string name){
		Brick.breakableCount = 0;
		Application.LoadLevel(name);
	}
	public void QuitRequest(){
		Application.OpenURL ("http://perkoules.itch.io/");
	}

	public void LoadNextLevel(){
		Brick.breakableCount = 0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}

	public void BrickDestroyed(){
		if (Brick.breakableCount <= 0){
			ModeSelect();
		}
	}

	public void  ModeSelect(){
		StartCoroutine("Wait");
		
	}
	
	IEnumerator Wait()
	{
		yield return new WaitForSeconds(1);
		LoadNextLevel();
	}
}
