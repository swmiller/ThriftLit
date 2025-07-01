# ThriftMedia

ThriftMedia is a distributed application for managing and browsing media inventories for thrift stores and the public. Built with .NET Aspire, Blazor, and modern .NET best practices.

## Project Structure

- **src/ThriftMedia.Web**: Public-facing Blazor WebAssembly UI
- **src/ThriftMedia.Api**: Public API for media browsing and data access
- **src/ThriftMedia.AppHost**: Aspire distributed application orchestrator
- **src/ThriftMedia.ServiceDefaults**: Shared service configuration and defaults
- **.github/**: Project instructions, workflows, and documentation

## Getting Started

1. **Clone the repository**
2. **Build the solution**
   ```sh
   dotnet build ThriftMedia.sln
   ```
3. **Run the distributed app**
   ```sh
   dotnet run --project src/ThriftMedia.AppHost/ThriftMedia.AppHost.csproj
   ```

## Features
- Public media browsing (no authentication required)
- Admin UI (future) for thrift store inventory management
- Modern .NET patterns: CQRS, MediatR, FluentValidation, XUnit
- Cloud-native with .NET Aspire

## Contributing
- See `.github/copilot-instructions.md` for coding standards
- Add requirements to `.github/PROJECT-BRIEF.md`

## License
MIT (or specify your license here)
