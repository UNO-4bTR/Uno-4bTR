using System;
using UnityEngine;

using System.Collections.Generic;
using UnityEditor.Experimental.SceneManagement;
using Color = Assets.Scripts.Cards.Colored.Color;
using Random = UnityEngine.Random;

namespace Assets.Scripts
{
    
    public class DrawCard : MonoBehaviour
    {

        public GameObject playerArea1;
        public GameObject playerArea2;

        readonly List<GameObject> _cards = new List<GameObject>();
    
        void Start()
        {
            string coloredNumberedPath = "Prefabs/Cards/Colored/Numbered";
            foreach (Color color in Enum.GetValues(typeof(Color)))
            {
                for (int i = 0; i <= 9; i++)
                {
                    string path = coloredNumberedPath + "/" + color + "_" + i;
                    GameObject card = Resources.Load<GameObject>(path);
                    if (card == null)
                    {
                        Debug.Log(path);
                        continue;
                    }
                    _cards.Add(card);
                }
            }
            
            if (_cards.Count == 0) return;
        
            for (int i = 0; i < 7; i++)
            {
                Instantiate(_cards[Random.Range(0, _cards.Count)], playerArea1.transform);
                Instantiate(_cards[Random.Range(0, _cards.Count)], playerArea2.transform);
            }
        }

    }
    
}
