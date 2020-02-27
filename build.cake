#addin "Cake.Figlet&version=1.2.0"

#load "build/*.cake"

Setup<BuildData>(context =>
{
    Information(Figlet("pt-BR Pluralization Service"));

    return new BuildData(
        context,
        GetConfiguration(),
        ErrorHandler,
        new SolutionData(
            "./artifacts",
            "./PtBrPluralizationService.sln",
            new[]
            {
                "./src/PluralizationServices",
            }));
});

Task("Default")
    .IsDependentOn("Delete-Temp-Directories")
    .IsDependentOn("Restore-NuGet-Packages")
    .IsDependentOn("Build-Solution")
    .IsDependentOn("Run-Tests");

RunTarget(Argument("target", "Default"));
