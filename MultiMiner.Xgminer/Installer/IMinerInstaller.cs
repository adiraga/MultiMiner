namespace MultiMiner.Xgminer.Installer
{
    public interface IMinerInstaller
    {
        void InstallMiner(string destinationFolder);
        string GetAvailableMinerVersion();
        string GetInstalledMinerVersion(string executablePath);
        string GetMinerDownloadRoot();
    }
}
