using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenuCanvasJump : MonoBehaviour {

	public GameObject optionMenuCanvas;

	public void NewGame(){
		StartCoroutine(LoadAsyncScene());
	}
	public void OptionMenu(){
        optionMenuCanvas.SetActive(true);
	}

	IEnumerator LoadAsyncScene(){
		AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Example");
		while (!asyncLoad.isDone){
			yield return null;
		}
	}

}
