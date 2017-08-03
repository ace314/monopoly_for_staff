using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	public GameObject home_position;
	public GameObject bank_position;
	public GameObject chance_and_community_chest_position;
	public GameObject casino_position;
	public GameObject grocery_shop_position;
	public GameObject court_position;
	public GameObject jail_position;
	public GameObject police_position;
	public GameObject wall_street_position;
	public GameObject hospital_position;
	public GameObject post_office_position;
	public GameObject robber_position;
	public GameObject knife_shop_position;
	public GameObject mansion_position;
	public GameObject working_space_position;
	public GameObject estat_position;

	public GameObject return_window;

	// Use this for initialization
	void Start () {
		
	}

	public void ChangePage(int ID){
		home_position.gameObject.SetActive (false);
		switch (ID){
			case 1:
				bank_position.gameObject.SetActive (true);
				break;
			case 2:
				chance_and_community_chest_position.gameObject.SetActive (true);
				break;
			case 3:
				casino_position.gameObject.SetActive (true);
				break;
			case 4:
				grocery_shop_position.gameObject.SetActive (true);
				break;
			case 5:
				court_position.gameObject.SetActive (true);
				break;
			case 6:
				jail_position.gameObject.SetActive (true);
				break;
			case 7:
				police_position.gameObject.SetActive (true);
				break;
			case 8:
				wall_street_position.gameObject.SetActive (true);
				break;
			case 9:
				hospital_position.gameObject.SetActive (true);
				break;
			case 10:
				post_office_position.gameObject.SetActive (true);
				break;
			case 11:
				robber_position.gameObject.SetActive (true);
				break;
			case 12:
				knife_shop_position.gameObject.SetActive (true);
				break;
			case 13:
				mansion_position.gameObject.SetActive (true);
				break;
			case 14:
				working_space_position.gameObject.SetActive (true);
				break;
			case 15:
				estat_position.gameObject.SetActive (true);
				break;
		}
	}

	public void BackToHome(int ID){
		switch (ID){
			case 1:
				bank_position.gameObject.SetActive (false);
				break;
			case 2:
				chance_and_community_chest_position.gameObject.SetActive (false);
				break;
			case 3:
				casino_position.gameObject.SetActive (false);
				break;
			case 4:
				grocery_shop_position.gameObject.SetActive (false);
				break;
			case 5:
				court_position.gameObject.SetActive (false);
				break;
			case 6:
				jail_position.gameObject.SetActive (false);
				break;
			case 7:
				police_position.gameObject.SetActive (false);
				break;
			case 8:
				wall_street_position.gameObject.SetActive (false);
				break;
			case 9:
				hospital_position.gameObject.SetActive (false);
				break;
			case 10:
				post_office_position.gameObject.SetActive (false);
				break;
			case 11:
				robber_position.gameObject.SetActive (false);
				break;
			case 12:
				knife_shop_position.gameObject.SetActive (false);
				break;
			case 13:
				mansion_position.gameObject.SetActive (false);
				break;
			case 14:
				working_space_position.gameObject.SetActive (false);
				break;
			case 15:
				estat_position.gameObject.SetActive (false);
				break;
		}
		home_position.gameObject.SetActive (true);
	}

	public void close_return_window(){
		return_window.gameObject.SetActive(false);
	}
	// Update is called once per frame
	void Update () {
		
	}
}
