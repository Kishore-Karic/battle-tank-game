﻿using BattleTank.Enum;
using BattleTank.TankSO;
using UnityEngine;

namespace BattleTank.Tank
{
    public class TankModel
    {
        public TankType TankType { get; private set; }
        public BulletType BulletType { get; private set; }
        public float Health { get; private set; }
        private float currentHealth;
        public float MovementSpeed { get; private set; }
        public float RotationSpeed { get; private set; }
        public float FireRate { get; private set; }
        public float TankDestroyTime { get; private set; }
        public Material Material { get; private set; }

        public TankModel(TankScriptableObject tankScriptableObject)
        {
            TankType = tankScriptableObject.TankType;
            BulletType = tankScriptableObject.BulletType;
            Health = tankScriptableObject.Health;
            currentHealth = Health;
            MovementSpeed = tankScriptableObject.MovementSpeed;
            RotationSpeed = tankScriptableObject.RotationSpeed;
            FireRate = tankScriptableObject.FireRate;
            TankDestroyTime = tankScriptableObject.TankDestroyTime;
            Material = tankScriptableObject.Material;
        }

        public float GetCurrentHealth()
        {
            return currentHealth;
        }

        public void SetCurrentHealth(float _currHealth)
        {
            currentHealth = _currHealth;
        }
    }
}