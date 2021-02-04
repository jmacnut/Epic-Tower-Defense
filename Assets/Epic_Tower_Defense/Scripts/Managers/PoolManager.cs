using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace ETD.Scripts.Managers
{
    public class PoolManager : MonoBehaviour
    {
        // data structures - Doc: Unity Collections and Data Structures
        //private List<GameObject> _enemyPoolList;    // Lists: can pull from middle

        // recommended
        private Queue<GameObject> _enemyPoolQueue;  // Queues: FIFO
        //private Stack<GameObject> _enemyPoolStack;  // Stacks: LIFO

        void Start()
        {
            //_enemyPoolList[0];           // first element in list
            //_enemyPoolList.Remove();     // remove item from list

            // generate list of enemies and populate the pool

            _enemyPoolQueue.Peek();      // view first element i queue
            _enemyPoolQueue.Enqueue();   // append to tail
            _enemyPoolQueue.Dequeue();   // remove from head
        
        }

        void Update()
        {

        }

        public GameObject RequestEnemy()
        {
            // find first enemy within the enemy pool
            // that is turned off and return it to the spawn manager
            // Note: for() loops are more optimal than foreach() loops
            //foreach (var enemy in _enemyPoolQueue)
            //{
            //    if (enemy.activeInHierarchy == false)
            //    {
            //        return enemy;
            //    }
            //}

            // more efficient to use LINQ query instead of foreach
            // returns bool, requires a predicate (delegate function)
            var enemy = _enemyPoolQueue.First(enemy => enemy.activeInHierarchy == false);

            // failsafe - create a new enemy
            var newEnemy = new GameObject("Enemy");
            _enemyPoolQueue.Enqueue(newEnemy);
            return newEnemy;
        }
    } 
}
