﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.GameObject;

public class GreenBird : MonoBehaviour
{
	public Text changeLevel;
	private Enemy[] _enemies;
	private Vector3 _initialPosition;
	private bool _birdWasLaunch;
	private float _timeSittingAround;
	[SerializeField] private float _launchPower = 500;

	private void Awake()
	{
		_initialPosition = transform.position;
	}
	

	private void Update()
	{
		changeLevel.transform.SetAsLastSibling();
		GetComponent<LineRenderer>().SetPosition(0, transform.position);
		GetComponent<LineRenderer>().SetPosition(1, _initialPosition);
		
		if (_birdWasLaunch &&
		    GetComponent<Rigidbody2D>().velocity.magnitude <= 0.1)
		{
			_timeSittingAround += Time.deltaTime;
		}

		if (_timeSittingAround > 2)
		{
			changeLevel.text = "You lose. Restart";
		}


		if ((transform.position.y > 4.24 ||
		     transform.position.y < -4.5||
		     transform.position.x > 20||
		     transform.position.x < -20||
		     _timeSittingAround > 3||
		     (!_birdWasLaunch && transform.position.x > _initialPosition.x + 1)))
		{
			string currentSceneName = SceneManager.GetActiveScene().name;
			SceneManager.LoadScene(currentSceneName);
		}
		
	}

	private void OnMouseDown()
	{
		GetComponent<SpriteRenderer>().color = Color.red;
		GetComponent<LineRenderer>().enabled = true;
	}

	private void OnMouseUp()
	{
		GetComponent<SpriteRenderer>().color = Color.white;
		Vector2 directionToInitialPosition = _initialPosition - transform.position;
		GetComponent<Rigidbody2D>().AddForce(directionToInitialPosition * _launchPower);
		GetComponent<Rigidbody2D>().gravityScale = 1;
		_birdWasLaunch = true;
		GetComponent<LineRenderer>().enabled = false; ;
	}

	private void OnMouseDrag()
	{
		Vector3 newPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector3(newPosition.x, newPosition.y);
	}
}
