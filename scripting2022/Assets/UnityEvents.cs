using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NewBehaviourScript : MonoBehaviour
{
	public UnityEvent awakeEvent, startEvent, onEnableEvent;
	public float holdTime;

	private void Awake()
	{
		awakeEvent.Invoke();
	} 
	
	// Start is called before the first frame update
	private IEnumerator Start()
    {
        yield return new WaitForSeconds(holdTime);
		startEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	private void onEnable()
	{
		onEnable.Invoke();
	}
}