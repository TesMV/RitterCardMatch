using UnityEngine;
using System.Collections;

[RequireComponent (typeof(Light))]

public class LightControl : MonoBehaviour {

	private float light_intensity = 0.5f;
	private float light_color = 0.5f;
	private float light_spotangle = 30f;
	
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if(GetComponent<Light>() == null) return;
		
		ColorPick();
		
		GetComponent<Light>().intensity = light_intensity;
		if(GetComponent<Light>().type == LightType.Spot) //Check if light is spotlight
			GetComponent<Light>().spotAngle = light_spotangle;
	}
	
	//Set Color of light using value of the slider
	void ColorPick(){
		if(light_color <= 1){
			GetComponent<Light>().color = new Color(1, light_color, 0);
		}
		else if(light_color <= 2){
			GetComponent<Light>().color = new Color(1 - (light_color-1), 1, 0);
		}
		else if(light_color <= 3){
			GetComponent<Light>().color = new Color(0, 1, light_color - 2);
		}
		else if(light_color <= 4){
			GetComponent<Light>().color = new Color(0, 1 - (light_color - 3), 1);
		}
		else{
			GetComponent<Light>().color = new Color(light_color - 4, 0, 1);
		}
	}
	
	//Draw sliders on screen
	void OnGUI(){
		light_intensity = GUI.HorizontalSlider (new Rect (50, 25, 100, 30), light_intensity, 0f, 1.0f); //Slider intensity
		light_color = GUI.HorizontalSlider (new Rect (50, 75, 100, 30), light_color, 0f, 5.0f); //Slider color
		if(GetComponent<Light>().type == LightType.Spot)//Check if light is spotlight
			light_spotangle = GUI.HorizontalSlider (new Rect (50, 125, 100, 30), light_spotangle, 20f, 50f); //Slider spot angle
	}
}
