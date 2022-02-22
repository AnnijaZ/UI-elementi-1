using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject bins;
	public GameObject lacitis;
	public GameObject tante;
	public GameObject masina;
	public GameObject attelaTuretajs;
	public Sprite[] attelumasivs;
	public GameObject slaideris;

	public void binaAttelosana(bool vertiba){
		bins.SetActive (vertiba);
	}

	public void lacisaAttelosana(bool vertiba){
		lacitis.SetActive (vertiba);
	}

	public void tantesAttelosana(bool vertiba){
		tante.SetActive (vertiba);
	}

	public void masinasAttelosana(bool vertiba){
		masina.SetActive (vertiba);
	}

	public void paKreisiBins(){
		bins.transform.localScale = new Vector2 (1, 1);
	}

	public void paLabiBins(){
		bins.transform.localScale = new Vector2 (-1, 1);
	}

	public void izkritosais(int skaitlis){
		if (skaitlis == 0)
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [0];
		else if (skaitlis==1)
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [1];
		else if (skaitlis==2)
			attelaTuretajs.GetComponent<Image> ().sprite = attelumasivs [2];
	}

	public void mainitLielumu(){
		float pasreizejaVertiba = slaideris.GetComponent<Slider> ().value;
		attelaTuretajs.transform.localScale = new Vector2 (1F * pasreizejaVertiba, 1F * pasreizejaVertiba);
	}
}
