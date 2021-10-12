using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamManagement : MonoBehaviour {


    public List<GameObject> heroTeam = new List<GameObject>();
    public bool isActive;

    public enum teamState
    {
        OVERWORLD,
        MENUS,
        BATTLE,
        CUTSCENE
    }



	// Use this for initialization
	void Start ()
    {
        heroTeam.AddRange(GameObject.FindGameObjectsWithTag("Hero"));

        //initializing hero order in hero state machines
        for(int i = 0; i < heroTeam.Count - 1; i++)
        {
            heroTeam[i].GetComponent<HeroStateMachine>().hero.teamOrderNumber = i;
        }

	}
	
	// Update is called once per frame
	void Update () {
		if(heroTeam[0-2])
        {

        }
	}

    public void SwitchTeamOrder(int activeHero, int inactiveHero)
    {
        //get the number of the active hero looking to switch and the inactive hero looking to switch in
        //switch
        int temp = activeHero;
        heroTeam[temp] = heroTeam[inactiveHero];
        heroTeam[inactiveHero] = heroTeam[activeHero];
        Debug.Log(heroTeam);
    }
      
}
