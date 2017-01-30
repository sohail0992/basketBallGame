using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UI_Controll : MonoBehaviour 
{
	
	public Text MyScore;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		MyScore.text = 	score.Gamescore.ToString ();

	}
}
