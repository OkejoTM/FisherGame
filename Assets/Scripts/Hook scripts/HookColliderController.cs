using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HookColliderController : MonoBehaviour
{
    public Transform hook;
    public Transform hookScale;
    public GameObject nemoFishOnHook; //3
    public GameObject angelicFishOnHook; // 2
    public GameObject platyFishOnHook; //4 
    public GameObject bullheadFishOnHook; // 1
    public TMP_Text score;
    private int scoreInt;

    private GameObject caughtFish;
    private bool fishIsCaught;

    private int fishScore;
    
    // Start is called before the first frame update
    void Start()
    {
        
    } 

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = hook.position;
        if (hookScale.transform.localScale.y < 0.18f && fishIsCaught)
        {
            fishIsCaught = false;
            caughtFish.SetActive(false);
            addScore();
        }
    }

    public void catchFish(GameObject fish)
    {
        if (!fishIsCaught)
        {
            selectFish(fish);
            caughtFish.SetActive(true);
            fishIsCaught = true;
            Destroy(fish);
        }
    }

    public void selectFish(GameObject fish)
    {
        if (fish.GetComponent<NemoFish>() != null)
        { 
            caughtFish = nemoFishOnHook;
            fishScore = 3;
        }
        if (fish.GetComponent<AngelicFish>() != null)
        { 
            caughtFish = angelicFishOnHook;
			fishScore = 2;
		}
        if (fish.GetComponent<PlatyFish>() != null) 
        { 
            caughtFish = platyFishOnHook;
			fishScore = 4;
		}
        if (fish.GetComponent<BullHeadFish>() != null)
        { 
            caughtFish = bullheadFishOnHook;
			fishScore = 1;
		}
    }

    private void addScore()
    {
        scoreInt += fishScore;
        score.text = "Очки: " + scoreInt;
    }
}
