public sealed class BuildData
{
    public BuildData(
        ICakeContext context,
        string configuration,
        Func<BuildData, Action<Exception>> errorHandler,
        SolutionData solution)
    {
        this.Configuration = configuration;
        this.Solution = solution;

        this.DirectoriesToDelete = context
            .GetDirectories(this.Solution.ArtifactsDirectory)
            .Concat(context.GetDirectories("./src/**/bin"))
            .Concat(context.GetDirectories("./src/**/obj"))
            .OrderBy(directory => directory.ToString())
            .ToList();

        this.ErrorHandler = errorHandler(this);
    }

    public string Configuration { get; }
    public Action<Exception> ErrorHandler { get; }
    public SolutionData Solution { get; }
    public IEnumerable<DirectoryPath> DirectoriesToDelete { get; }
}

public sealed class SolutionData
{
    public SolutionData(
        string artifactsDirectory,
        string slnPath,
        IReadOnlyCollection<string> projectsPath)
    {
        this.ArtifactsDirectory = artifactsDirectory;
        this.SlnPath = slnPath;
        this.ProjectsPath = projectsPath;
    }

    public string ArtifactsDirectory { get; }
    public string SlnPath { get; }
    public IReadOnlyCollection<string> ProjectsPath { get; }
}
