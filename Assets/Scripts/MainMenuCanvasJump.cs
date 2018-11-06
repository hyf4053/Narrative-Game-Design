using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuCanvasJump : MonoBehaviour {
	public void NewGame(){
		StartCoroutine(LoadAsyncScene());
	}

	IEnumerator LoadAsyncScene(){
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Example");
		while (!asyncLoad.isDone){
			yield return null;
		}
	}

}
