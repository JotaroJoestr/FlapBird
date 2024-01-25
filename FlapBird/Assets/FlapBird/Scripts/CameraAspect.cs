using Unity.VisualScripting;
using UnityEngine;


public class CameraAspect : MonoBehaviour 
{
	public GameObject[] gm;
    private void Awake()
    {
		int count = FindObjectsOfType<CameraAspect>().Length;

		if (count != 1)
		{
			Destroy(gameObject);
		}
		else if(count == 1)
		{
			DontDestroyOnLoad(gameObject);
		}
    }

    void Start ()
	{
		Camera.main.aspect = 16/10f;
		Screen.sleepTimeout = SleepTimeout.NeverSleep;
		Time.timeScale = 1;
	}
}
