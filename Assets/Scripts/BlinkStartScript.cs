using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlinkStartScript : MonoBehaviour {

	public float intervalo = 0.5f;
	// Use this for initialization
	IEnumerator Start () {
		GetComponent<SpriteRenderer>().enabled = false;
		yield return new WaitForSeconds(intervalo);
		GetComponent<SpriteRenderer>().enabled = true;
		yield return new WaitForSeconds(intervalo);

		StartCoroutine(Start());
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return))
		{
			SceneManager.LoadScene("game-scene");
		}		
	}
}
