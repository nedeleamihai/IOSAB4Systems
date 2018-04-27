using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//We will use this class to create elements from the list in the left side
public class Element : MonoBehaviour {

	public Image image;
	public Text Name;
	
	public void Create(Developer developer){
		image.sprite = developer.image;
		Name.text = developer.Name;
	}
}
