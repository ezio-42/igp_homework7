using System;
using UnityEngine;
using UnityEngine.UI;

public class BallView : MonoBehaviour {
    [SerializeField] private Text _healthText;
    
    private void OnCollisionEnter(Collision collision) {
        if (!collision.collider.CompareTag("Collider")) return;
        CollidedWithBox?.Invoke();
    }

    public void SetHealthText(string health) => _healthText.text = health;

    public event Action CollidedWithBox; 
}