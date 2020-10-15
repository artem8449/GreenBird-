using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public Text changeLevel;
    public GameObject greenBird;
    private Vector3 _birdPosition;
    private static int _nextLevelIndex = 1;
    private static int _maxLevelIndex = 3;
    private float _timeDelay = 2;
    private float _timeElapced;
    private Enemy[] _enemies;

        private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
        
    }

        private void Start()
        {
            changeLevel.text = "";
        }

        void Update()
        {
            _birdPosition = greenBird.transform.position;
            _birdPosition.y += _birdPosition.y + 5;
            changeLevel.transform.position = _birdPosition;
        foreach (Enemy enemy in _enemies)
        {
            if (enemy != null)
                return;
            
        }

        _timeElapced += Time.deltaTime;

        changeLevel.text = "Loading...";
       if (_timeElapced > _timeDelay)
       {

           if (_nextLevelIndex < _maxLevelIndex)
           {
               Debug.Log("You Killed all enemies");
               _nextLevelIndex++;
               string nextLevelName = "Level" + _nextLevelIndex;
               SceneManager.LoadScene(nextLevelName);
           }
           else
           {
               _nextLevelIndex = 1;
               string nextLevelName = "Level" + _nextLevelIndex;
               SceneManager.LoadScene(nextLevelName);
           }

       }
    }
    
    
}
