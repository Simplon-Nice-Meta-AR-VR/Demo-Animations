using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform _playerTransform;
    [SerializeField] private float _speed;

    [SerializeField] private Animator _animator;

    private Vector3 _direction;

    void Update()
    {
        _playerTransform.position += _direction * _speed * Time.deltaTime;
    }

    public void Move(Vector2 direction)
    {
        _direction = new Vector3(direction.x, 0, direction.y);
        _animator.SetFloat("Speed", _direction.sqrMagnitude);

        if (_direction != Vector3.zero)
            _playerTransform.forward = _direction;
    }
}
