using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;


public class ShowAnalytics : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{


		Gender gender = Gender.Female;
		Analytics.SetUserGender (gender);

		int birthYear = 2000;
		Analytics.SetUserBirthYear (birthYear);

		LevelUp ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void LevelUp ()
	{
		Analytics.Transaction ("LevelUp", 1, "Euro", null, null); 


		Analytics.CustomEvent ("LevelUp", new Dictionary<string, object> {
			{ "newlevel", 2 },
			{ "trigger", "purchase" },
		});

	}
}
