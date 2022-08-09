using UnityEngine;
using SWZ.Ignition.SpriteSystem;
using SWZ.Ignition.VisualEffects;

namespace SWZArtPack02
{
    public class PlayerBase : MonoBehaviour
    {
        //public float speed = 4;

        public BulletSpawnerBase frontCannon;
        public BulletSpawnerBase phaser;
        public LaserSpawner laser;

        public GameObject shield;

        public SpriteRenderer spriteRenderer;

        public void AddShield()
        {
            if (_shield == null && shield)
            {
                _shield = Instantiate(shield);
                _shield.transform.SetParent(gameObject.transform, false);
            }
        }

        void Awake()
        {
            if (spriteRenderer == null) spriteRenderer = GetComponent<SpriteRenderer>();
        }

        GameObject _shield;
    }
}