# GHCP Training Students

This repository contains the materials for the students of the hands-on GHCP training.

## Before You Start

1. Complete module 1 and module 2 of part 1 of the Microsoft GHCP training:
   - Module 1: https://learn.microsoft.com/en-us/training/modules/responsible-ai-with-github-copilot/
   - Module 2: https://learn.microsoft.com/en-us/training/modules/introduction-to-github-copilot/
   - Full learning path: https://learn.microsoft.com/en-us/training/paths/copilot/
2. Confirm you have a working GitHub Copilot license and a Cegeka-linked GitHub account.
3. Make sure you can access the Cegeka-Application-Services organization: https://github.com/Cegeka-Application-Services

## Choose Your Track

- Java track: start in [java/lab1](java/lab1)
- .NET track: start in [dotnet/lab1](dotnet/lab1)

If you are new to VS Code and .NET, use the .NET track and follow the setup below.

## First-Time VS Code And .NET Setup

### 1. Install the required software

Install these tools before opening the labs:

1. Visual Studio Code: https://code.visualstudio.com/
2. .NET 10 SDK: https://dotnet.microsoft.com/download
3. Git: https://git-scm.com/downloads

After installation, open a terminal and confirm the tools are available:

```powershell
dotnet --version
git --version
```

### 2. Install the required VS Code extensions

Open VS Code, go to the Extensions view, and install these extensions:

1. GitHub Copilot
2. GitHub Copilot Chat
3. C# Dev Kit
4. .NET Install Tool
5. Markdown Preview Mermaid Support

Then restart VS Code once.

### 3. Open the repository in VS Code

1. Clone or download this repository.
2. In VS Code, select `File` > `Open Folder...`
3. Open the repository root folder.
4. In the Explorer, open the lab folder for the track you want to follow.

### 4. Verify the .NET track works

If you are following the .NET track:

1. Open [dotnet/lab1](dotnet/lab1) in VS Code.
2. Open the integrated terminal with `Terminal` > `New Terminal`.
3. Run this command:

```powershell
dotnet test --filter "DoesYourProjectWorkCorrectly"
```

The command should pass. This verifies that your SDK, restore, test runner, and VS Code setup are working.

### 5. Verify the Java track works

If you are following the Java track:

1. Install Java 25.
2. Open [java/lab1](java/lab1).
3. Run `PrerequisiteProjectTest` from your IDE.

## Suggested Workflow For Beginners

If you have never used VS Code, GitHub Copilot, or .NET before, use this order:

1. Finish the Microsoft learning modules first.
2. Open [dotnet/lab1](dotnet/lab1).
3. Run the prerequisite test command.
4. Read the lab story file before prompting Copilot.
5. Make small prompts and run tests often.

## .NET Track Guide

For the .NET labs, including the recommended extensions and the exact commands to run, see [dotnet/README.md](dotnet/README.md).


