using System.Collections.Generic;
using UnityEngine;

namespace SimpleECS.Example
{
    public class GameManager : MonoBehaviour
    {
        private Entity player;
        private List<Entity> enemies;
        private World mainWorld;
        private void Start()
        {
            mainWorld = World.Create("Main");

            player = mainWorld.CreateEntity("Player",
                new PositionComponent(Vector3.zero),
                new RotationComponent(Quaternion.identity));
            
            enemies = new List<Entity>();
            for (int i = 0; i < 1000; i++)
            {
                enemies.Add(
                mainWorld.CreateEntity($"Enemy",
                    new PositionComponent(Vector3.forward * i),
                    new RotationComponent(Quaternion.Euler(new Vector3(0,180,0)))));
            }

            player.Set(new InputComponent(Vector2.zero));
            // enemyOne.Set(new InputComponent(Vector2.zero));
            // enemyTwo.Set(new InputComponent(Vector2.zero));
        }

        private void Update()
        {
            // Same like Singleton System, Only One
            var x = Input.GetAxis("Horizontal");
            var y = Input.GetAxis("Vertical");
            {
                ref var inputComponent = ref player.Get<InputComponent>();
                inputComponent.Value = new Vector2(x, y);
            }

            if (Input.GetKey(KeyCode.Return))
            {
                enemies.Add(
                    mainWorld.CreateEntity($"Enemy",
                        new PositionComponent(Vector3.forward),
                        new RotationComponent(Quaternion.Euler(new Vector3(0,180,0)))));
            }
            
            if (Input.GetKey(KeyCode.Space))
            {
                enemies[enemies.Count-1].Destroy();
                enemies.RemoveAt(enemies.Count-1);
            }
        }
    }

    public struct PositionComponent
    {
        public Vector3 position;

        public PositionComponent(Vector3 position)
        {
            this.position = position;
        }

        public override string ToString()
        {
            return position.ToString();
        }
    }

    public struct RotationComponent
    {
        public Quaternion rotation;

        public RotationComponent(Quaternion rotation)
        {
            this.rotation = rotation;
        }
        public override string ToString()
        {
            return rotation.ToString();
        }
    }

    public struct InputComponent
    {
        public Vector2 Value;

        public InputComponent(Vector2 value)
        {
            Value = value;
        }
        
        public override string ToString()
        {
            return Value.ToString();
        }
    }
}