
using ADDB = Autodesk.Revit.DB;
using DYDB = Revit.Elements;


namespace Spotlight.Cast
{
    public class ElementCast
    {
        private ElementCast() { }

        ///////////////////////////////
        #region GetElementId Overloads

        public static ADDB.ElementId GetElementId(ADDB.Wall element)
        {
            return element.Id;
        }

        public static ADDB.ElementId GetElementId(ADDB.Mullion element)
        {
            return element.Id;
        }
        
        public static ADDB.ElementId GetElementId(ADDB.Analysis.PathOfTravel element)
        {
            return element.Id;
        }
               
        public static ADDB.ElementId GetElementId(ADDB.Architecture.Railing element)
        {
            return element.Id;
        } 
                      
        public static ADDB.ElementId GetElementId(ADDB.Architecture.Stairs element)
        {
            return element.Id;
        }  
                      
        public static ADDB.ElementId GetElementId(ADDB.Architecture.StairsLanding element)
        {
            return element.Id;
        }
                             
        public static ADDB.ElementId GetElementId(ADDB.Architecture.StairsPath element)
        {
            return element.Id;
        } 
                                    
        public static ADDB.ElementId GetElementId(ADDB.Architecture.StairsRun element)
        {
            return element.Id;
        }  
        
        // CurveElement
        //      --CurveByPoints
        //      --DetailCurve
        //      --ModelCurve
        //      --SymbolicCurve
        public static ADDB.ElementId GetElementId(ADDB.CurveByPoints element)
        {
            return element.Id;
        }
        
        public static ADDB.ElementId GetElementId(ADDB.DetailCurve element)
        {
            return element.Id;
        }
               
        public static ADDB.ElementId GetElementId(ADDB.ModelCurve element)
        {
            return element.Id;
        } 
                
        public static ADDB.ElementId GetElementId(ADDB.SymbolicCurve element)
        {
            return element.Id;
        }
        
        // DetailCurve
        //      --DetailArc
        //      --DetailEllipse
        //      --DetailLine
        //      --DetailNurbSpline
        
        public static ADDB.ElementId GetElementId(ADDB.DetailArc element)
        {
            return element.Id;
        } 
                                                         
        public static ADDB.ElementId GetElementId(ADDB.DetailEllipse element)
        {
            return element.Id;
        }  
                                                                
        public static ADDB.ElementId GetElementId(ADDB.DetailLine element)
        {
            return element.Id;
        } 
                                                                       
        public static ADDB.ElementId GetElementId(ADDB.DetailNurbSpline element)
        {
            return element.Id;
        }  
        
        // ModelCurve
        //      --ModelArc
        //      --ModelEllipse
        //      --ModelHermiteSpline
        //      --ModelLine
        //      --ModelNurbSpline
                                                                             
        public static ADDB.ElementId GetElementId(ADDB.ModelArc element)
        {
            return element.Id;
        }    
                                                                                    
        public static ADDB.ElementId GetElementId(ADDB.ModelEllipse element)
        {
            return element.Id;
        }     
                                                                                    
        public static ADDB.ElementId GetElementId(ADDB.ModelHermiteSpline element)
        {
            return element.Id;
        }  
                                                                                    
        public static ADDB.ElementId GetElementId(ADDB.ModelLine element)
        {
            return element.Id;
        }
                                                                                           
        public static ADDB.ElementId GetElementId(ADDB.ModelNurbSpline element)
        {
            return element.Id;
        } 
       
        public static ADDB.ElementId GetElementId(ADDB.Family element)
        {
            return element.Id;
        }   
        
        public static ADDB.ElementId GetElementId(ADDB.FilledRegion element)
        {
            return element.Id;
        }
               
        public static ADDB.ElementId GetElementId(ADDB.FilterElement element)
        {
            return element.Id;
        } 
                
        public static ADDB.ElementId GetElementId(ADDB.Group element)
        {
            return element.Id;
        }
               
        public static ADDB.ElementId GetElementId(ADDB.HostObject element)
        {
            return element.Id;
        } 
        
                
        public static ADDB.ElementId GetElementId(ADDB.Instance element)
        {
            return element.Id;
        }
                
        public static ADDB.ElementId GetElementId(ADDB.LinePatternElement element)
        {
            return element.Id;
        }
                
        public static ADDB.ElementId GetElementId(ADDB.Material element)
        {
            return element.Id;
        }
                
        public static ADDB.ElementId GetElementId(ADDB.ModelText element)
        {
            return element.Id;
        }
        
                
        public static ADDB.ElementId GetElementId(ADDB.Opening element)
        {
            return element.Id;
        }
        
                
        public static ADDB.ElementId GetElementId(ADDB.ParameterElement element)
        {
            return element.Id;
        }
        
                
        public static ADDB.ElementId GetElementId(ADDB.TextElement element)
        {
            return element.Id;
        }
        
                
        public static ADDB.ElementId GetElementId(ADDB.View element)
        {
            return element.Id;
        }
        
                
        public static ADDB.ElementId GetElementId(ADDB.Viewport element)
        {
            return element.Id;
        }
        
        #endregion
        ///////////////////////////////

        
    }
}