using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace _Example.Scripts
{
    public class LoadScene : MonoBehaviour
    {
        [SerializeField] private List<string> SceneNames;

        private void Start()
        {
            var index = 0;
            if (SceneNames.Count > 0)
            {
                var buttons = gameObject.GetComponentsInChildren<Button>();
                foreach (var button in buttons)
                {
                    string registerName = SceneNames[index];
                    button.GetComponentInChildren<Text>().text = registerName;
                    button.onClick.AddListener(() => OnClickedLoadScene(registerName));

                    index++;
                }
            }
        }

        private void OnClickedLoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
    }
}
