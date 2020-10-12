using UnityEngine;
using UnityEngine.SceneManagement; 

public class GreenBird : MonoBehaviour
{
	private Vector3 _initialPosition;
	[SerializeField] private float _launchPower = 500; 
	private void Awake()
	{
		_initialPosition = transform.position;
	}

	private void Update()
	{
		if (transform.position.y > 4.24)
		{
			string currentSceneName = SceneManager.GetActiveScene().name;
			SceneManager.LoadScene(currentSceneName);
		}
		
		if (transform.position.y < -4.24)
		{
			string currentSceneName = SceneManager.GetActiveScene().name;
			SceneManager.LoadScene(currentSceneName);
		}
		
		if (transform.position.x > 8.89)
		{
			string currentSceneName = SceneManager.GetActiveScene().name;
			SceneManager.LoadScene(currentSceneName);
		}
		
		if (transform.position.x < -8.96)
		{
			string currentSceneName = SceneManager.GetActiveScene().name;
			SceneManager.LoadScene(currentSceneName);
		}
	}

	private void OnMouseDown()
	{
		GetComponent<SpriteRenderer>().color = Color.red;
	}

	private void OnMouseUp()
	{
		GetComponent<SpriteRenderer>().color = Color.white;
		Vector2 directionToInitialPosition = _initialPosition - transform.position;
		GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * _launchPower);
		GetComponent<Rigidbody2D>().gravityScale = 1;
	}

	private void OnMouseDrag()
	{
		Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector3(newPosition.x, newPosition.y);
	}
}
