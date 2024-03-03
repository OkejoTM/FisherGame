using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HookColliderController : MonoBehaviour
{
    public Transform hook;
    public Transform hookScale;
    public GameObject nemoFishOnHook;
    public GameObject angelicFishOnHook;
    public GameObject platyFishOnHook;
    public GameObject bullheadFishOnHook;


    private GameObject caughtFish;
    private bool fishIsCaught;    
    
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
        if (fish.GetComponent<NemoFish>() != null) caughtFish = nemoFishOnHook;
        if (fish.GetComponent<AngelicFish>() != null) caughtFish = angelicFishOnHook;       
        if (fish.GetComponent<PlatyFish>() != null) caughtFish = platyFishOnHook;
        if (fish.GetComponent<BullHeadFish>() != null) caughtFish = bullheadFishOnHook;
    }

}
