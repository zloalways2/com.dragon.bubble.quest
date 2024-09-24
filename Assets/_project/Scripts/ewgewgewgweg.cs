using UnityEngine;
using UnityEngine.UI;

namespace _project.Scripts
{
    public class ewgewgewgweg : MonoBehaviour
    {
        public TileColor egwegwgwgewgwe { get; private set; }
        public int egwegwegwe { get; set; }
        public int gfngngngntrtnr { get; set; }
        public RectTransform nrbfvfsdc { get; private set; }
        private Image nfhbgvfdssfregtr;

        private void Awake()
        {
            nrbfvfsdc = GetComponent<RectTransform>();
            nfhbgvfdssfregtr = GetComponent<Image>();
        }

        public void Initialize(TileColor color, int x, int y, Sprite sprite)
        {
            egwegwgwgewgwe = color;
            egwegwegwe = x;
            gfngngngntrtnr = y;
            nfhbgvfdssfregtr.sprite = sprite;
        }
    }
}