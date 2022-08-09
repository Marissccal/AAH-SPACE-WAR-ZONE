using UnityEngine;
using SWZ.Ignition.ParticleSystem;

namespace SWZArtPack02
{
    public class RocketSmoke : MonoBehaviour
    {
        public string emitterGroupId;
        public float emitterGroupSize = 1;
        public int orderInLayer;

        void Update()
        {
            EmitterGroup.Play(emitterGroupId, transform.position, emitterGroupSize, orderInLayer);
        }
    }
}