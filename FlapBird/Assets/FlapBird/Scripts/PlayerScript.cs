using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
	public bool dead;
	public AudioClip[] auClip;
	public GameObject fire;

	public CameraAspect maincamera;

	void Start()
	{
		dead = false;
		GetComponent<AudioSource>().clip = auClip[0];
		maincamera = FindObjectOfType<CameraAspect>();
		GetComponent<AudioSource>().volume = maincamera.GetComponent<AudioSource>().volume;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space) && !dead && Time.timeScale > 0)
		{
			Jump();
		}
	}

	void Jump()
	{
		fire.SetActive (true);
		GetComponent<AudioSource>().Play();
		GetComponent<Rigidbody2D>().velocity = Vector2.zero;
		GetComponent<Rigidbody2D>().AddForce(Vector2.up * 200);
	}

	void OnTriggerEnter2D(Collider2D col) 
	{
		if (!dead)
		{
			if (col.tag == "Score")
			{
				GameObject.FindObjectOfType<GameManager>().Score++;
				Destroy(col.gameObject);
			}
			else if (col.tag == "Finish")
			{
				dead = true;
				this.transform.Rotate(180, 0, 0);
				GetComponent<AudioSource>().clip = auClip[1];
				GetComponent<AudioSource>().Play();
				Invoke("BackToMain", 1.5f);
			}
		}
	}

	void BackToMain()
	{
        SceneManager.LoadScene("MainMenu");
	}
}
