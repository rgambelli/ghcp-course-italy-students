# .NET Track Guide

This folder contains the .NET 10 version of the training labs.

## What To Install

Before starting, install:

1. Visual Studio Code
2. .NET 10 SDK
3. GitHub Copilot and GitHub Copilot Chat in VS Code
4. C# Dev Kit in VS Code
5. .NET Install Tool in VS Code
6. Markdown Preview Mermaid Support in VS Code

## Recommended Way To Open The Labs

Open the repository root in VS Code, then work inside one lab folder at a time.

If you prefer to work from the terminal, go to a lab folder like this:

```powershell
cd dotnet/lab1
```

## Lab Structure

The runnable labs use this structure:

- `src/Cegeka.Inbox`: production code
- `test/Cegeka.Inbox.Tests`: xUnit test project
- `labX.slnx`: solution file for the lab

Labs 4 and 6 are documentation and tooling exercises, so they do not contain runnable .NET projects.

## First Command To Run

In [dotnet/lab1](dotnet/lab1), run:

```powershell
dotnet test --filter "DoesYourProjectWorkCorrectly"
```

This should pass and confirms your environment is ready.

## Commands You Will Use Most

From a lab folder such as [dotnet/lab1](dotnet/lab1):

```powershell
dotnet restore
dotnet build
dotnet test
```

Use these commands as follows:

1. `dotnet restore`: downloads packages
2. `dotnet build`: compiles the code
3. `dotnet test`: runs the tests

## Expected Starter State

The labs are training starters, not finished solutions.

- The prerequisite smoke test in lab 1 should pass.
- The exercise test in lab 1 is expected to fail until the stories are implemented.

That is intentional. Students are supposed to use GitHub Copilot to complete the implementation.

## Per-Lab Notes

### Lab 1

Start here. Read [dotnet/lab1/LAB1.md](dotnet/lab1/LAB1.md) and [dotnet/lab1/LAB1_STORIES.md](dotnet/lab1/LAB1_STORIES.md), then inspect the C# starter code.

### Lab 2

The project shape is the same as lab 1. The focus is prompting quality and structure.

### Lab 3

The project shape is still the same. The focus is moving project context into instructions.

### Lab 4

This is a documentation-agent exercise. Review [dotnet/lab4/LAB4.md](dotnet/lab4/LAB4.md).

### Lab 5

This brings in a skill template and returns to the mailbox exercise. Review [dotnet/lab5/LAB5.md](dotnet/lab5/LAB5.md).

### Lab 6

This is an MCP exercise. Review [dotnet/lab6/LAB6.md](dotnet/lab6/LAB6.md).

## Suggestion

If the audience is brand new to VS Code and .NET, keep the first live demo very mechanical:

1. Open [dotnet/lab1](dotnet/lab1)
2. Run the prerequisite test
3. Open the failing exercise test
4. Read the story file
5. Ask Copilot for one small change at a time

That sequence removes most environment confusion before the actual training starts.