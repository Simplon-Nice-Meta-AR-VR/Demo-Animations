using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerWaving _playerWaving;

    void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        _playerMovement.Move(direction);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _playerWaving.Wave();
        }
    }
}
