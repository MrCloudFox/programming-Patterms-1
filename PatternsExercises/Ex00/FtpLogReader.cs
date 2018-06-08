using Patterns.Ex00;
using Patterns.Ex00.ExternalLibs;

public class FtpLogReader : ILogReader
{
    private string login;
    private string password;

    public FtpLogReader(string log, string pass)
    {
        this.login = log;
        this.password = pass;
    }

    public string ReadLogFile(string identificator)
    {
        var ftp = new FtpClient();
        return ftp.ReadFile(login, password, identificator);
    }
}