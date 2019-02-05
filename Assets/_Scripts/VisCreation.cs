using IATK;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class VisCreation : MonoBehaviour {

    // Use this for initialization
    private void Start()
    {
        GameObject dataSourceObj = new GameObject("[IATK] Index DS");
        CSVDataSource dataSource = dataSourceObj.AddComponent<CSVDataSource>();
        dataSource.data = Resources.Load("Datasets/dow_jones_index") as TextAsset;
        dataSource.load();

        GameObject visualisationObj = new GameObject("[IATK] Index Vis");
        Visualisation visualisation = visualisationObj.AddComponent<Visualisation>();

        visualisation.dataSource = dataSource;
        visualisation.xDimension = dataSource[2].Identifier;
        visualisation.yDimension = dataSource[1].Identifier;
        visualisation.zDimension = dataSource[0].Identifier;
        visualisation.sizeDimension = dataSource[5].Identifier;
        visualisation.geometry = AbstractVisualisation.GeometryType.Spheres;
        visualisation.CreateVisualisation(AbstractVisualisation.VisualisationTypes.SCATTERPLOT);
    }

    void Update () {
		
	}
}
