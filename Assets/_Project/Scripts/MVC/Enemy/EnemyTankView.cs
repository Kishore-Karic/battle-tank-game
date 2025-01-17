using BattleTank.Enum;
using BattleTank.Interface;
using BattleTank.StateMachine.EnemyState;
using BattleTank.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace BattleTank.EnemyTank
{
    [RequireComponent(typeof(Rigidbody), typeof(NavMeshAgent))]
    public class EnemyTankView : MonoBehaviour, IDamageable
    {
        private EnemyTankController enemyTankController;
        [SerializeField] private List<MeshRenderer> tankRenderer;
        [SerializeField] private NavMeshAgent agent;
        [SerializeField] private Transform bulletSpawnPoint;
        [SerializeField] private EnemyStateMachine enemyStateMachine;
        [SerializeField] private EnemyHealthUI enemyHealthUI;
        
        public void SetEnemyTankController(EnemyTankController _enemyTankController)
        {
            enemyTankController = _enemyTankController;
            enemyTankController.UpdateTankColor(tankRenderer);
        }

        public Transform GetBulletTransform()
        {
            return bulletSpawnPoint;
        }

        public NavMeshAgent GetNavMeshAgent()
        {
            return agent;
        }

        public EnemyStateMachine GetEnemyStateMachine()
        {
            return enemyStateMachine;
        }

        public void Damage(TankID shooter, float damage)
        {
            enemyTankController.TakeDamage(shooter, damage);
        }

        public TankID GetTankID()
        {
            return TankID.Enemy;
        }

        public EnemyHealthUI GetEnemyHealthUI()
        {
            return enemyHealthUI;
        }
    }
}