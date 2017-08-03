using UnityEngine;

public class CameraAdaptation : MonoBehaviour {

	public float baseWidth = 1080;
	public float baseHeight = 1920;
	public float baseOrthographicSize = 391.5315f;
	public Camera cam;

	void Awake(){

		float newOrthographicSize = (float)Screen.height / (float)Screen.width * this.baseWidth / this.baseHeight * this.baseOrthographicSize;
		cam.orthographicSize = Mathf.Max(newOrthographicSize , this.baseOrthographicSize);
	}
		
}
