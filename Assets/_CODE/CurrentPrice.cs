using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CurrentPrice : MonoBehaviour {

    [Header("Prices")]
    public float currentPrice = 15000;
    public float lowestPrice = 13000;
    public Text priceText;
    
	void Start ()
    {
        priceText = GetComponent<Text>() as Text;
    }
	
	// Update is called once per frame
	void Update ()
    {
        currentPrice -= Time.deltaTime;
        priceText.text = "Current Price: " + (int)currentPrice;
	
	}
}
