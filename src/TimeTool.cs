using System.ComponentModel;
using ModelContextProtocol.Server;

namespace McpServer;

[McpServerToolType]
public class TimeTool
{
    [McpServerTool, Description("Get the current local time.")]
    public static DateTime GetCurrentTime() => DateTime.Now;
}