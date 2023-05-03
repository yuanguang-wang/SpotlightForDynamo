SpotlightForDynamo is a dynamo plugin which visualizes major and fundamental REVITAPI methods on dynamo canvas.

## Intro
Native dynamo nodes are powerful when it comes to generative design,
but insufficient when it comes to the CRUD of revit database.
What this plugin/nodes builds is literally rearrange and refactor the code into dynamo format so it could be recognized and visualized as a dynamo node.
<br/>
For instance, the API method which is widely used ```element.LookupParameter(string paramName)``` is visualized as a node **Element.LookupParameter** with
input ```Element```(in namespace Revit.Elements in assembly RevitNodes) and ```string```.
Specifically for this example, the code behind the node is:
```
    [NodeCategory("Query")]
    public static ADDB.Parameter LookupParameter(DYDB.Element dynamoElement, string parameterName)
    {
        ADDB.Element element = dynamoElement.InternalElement;
        return element.LookupParameter(parameterName);
    }
```
No sophisticated logic and code context, just class type conversion, but improve efficiency when the "original" ```LookupParameter()``` need to be used on dynamo platform.
<br/>

## Category
- About
  - Abbreviations(under construction)
- Cast
  - Sub Element => Element
  - Sub ElementFilter => ElementFilter
- Element
  - CurtainGrid
  - Element(in dynamo Database)
  - Element(in autodesk revit Database)
  - ElementId
  - Level
  - Location
  - Parameter
  - Wall
  - XYZ
- ElementType
  - WallType
- Revit
  - BuiltInEnumerations
    - BuiltInParameter
    - BuiltInCategory
    - CurveElementType
    - WallFunction
    - WallKind
  - Document
  - .NET System
- Selection
  - ElementFilter
  - FilteredElementCollector
  - FilterRule
  - ParameterFilterRule
  - RuleType

## Under Construction
- Geometry Element
- Family
- Definition
- ForgeType
- Category