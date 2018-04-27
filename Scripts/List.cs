using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Developer{ // Details about developer
	public Sprite image;
	public string Name;
	public string Location;
	public int badges;
}

public class List : MonoBehaviour {
	
	public Sprite Developer1;
	public Sprite Developer2;
	public Sprite Developer3;
	public Sprite Developer4;
	public Sprite Developer5;
	public Sprite Developer6;
	public Sprite Developer7;
	public Sprite Developer8;
	public Sprite Developer9;
	public Sprite Developer10;

	public Button button;

	public Transform Container;
	public Transform Container2;

	public Image imageOutput;
	public Text NameOutput;
	public Text LocationOutput;
	public Text badgesOutput;

	// Use this for initialization
	void Start () {
		List<Developer> l = new List<Developer> {
			new Developer{ image = Developer1, Name = "Developer 1", Location = "Romania", badges = 1 },
			new Developer{ image = Developer2, Name = "Developer 2", Location = "Italy", badges = 12 },
			new Developer{ image = Developer3, Name = "Developer 3", Location = "North America", badges = 13 },
			new Developer{ image = Developer4, Name = "Developer 4", Location = "France", badges = 10 },
			new Developer{ image = Developer5, Name = "Developer 5", Location = "England", badges = 5 },
			new Developer{ image = Developer6, Name = "Developer 6", Location = "South America", badges = 9 },
			new Developer{ image = Developer7, Name = "Developer 7", Location = "North America", badges = 8 },
			new Developer{ image = Developer8, Name = "Developer 8", Location = "France", badges = 23 },
			new Developer{ image = Developer9, Name = "Developer 9", Location = "England", badges = 25 },
			new Developer{ image = Developer10, Name = "Developer 10", Location = "Egypt", badges = 33 }
		};// Developers List

		foreach(var i in l){
			
			imageOutput = Instantiate (imageOutput, Container2);
			NameOutput = Instantiate (NameOutput, Container2);
			LocationOutput = Instantiate (LocationOutput, Container2);
			badgesOutput = Instantiate (badgesOutput, Container2);

			//Will create a button (image + name) for every developer in the list in the left side
		   	button = Instantiate (button, Container);
			button.GetComponent<Element> ().Create (i);
			button.GetComponent<Button> ();
			button.onClick.AddListener (() => TaskOnClick(i));
		}
	}

	// Use this to display Developer Details in the right side
	public void TaskOnClick(Developer developer){
		imageOutput.sprite = developer.image;
		NameOutput.text = "Name: " + developer.Name;
		LocationOutput.text = "Location: " + developer.Location;
		badgesOutput.text = "Number of Badges: " + developer.badges.ToString();
	}
}
