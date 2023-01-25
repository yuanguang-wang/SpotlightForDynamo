// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using Dynamo.Controls;
using Dynamo.Graph.Nodes;
using Dynamo.ViewModels;
using Dynamo.Wpf;
using Newtonsoft.Json;

namespace Spotlight.About
{
    
    [NodeName("Abbreviation")]
    [NodeDescription("Sample Explicit Node")]
    [NodeCategory("Spotlight.About")]
    [IsDesignScriptCompatible]
    public class Abbreviation : NodeModel
    {
        //Json Constructor for Dynamo 2.0 nodes
        [JsonConstructor]
        private Abbreviation(IEnumerable<PortModel> inPorts, IEnumerable<PortModel> outPorts) : base(inPorts, outPorts) { }
        public Abbreviation() { }
    
    }
    
    public class AbbreviationView : INodeViewCustomization<Abbreviation>
    {
        private DynamoViewModel dynamoViewModel;
        private Abbreviation abbrNode;

        public void CustomizeView(Abbreviation model, NodeView nodeView)
        {
            dynamoViewModel = nodeView.ViewModel.DynamoViewModel;
            abbrNode = model;
            AbbreviationUI ui = new AbbreviationUI();
            nodeView.inputGrid.Children.Add(ui);
            ui.DataContext = model;
        }

        public void Dispose() { }
    }
}