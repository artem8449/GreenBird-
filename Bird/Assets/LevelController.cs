﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    private static int _nextLevelIndex = 1;
    private static int _maxLevelIndex = 3;
    private Enemy[] _enemies;

        private void OnEnable()
    {
        _enemies = FindObjectsOfType<Enemy>();
        
    }

    void Update()
    {
        foreach (Enemy enemy in _enemies)
        {
           if (enemy != null)
               return;
        }

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