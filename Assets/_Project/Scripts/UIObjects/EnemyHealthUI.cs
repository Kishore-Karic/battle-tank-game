﻿using UnityEngine;
using UnityEngine.UI;

namespace BattleTank.UI
{
    public class EnemyHealthUI : MonoBehaviour
    {
        [SerializeField] private Image backgroundImage;
        [SerializeField] private Image foregroundImage;
        [SerializeField] private Slider healthBar;
        [SerializeField] private int fullValue;
        [SerializeField] private float defaultXAxis;
        private Transform playerTransform;

        private void Start()
        {
            healthBar.value = fullValue;
        }

        private void Update()
        {
            transform.LookAt(playerTransform);
            transform.rotation = Quaternion.Euler(new Vector3(defaultXAxis, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z));
        }

        public void SetUIColor(Color _bgColor, Color _fgColor)
        {
            backgroundImage.color = _bgColor;
            foregroundImage.color = _fgColor;
        }

        public void SetHealthBarUI(float _value)
        {
            healthBar.value = _value;
        }

        public void SetPlayerTransform(Transform transform)
        {
            playerTransform = transform;
        }
    }
}