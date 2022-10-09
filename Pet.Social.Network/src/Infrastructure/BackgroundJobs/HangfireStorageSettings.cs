namespace Pet.Social.Network.Infrastructure.BackgroundJobs;

public class HangfireStorageSettings
{
    public string? StorageProvider { get; set; }
    public string? ConnectionString { get; set; }
}