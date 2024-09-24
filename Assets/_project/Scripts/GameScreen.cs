using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Cysharp.Threading.Tasks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using ZeroSDK.UIBuilder.AddOns.Button;
using ZeroSDK.UIBuilder.Core.UIElements;
using Random = UnityEngine.Random;

namespace _project.Scripts
{
    public sealed class GameScreen : thygtfrdsd
    {
        [SerializeField] private rewgrehtrn exitButton;
        [SerializeField] private rewgrehtrn settingsButton;
        [SerializeField] private kiujyhtgrfedw gameView;
        [SerializeField] private kiujyhtgrfedw winView;
        [SerializeField] private kiujyhtgrfedw loseView;
        [SerializeField] private TextMeshProUGUI scoreText;
        [SerializeField] private TextMeshProUGUI levelText;
        [SerializeField] private TextMeshProUGUI winScoreText;
        [SerializeField] private TextMeshProUGUI timeText;
        [SerializeField] private rewgrehtrn nextButton;
        [SerializeField] private rewgrehtrn repeatButton;

        public Vector2 offset;
        public int width = 7;
        public int height = 8;
        public GameObject tilePrefab;
        public Sprite[] tileSprites;
        public RectTransform gameArea;
        public float moveSpeed = 10f;

        private ewgewgewgweg[,] tiles;
        private int nrnrtntrn;
        private float rherherherher;
        private int ewgwegwegew;
        private Vector2 ewfwefwefwefwef;
        private Vector2 fwfwfwefwefwf;

        private CancellationTokenSource nhnhnhn;
        private ewgwegwegewgw nerbebreb;

        public event Action klfwejglwekjgweg
        {
            add => exitButton.wgwegwegweg += value;
            remove => exitButton.wgwegwegweg += value;
        }

        public event Action ergerlgkjerger
        {
            add => settingsButton.wgwegwegweg += value;
            remove => settingsButton.wgwegwegweg += value;
        }

        public event Action ewgewgeherhnr
        {
            add => nextButton.wgwegwegweg += value;
            remove => nextButton.wgwegwegweg += value;
        }

        public event Action grpokergkoer
        {
            add => repeatButton.wgwegwegweg += value;
            remove => repeatButton.wgwegwegweg += value;
        }


        public event Action<ewgwegwegewgw> OnLevelCompleteEvent;


        public void gnentenernreb(ewgwegwegewgw data)
        {
            nhnhnhn?.Cancel();
            nhnhnhn = new CancellationTokenSource();

            winView.erberberber();
            loseView.erberberber();
            gameView.egwegwegebrberberb();

            levelText.text = $"LEVEL {data.Id}";

            while (gameArea.transform.childCount > 0)
                DestroyImmediate(gameArea.transform.GetChild(0).gameObject);

            nerbebreb = data;
            nrnrtntrn = 0;
            scoreText.text = "SCORE: 0";
            rherherherher = data.LevelTime;
            ewgwegwegew = data.Difficulty;

            tiles = new ewgewgewgweg[width, height];
            ngrgnrtnrntr();
            wrwhrherberbreber();
            ewfewwefwefwef();

            StartCoroutine(ewgwegwegwegewgewgewgew());
        }

        private void ngrgnrtnrntr()
        {
            RectTransform tileRect = tilePrefab.GetComponent<RectTransform>();
            ewfwefwefwefwef = new Vector2(tileRect.rect.width, tileRect.rect.height);
        }

        private void wrwhrherberbreber()
        {
            float ewfewgwegweg = width * ewfwefwefwefwef.x;
            float ngrntrntrntrn = height * ewfwefwefwefwef.y;
            fwfwfwefwefwf = new Vector2(
                (gameArea.rect.width - ewfewgwegweg) / 2,
                (gameArea.rect.height + ngrntrntrntrn) / 2
            ) + offset;
        }

