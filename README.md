```mermaid
  graph LR;
      TurretShoot-->BulletInstantiate;
      BulletInstantiate-->MoveTowardsEnemy;
      MoveTowardsEnemy-->CollisionTakeDamage;
      CollisionTakeDamage-->Destroy*GameObject*;
```