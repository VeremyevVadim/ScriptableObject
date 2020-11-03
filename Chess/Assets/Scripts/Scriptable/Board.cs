using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(menuName = "Chess/Board", order = 0)]
    public class Board : ScriptableObject
    {
        [SerializeField] private int height = 8;
        [SerializeField] private int width = 8;
        [SerializeField] private BaseArrangment arrangment = null;
        public int Height => height;

        public int Width => width;

        public BaseArrangment Arrangment => arrangment;
    }
}