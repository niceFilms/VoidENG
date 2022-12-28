using UnityEngine;
using UnityEngine.UI;

public class xfill : MonoBehaviour {
	public RectTransform rectTransform;
	// Start is called before the first frame update
	void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		// Set the UI element's scale so that it maintains its aspect ratio
		rectTransform.localScale = new UnityEngine.Vector3(Screen.width/400, Screen.width/400, 1);
	}
}
