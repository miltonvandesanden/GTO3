using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameController gameController;

	// Use this for initialization
	void Start()
    {
        this.transform.position.Set(gameController.lane2_2.x, gameController.lane2_2.y, 0);
    }
	
	// Update is called once per frame
	void Update(){}
}
