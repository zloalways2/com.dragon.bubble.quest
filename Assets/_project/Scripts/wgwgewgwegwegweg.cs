using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace _project.Scripts
{
    [CreateAssetMenu(fileName = "Levels", menuName = "Game/Levels", order = 0)]
    public sealed class wgwgewgwegwegweg : ScriptableObject
    {
       [FormerlySerializedAs("levels")] [SerializeField] private List<ewgwegwegewgw> rocketLevels = new List<ewgwegwegewgw>();

        public IReadOnlyList<ewgwegwegewgw> GameRocketLevels => rocketLevels;
    }
}