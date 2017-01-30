using UnityEngine;
using System.Collections;

public class score : MonoBehaviour {

    public GameObject Ball;
	public static int Gamescore = 0;
	public score()
	{
	}


    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	
	}
  
    private void OnTriggerEnter(Collider collision)
    {
        //Ball.gameObject.GetComponent<SphereCollider>().enabled =false;
        Gamescore = Gamescore + 1;
		Debug.Log("Score is : "+Gamescore);
       
    }




} 

