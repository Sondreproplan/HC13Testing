using HC13Testing.Services;

var builder = WebApplication.CreateBuilder(args);

// Register service with ef core
builder.Services.AddScoped<IPersonService, PersonService>();
builder.Services.AddScoped<IAssignmentService, AssignmentService>();

builder.Services
    .AddGraphQLServer()
    // Delegate first request to startup of application. Reduce cold start time.
    .InitializeOnStartup()
    // Source generator. Nuget package HotChocolate.Types.Analyzers. Auto registers query type, mutation type, PersonExtensions, AssignmentExtensions etc.
    .AddTypes()
    .AddFiltering()
    // Opt in to graphql mutation conventions.
    .AddMutationConventions()
    // Add query field to mutation payloads. Can be used to return data from mutations.
    .AddQueryFieldToMutationPayloads()
    // Register service with HC as well known type.
    .RegisterService<IPersonService>()
    .RegisterService<IAssignmentService>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