        private void ewfewwefwefwef()
        {
            List<TileColor> nfgnfgngfnfgn = new List<TileColor>(System.Enum.GetValues(typeof(TileColor)).Cast<TileColor>());
            int nrrtnrtntrnt = Mathf.Max(1, 10 - ewgwegwegew);

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (tiles[x, y] == null)
                    {
                        TileColor color = nfgnfgngfnfgn[Random.Range(0, 10)];
                        eewfwefwefewfewfwefweg(x, y, color, nrrtnrtntrnt);
                    }
                }
            }
        }

        private void eewfwefwefewfewfwefweg(int ewgwgewgew, int ewfewfewfewf, TileColor efwefwefwefewf, int efwefewfw)
        {
            Queue<Vector2Int> efwefw = new Queue<Vector2Int>();
            efwefw.Enqueue(new Vector2Int(ewgwgewgew, ewfewfewfewf));
            int efwefwef = 0;

            while (efwefw.Count > 0 && efwefwef < efwefewfw)
            {
                Vector2Int ewfwefwe = efwefw.Dequeue();
                if (ewfwefwe.x < 0 || ewfwefwe.x >= width || ewfwefwe.y < 0 || ewfwefwe.y >= height || tiles[ewfwefwe.x, ewfwefwe.y] != null)
                    continue;

                eerheerberbebre(ewfwefwe.x, ewfwefwe.y, efwefwefwefewf);
                efwefwef++;

                if (efwefwef < efwefewfw)
                {
                    efwefw.Enqueue(new Vector2Int(ewfwefwe.x + 1, ewfwefwe.y));
                    efwefw.Enqueue(new Vector2Int(ewfwefwe.x - 1, ewfwefwe.y));
                    efwefw.Enqueue(new Vector2Int(ewfwefwe.x, ewfwefwe.y + 1));
                    efwefw.Enqueue(new Vector2Int(ewfwefwe.x, ewfwefwe.y - 1));
                }
            }
        }

        private void eerheerberbebre(int x, int y, TileColor color)
        {
            GameObject wfwefw = Instantiate(tilePrefab, gameArea);
            RectTransform egwfwfwefw = wfwefw.GetComponent<RectTransform>();
            egwfwfwefw.anchoredPosition = rebrebreberb(x, y);

            ewgewgewgweg ewfwef = wfwefw.GetComponent<ewgewgewgweg>();
            ewfwef.Initialize(color, x, y, tileSprites[(int) color]);

            tiles[x, y] = ewfwef;

            Button button = wfwefw.GetComponent<Button>();
            button.onClick.AddListener(() => efwefwefwefwef(ewfwef));
        }

        private Vector2 rebrebreberb(int x, int y)
        {
            return new Vector2(
                fwfwfwefwefwf.x + x * ewfwefwefwefwef.x,
                fwfwfwefwefwf.y - y * ewfwefwefwefwef.y
            );
        }

        private void efwefwefwefwef(ewgewgewgweg tile)
        {
            if (tiles[tile.egwegwegwe, tile.gfngngngntrtnr] == null)
            {
                return;
            }

            List<ewgewgewgweg> ewgwgwegwegewg = efwewfwefwefw(tile.egwegwegwe, tile.gfngngngntrtnr);

            if (ewgwgwegwegewg.Count > 1 || nnrntrnergewgewg() == 1)
            {
                nrnrtntrn += ewgwgwegwegewg.Count * 10;
                scoreText.text = $"SCORE: {nrnrtntrn}";

                efwefwefwef(ewgwgwegwegewg);
                StartCoroutine(erehererherherh());
                efwefwfewfwefwe();
            }
        }

        private List<ewgewgewgweg> efwewfwefwefw(int x, int y)
        {
            TileColor wffwefwef = tiles[x, y].egwegwgwgewgwe;
            List<ewgewgewgweg> nrntrntrn = new List<ewgewgewgweg>();
            HashSet<ewgewgewgweg> efwefwef = new HashSet<ewgewgewgweg>();

            void wefwfwefwefew(int cx, int cy)
            {
                if (cx < 0 || cx >= width || cy < 0 || cy >= height) return;

                ewgewgewgweg ewfwef = tiles[cx, cy];
                if (ewfwef == null || efwefwef.Contains(ewfwef) || ewfwef.egwegwgwgewgwe != wffwefwef) return;

                efwefwef.Add(ewfwef);
                nrntrntrn.Add(ewfwef);

                wefwfwefwefew(cx + 1, cy);
                wefwfwefwefew(cx - 1, cy);
                wefwfwefwefew(cx, cy + 1);
                wefwfwefwefew(cx, cy - 1);
            }

            wefwfwefwefew(x, y);
            return nrntrntrn;
        }

        private void efwefwefwef(List<ewgewgewgweg> tilesToRemove)
        {
            foreach (ewgewgewgweg tile in tilesToRemove)
            {
                if (tile != null)
                {
                    int x = tile.egwegwegwe;
                    int y = tile.gfngngngntrtnr;
                    Destroy(tile.gameObject);
                    tiles[x, y] = null;
                }
            }
        }

        private IEnumerator erehererherherh()
        {
            List<ewgewgewgweg> rhreherherh = new List<ewgewgewgweg>();
            Dictionary<ewgewgewgweg, Vector2> fwefwefwefwefewf = new Dictionary<ewgewgewgweg, Vector2>();

            // Apply gravity by shifting tiles down
            for (int x = 0; x < width; x++)
            {
                int wfwef = height - 1;
                for (int readIndex = height - 1; readIndex >= 0; readIndex--)
                {
                    if (tiles[x, readIndex] != null)
                    {
                        if (wfwef != readIndex)
                        {
                            tiles[x, wfwef] = tiles[x, readIndex];
                            tiles[x, wfwef].gfngngngntrtnr = wfwef;
                            rhreherherh.Add(tiles[x, wfwef]);
                            fwefwefwefwefewf[tiles[x, wfwef]] = rebrebreberb(x, wfwef);
                            tiles[x, readIndex] = null;
                        }

                        wfwef--;
                    }
                }
            }

            // Shift entire columns if they are empty
            int wefwefwefwef = -1;
            for (int x = 0; x < width; x++)
            {
                if (nenernernernehr(x))
                {
                    if (wefwefwefwef == -1)
                        wefwefwefwef = x;
                }
                else if (wefwefwefwef != -1)
                {
                    for (int y = 0; y < height; y++)
                    {
                        if (tiles[x, y] != null)
                        {
                            tiles[wefwefwefwef, y] = tiles[x, y];
                            tiles[wefwefwefwef, y].egwegwegwe = wefwefwefwef;
                            rhreherherh.Add(tiles[wefwefwefwef, y]);
                            fwefwefwefwefewf[tiles[wefwefwefwef, y]] = rebrebreberb(wefwefwefwef, y);
                            tiles[x, y] = null;
                        }
                    }

                    wefwefwefwef++;
                }
            }

            // Move all tiles simultaneously to their target positions
            float ewfwefwefewf = Time.time;
            bool stillMoving = true;

            while (stillMoving)
            {
                stillMoving = false;
                float t = (Time.time - ewfwefwefewf) * moveSpeed;

                foreach (ewgewgewgweg tile in rhreherherh)
                {
                    if (tile != null && tile.nrbfvfsdc != null)
                    {
                        Vector2 startPos = tile.nrbfvfsdc.anchoredPosition;
                        Vector2 endPos = fwefwefwefwefewf[tile];
                        tile.nrbfvfsdc.anchoredPosition = Vector2.Lerp(startPos, endPos, t);

                        if ((tile.nrbfvfsdc.anchoredPosition - endPos).sqrMagnitude > 0.01f)
                        {
                            stillMoving = true;
                        }
                    }
                }

                yield return null;
            }

            // Ensure final positions are exact
            foreach (ewgewgewgweg tile in rhreherherh)
            {
                if (tile != null && tile.nrbfvfsdc != null)
                {
                    tile.nrbfvfsdc.anchoredPosition = fwefwefwefwefewf[tile];
                }
            }

            // Update the tiles array to reflect the new positions
            wgererherherherher();
        }

        private void wgererherherherher()
        {
            ewgewgewgweg[,] newTiles = new ewgewgewgweg[width, height];
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    if (tiles[x, y] != null)
                    {
                        newTiles[tiles[x, y].egwegwegwe, tiles[x, y].gfngngngntrtnr] = tiles[x, y];
                    }
                }
            }

            tiles = newTiles;
        }

        private bool nenernernernehr(int x)
        {
            for (int y = 0; y < height; y++)
            {
                if (tiles[x, y] != null)
                {
                    return false;
                }
            }

            return true;
        }

        private IEnumerator ewgwegwegwegewgewgewgew()
        {
            fwewgwegwegewg();

            while (rherherherher > 0 && nhnhnhn.IsCancellationRequested == false)
            {
                yield return new WaitForSeconds(1f);
                rherherherher--;
                fwewgwegwegewg();
            }

            efwefwfewfwefwe();
        }

        private void fwewgwegwegewg()
        {
            var m = (int) (rherherherher / 60f);
            var s = (int) (rherherherher - (m * 60));
            timeText.text = $"{m}:{s:00}";

            // Update UI with remaining time
        }

        private async void efwefwfewfwefwe()
        {
            var onlyOnes = true;

            var lastColor = TileColor.None;
            for (int x = 0; x < tiles.GetLength(0); x++)
            {
                for (int y = 0; y < tiles.GetLength(1); y++)
                {
                    if (tiles[x, y] == null)
                    {
                        lastColor = TileColor.None;
                        continue;
                    }

                    var currColor = tiles[x, y].egwegwgwgewgwe;

                    if (lastColor == currColor)
                    {
                        onlyOnes = false;
                        break;
                    }

                    lastColor = currColor;
                }

                if (onlyOnes == false)
                    break;
            }


            if (onlyOnes)
            {
                lastColor = TileColor.None;
                for (int x = 0; x < tiles.GetLength(1); x++)
                {
                    for (int y = 0; y < tiles.GetLength(0); y++)
                    {
                        if (tiles[y, x] == null)
                        {
                            lastColor = TileColor.None;
                            continue;
                        }

                        var currColor = tiles[y, x].egwegwgwgewgwe;

                        if (lastColor == currColor)
                        {
                            onlyOnes = false;
                            break;
                        }
                        
                        lastColor = currColor;
                    }
                    
                    if (onlyOnes == false)
                        break;
                }
            }


            if (onlyOnes || efwefwefewfwefwefwge())
            {
                if (nhnhnhn.IsCancellationRequested)
                    return;
                nhnhnhn.Cancel();

                OnLevelCompleteEvent?.Invoke(nerbebreb);
                await UniTask.WaitForSeconds(0.5f);
                winView.egwegwegebrberberb();
                gameView.erberberber();

                winScoreText.text = nrnrtntrn.ToString();
                return;
            }

            if (rherherherher > 0)
                return;

            if (nhnhnhn.IsCancellationRequested)
                return;
            nhnhnhn.Cancel();

            loseView.egwegwegebrberberb();
            gameView.erberberber();

            gameView.erberberber();
        }

        private bool efwefwefewfwefwefwge()
        {
            return tiles.Cast<ewgewgewgweg>().All(t => t == null);
        }

        private int nnrntrnergewgewg()
        {
            return tiles.Cast<ewgewgewgweg>().Count(t => t != null);
        }

        public void fwefewgwegweg()
        {
            nhnhnhn?.Cancel();
        }
    }

    public enum TileColor
    {
        Color1,
        Color2,
        Color3,
        Color4,
        Color5,
        Color6,
        Color7,
        Color8,
        Color9,
        Color10,
        None
    }
}