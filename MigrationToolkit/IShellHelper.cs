using ToolBox.Bridge;

namespace MigrationToolkit
{
    public interface IShellHelper
    {
        Response RunExternalCommand(string command);
        Response RunInternalCommand(string command);
    }
}
