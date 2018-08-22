namespace Microsoft.SourceBrowser.HtmlGenerator.Utilities
{
    public class ProjectData
    {
		public string Name;
		public string AssemblyName;
		public string FilePath;

		public ProjectData( string name, string assemblyName, string filePath ) {
			Name = name;
			AssemblyName = assemblyName;
			FilePath = filePath;
		}
	}
}
