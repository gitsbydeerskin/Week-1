using UnityEngine;

public class Step3 : MonoBehaviour
{
    string _playerName = "Gemma";
    int _level = 1;
    float _currentHealth = 75.00f;
    private float _maxHealth = 100.0f;
    bool _isAlive = true;

    float _healthPotion = 10;
    float _damage = 20;
    void Start()
    {
        Debug.Log(_playerName);
        Debug.Log(_level);
        Debug.Log(_isAlive);
        Debug.Log(_currentHealth / _maxHealth);

        _currentHealth = _currentHealth - _damage;
            // shorter way to write it is: _currentHealth -= _damage;
        Debug.Log(_currentHealth / _maxHealth);

        _currentHealth = _currentHealth + _healthPotion;
            // shorter way to write it is: _currentHealth += _healthPotion - damage;
        Debug.Log(_currentHealth / _maxHealth);
    }
}