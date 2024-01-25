using UnityEngine;


public class ObjectMove : MonoBehaviour 
{
	public PlayerScript player;

    private void Start()
    {
		player = FindAnyObjectByType<PlayerScript>();
    }
    void FixedUpdate () 
	{
			if (player != null && player.dead == false)
			{
				transform.position = new Vector3(transform.position.x - 0.03f, transform.position.y, 0);

				if (transform.position.x <= -7.5f)
				{
					Destroy(gameObject);
				}
			}
	}
}
