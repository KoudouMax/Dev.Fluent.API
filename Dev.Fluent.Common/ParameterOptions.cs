namespace Dev.Fluent.Common
{
    public class ParameterOptions
    {
        #region Properties
        public string ConnectionString { get; set; } = String.Empty;
        public int TimeoutSeconds { get; set; }
        public bool EnableLogging { get; set; }
        #endregion
    }
}