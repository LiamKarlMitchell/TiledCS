namespace TiledCS
{
    /// <summary>
    /// Represents the layer type
    /// </summary>
    public enum TiledLayerType
    {
        /// <summary>
        /// Indicates that the layer is an object layer
        /// </summary>
        ObjectLayer,
        
        /// <summary>
        /// Indicates that the layer is a tile layer
        /// </summary>
        TileLayer,
        
        /// <summary>
        /// Indicates that the layer is an image layer
        /// </summary>
        ImageLayer
    }

    /// <summary>
    /// Represents property's value data type
    /// </summary>
    public enum TiledPropertyType
    {
        /// <summary>
        /// A string value
        /// </summary>
        String,
        
        /// <summary>
        /// A bool value
        /// </summary>
        Bool,
        
        /// <summary>
        /// A color value in hex format
        /// </summary>
        Color,
        
        /// <summary>
        /// A file path as string
        /// </summary>
        File,
        
        /// <summary>
        /// A float value
        /// </summary>
        Float,
        
        /// <summary>
        /// An int value
        /// </summary>
        Int,
        
        /// <summary>
        /// An object value which is the id of an object in the map
        /// </summary>
        Object
    }

    /// <summary>
    /// Represents the orientation of the map the strings exposed on this class are the
    /// possible values for the Orientation property on a TiledMap.
    /// </summary>
    public static class TiledOrientation
    {
        /// <summary>
        /// An Orthogonal layout.
        /// </summary>
        public static readonly string Orthogonal = "orthogonal";
        
        /// <summary>
        /// An Isometric layout.
        /// </summary>
        public static readonly string Isometric = "isometric";
        
        /// <summary>
        /// An Isometric (Staggered) layout.
        /// </summary>
        public static readonly string IsometricStaggered = "staggered";
        
        /// <summary>
        /// A Hexagonal (Staggered) layout.
        /// When the Orientation of a Tiled map is Hexagonal the values
        /// HexSideLength, StaggerAxis and StaggerIndex are used to describe
        /// the size and positioning of the hexagon tiles.
        /// </summary>
        public static readonly string Hexagonal = "hexagonal";
    }

    /// <summary>
    /// Represents the staggerIndex of the map the strings exposed on this class are the
    /// possible values for the StaggerIndex property of a TiledMap.
    /// </summary>
    public static class TiledStaggerIndex
    {
        /// <summary>
        /// Even tiles are staggered.
        /// </summary>
        public static readonly string Even = "even";
        
        /// <summary>
        /// Odd tiles are staggered.
        /// </summary>
        public static readonly string Odd = "odd";
    }
    
    /// <summary>
    /// Represents the staggerAxis of the map the strings exposed on this class are the
    /// possible values for the StaggerAxis property of a TiledMap.
    /// </summary>
    public static class TiledStaggerAxis
    {
        /// <summary>
        /// X axis is staggered.
        /// </summary>
        public static readonly string X = "x";
        
        /// <summary>
        /// Y axis is staggered.
        /// </summary>
        public static readonly string Y = "y";
    }
}