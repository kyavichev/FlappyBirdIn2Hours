using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// This script glue a bunch of different things together
public class GameManager : MonoBehaviour
{
    // Link / reference to the hero prefab
    public GameObject heroPrefab;

    // Saved starting position
    private Vector3 heroSpawnPosition;

    // Reference to the camera follower
    public CameraFollower cameraFollower;

    // Reference to the current hero
    public GameObject hero;

    // Reference to the UI text elemenet that displays travelled distance
    public Text distanceText;

    // List of pipe pairs
    public List<PipePairController> pipePairs;

    private bool isGameActive = false;


    // Start is called before the first frame update
    void Start()
    {
        heroSpawnPosition = hero.transform.localPosition;

        foreach (PipePairController pipePair in pipePairs)
        {
            pipePair.trackedObject = hero;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if(hero == null)
        {
            hero = Instantiate(heroPrefab);
            hero.transform.localPosition = heroSpawnPosition;

            cameraFollower.trackedObject = hero;

            foreach(PipePairController pipePair in pipePairs)
            {
                pipePair.trackedObject = hero;
            }

            if(distanceText)
            {
                distanceText.text = "Distance: 0";
            }
        }
        else
        {
            if(distanceText != null)
            {
                int distance = Mathf.RoundToInt((hero.transform.localPosition.x - heroSpawnPosition.x) * 10f);
                distanceText.text = "Distance: " + distance;
            }
        }
    }


    public void OnStartButtonPressed()
    {
        Rigidbody2D heroBody = hero.GetComponent<Rigidbody2D>();
        heroBody.isKinematic = false;

        HeroMover heroMover = hero.GetComponent<HeroMover>();
        heroMover.StartMoving();
    }
}
