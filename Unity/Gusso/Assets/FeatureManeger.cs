using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class FeatureManeger : MonoBehaviour
{
    public List<Feature> features;
    public int currFeature;

    private void OnEnable()
    {
        //LoadFeatures();
    }
    private void OnDisable()
    {
        //SaveFeatures();
    }
    void LoadFeatures()
    {
        //features = new List<Feature>();
        //features.Add(new Feature("body_2", transform.Find("body_2").GetComponent<SpriteRenderer>()));
        //features.Add(new Feature("face and bottom_6", transform.Find("body_2").Find("face and bottom_6").GetComponent<SpriteRenderer>()));
        //features.Add(new Feature("face and bottom_22 (1)", transform.Find("body_2").Find("face and bottom_22 (1)").GetComponent<SpriteRenderer>()));
        //features.Add(new Feature("face and bottom_20", transform.Find("body_2").Find("face and bottom_20").GetComponent<SpriteRenderer>()));
        //features.Add(new Feature("girl's clothes_4", transform.Find("body_2").Find("girl's clothes_4").GetComponent<SpriteRenderer>()));
        //features.Add(new Feature("face and bottom_4", transform.Find("body_2").Find("face and bottom_4").GetComponent<SpriteRenderer>()));
        //features.Add(new Feature("hair girl_7", transform.Find("body_2").Find("hair girl_7").GetComponent<SpriteRenderer>()));

    }
    void SaveFeatures()
    {

    }

    public void SetCurrent(int index)
    {
        if (features == null)
            return;

        currFeature = index;
    }  
    public void NestChoise()
    {
        if (features == null)
            return;
        features[currFeature].currIndex++;
    }
	public void PreviousChoice()
    {
        if (features == null)
            return;
        features[currFeature].currIndex--;
    }
}

[System.Serializable]
public class Feature
{
    public string ID;
    public int currIndex;
    public Sprite[] choices;
    public SpriteRenderer renderer;

    public Feature(string id, SpriteRenderer rend)
    {
        //ID = id;
        //renderer = rend;
        //UpdateFeature();
    }

    public void UpdateFeature()
    {
        //choices = Resources.LoadAll<Sprite>("Texture/" + ID);

        //if (choices == null || renderer == null)
        //    return;
        //if (currIndex < 0)
        //    currIndex = choices.Length - 1;
        //if (currIndex >= choices.Length)
        //    currIndex = 0;

        //renderer.sprite = choices[currIndex];
    }
}