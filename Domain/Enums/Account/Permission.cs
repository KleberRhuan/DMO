namespace Domain.Enums.Account;

[Flags]
public enum Permission {
    None = 0,
    Read = 1,
    Write = 2,
    Execute = 4,
    ManageUsers = 8,
    AdministerSystem = 16,
    BanPlayer = 32,
    UnbanPlayer = 64,
    MutePlayer = 128,
    UnmutePlayer = 256,
    KickPlayer = 512,
    ModifyPlayerStats = 1024,
    SpawnItems = 2048,
    ModifyEvents = 4096,
    AccessGmCommands = 8192,
    ManageServer = 16384,
    ManageEvents = 32768,
    SupportTickets = 65536,
    ModifyEconomy = 131072,
    MonitorSecurity = 262144,
    ConfigureSettings = 524288,
    AccessReports = 1048576
}