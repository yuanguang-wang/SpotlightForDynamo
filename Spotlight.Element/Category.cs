using Dynamo.Graph.Nodes;
using ADDB = Autodesk.Revit.DB;

namespace Spotlight.Element
{
    public class Category
    {
        private Category() { }

        [NodeCategory("Query")]
        public static ADDB.Category GetCategory(ADDB.Document doc, ADDB.BuiltInCategory builtInCategory)
        {
            return ADDB.Category.GetCategory(doc, builtInCategory);
        }

        [NodeCategory("Query")]
        public static ADDB.Category GetCategory(ADDB.Document doc, ADDB.ElementId elementId)
        {
            return ADDB.Category.GetCategory(doc, elementId);
        }

        [NodeCategory("Query")]
        public static ADDB.GraphicsStyle GetGraphicStyle(ADDB.Category category, ADDB.GraphicsStyleType graphicsStyleType)
        {
            return category.GetGraphicsStyle(graphicsStyleType);
        }

        [NodeCategory("Query")]
        public static ADDB.ElementId GetLinePatternId(ADDB.Category category, ADDB.GraphicsStyleType graphicsStyleType)
        {
            return category.GetLinePatternId(graphicsStyleType);
        }

        [NodeCategory("Query")]
        public static int? GetLineWeight(ADDB.Category category, ADDB.GraphicsStyleType graphicsStyleType)
        {
            return category.GetLineWeight(graphicsStyleType);
        }

        [NodeCategory("Actions")]
        public static void SetLinePatternId(ADDB.Category category, ADDB.GraphicsStyleType graphicsStyleType, ADDB.ElementId linePatternId)
        {
            category.SetLinePatternId(linePatternId, graphicsStyleType);
        }

        [NodeCategory("Actions")]
        public static void SetLineWeight(ADDB.Category category, ADDB.GraphicsStyleType graphicsStyleType, int lineWeight)
        {
            category.SetLineWeight(lineWeight, graphicsStyleType);
        }

        [NodeCategory("Query")]
        public static ADDB.CategoryType GetCategoryType(ADDB.Category category)
        {
            return category.CategoryType;
        }

        [NodeCategory("Query")]
        public static ADDB.ElementId GetElementId(ADDB.Category category)
        {
            return category.Id;
        }

        [NodeCategory("Query")]
        public static ADDB.Color GetLineColor(ADDB.Category category)
        {
            return category.LineColor;
        }

        [NodeCategory("Actions")]
        public static void SetLineColor(ADDB.Category category, ADDB.Color color)
        {
            category.LineColor = color;
        }

        [NodeCategory("Query")]
        public static string GetCategoryName(ADDB.Category category)
        {
            return category.Name;
        }

        [NodeCategory("Query")]
        public static ADDB.Category GetParentCategory(ADDB.Category category)
        {
            return category.Parent;
        }

        [NodeCategory("Query")]
        public static ADDB.CategoryNameMap GetSubCategories(ADDB.Category category)
        {
            return category.SubCategories;
        }

        [NodeCategory("Query")]
        public static ADDB.Material GetCategoryMaterial(ADDB.Category category)
        {
            return category.Material;
        }

        [NodeCategory("Create")]
        public static ADDB.Category AddSubCategory(ADDB.Document doc, ADDB.Category parentCategory, string name)
        {
            ADDB.Categories categories = doc.Settings.Categories;
            return categories.NewSubcategory(parentCategory, name);
        }

        [NodeCategory("Actions")]
        public static void RemoveCategory(ADDB.Document doc, string name)
        {
            ADDB.Categories categories = doc.Settings.Categories;
            categories.Erase(name);
        }
    }
}