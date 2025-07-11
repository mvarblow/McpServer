using McpServer.Tools;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddMcpServer()
    .WithHttpTransport()
    .WithTools<TimeTool>();

var app = builder.Build();

app.MapMcp();
app.Run();