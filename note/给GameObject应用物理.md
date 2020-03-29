# 给 GameObject 应用物理

若要使用物理，需要有刚体组件（ Rigidbody ）。

刚体组件（ Rigidbody ）将使物体受到重力。

---

## 发生碰撞

发生碰撞的条件是两个物体都有某个 Collider 组件，并且至少有一个物体有 Ridigbody 。

## Trigger

如果物体的 Collider 组件勾选了 IsTrigger ，那么就不会再发生碰撞，而是会触发一些 OnTrigger 事件。

当有一个 Rigidbody 和 Collider 的物体移动到 Trigger 物体上，就会触发这些事件。

## 添加 Rigidbody 组件

选中物体，在 Inspector 面板里点击 Add Component -> Rigidbody

如果一个物体没有 Rigidbody 组件而只有 Collider 组件，那么这个物体就是静态物体，会被放于一个缓存中。

如果静态物体又会旋转、移动，那么 unity 就需要重新计算缓存，这会消耗性能。不如将其变成一个动态物体，即加了 Rigidbody 组件的物体。

如果不想让 Rigidbody 受到力的作用而只受到脚本的控制，那么勾选 Is Kinematic 属性。