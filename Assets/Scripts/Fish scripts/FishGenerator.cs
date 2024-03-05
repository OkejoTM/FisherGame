using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishGenerator : MonoBehaviour
{
    public GameObject nemoFishPrefab;
    public GameObject angelFishPrefab;
    public GameObject platyFishPrebaf;
    public GameObject bullheadFishPrebaf;
	public GameObject PufferFishPrefab;


	// Start is called before the first frame update
	void Start()
    {
        StartCoroutine(createFish()); 
    }

    // Update is called once per frame
    void Update()
    {
        

    }


    public IEnumerator createFish()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));

        GameObject fish = Instantiate(getRandomFish());
        bool rightFish = Random.Range(0, 2) == 1;

        float y = Random.Range(-14.59f, 4f);
        float x;

        if (rightFish)
        {
            x = 43f;
            fish.GetComponent<FishBehavior>().movement.x = -5f;
            fish.GetComponent<Transform>().Rotate(0f, 180f, 0f);
        }
        else
        {
            x = -30f;
            fish.GetComponent<FishBehavior>().movement.x = 5f;
        }

        fish.GetComponent<Transform>().position = new Vector3(x, y, 1);

        StartCoroutine(createFish());
    }

    public GameObject getRandomFish()
    {
        var chance = Random.Range(0, 5);
        switch (chance)
        {
            case 0:
                return nemoFishPrefab;                
            case 1:
                return angelFishPrefab;
            case 2:
                return platyFishPrebaf;
            case 3:
                return bullheadFishPrebaf;
			case 4:
				return PufferFishPrefab;
			default: 
                return null;
        }
    }

}
