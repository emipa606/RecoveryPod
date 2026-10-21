# GitHub Copilot Instructions for Recovery Pod (Continued) Mod

## Mod Overview and Purpose

**Recovery Pod (Continued)** is a RimWorld mod that enhances game mechanics by introducing a portable and self-contained transport pod. Developed as an update of pelador's original mod, its primary purpose is to offer emergency transportation options for caravans and remote operations by leveraging advanced spacer technology using plasteel. This mod aims to enhance player strategies involving travel and emergency response with lightweight, efficient transportation solutions.

## Key Features and Systems

- **Portable Recovery Pod Kits**: After completing the necessary research, players can produce recovery pod kits at a fabrication bench. These kits are designed for ease of transportation as lightweight cargo bags.

- **Self-contained Drop Pods**: Deployed as miscellaneous buildings, these pods can be individually fueled and utilized like standard drop pods with a reduced weight capacity of 100kg. They offer convenience and efficiency for the transport of goods or personnel.

- **Caravan Compatibility**: These pods are specifically designed to integrate smoothly with caravans, providing flexible deployment options during expeditions.

- **Deconstruct and Repack**: Pods can be deconstructed back into kits and repacked into cargo bags at crafting spots, ensuring reusability and efficient storage.

## Coding Patterns and Conventions

The mod uses the following coding patterns and conventions:
- **C# Naming Conventions**: Types and member methods follow PascalCase naming conventions for easy readability and consistency. Use descriptive names for clarity.
- **XML Integration**: XML files are used to define recipes, research projects, and items related to the recovery pods. Maintain initialization order and tag consistency.
- **Comments and Documentation**: Include descriptive comments in code to document functions and important logic decisions.

## XML Integration

XML files are integral for defining in-game items, recipes, and research projects:
- **RecipeDef Files**: Define the recipes to construct the recovery pod kits.
- **ThingDef Files**: Specify the properties and characteristics of the recovery pods and related items.
- **ResearchProjectDef Files**: Establish the research requirements necessary to unlock the technology for the recovery pods.

## Harmony Patching

Utilizes the Harmony library (dependency: brrainz.harmony) to patch and extend game functionality:
- **Prefix and Postfix Methods**: Used to modify the behavior of vanilla game methods without altering the original source code, providing safe and reversible modifications.

### Suggestions for Copilot

- **Automate XML Definition Creation**: Develop XML file templates in Copilot to quickly generate common structures for RecipeDef, ThingDef, and ResearchProjectDef, ensuring consistent organization.
- **Code Suggestions for Harmony Patching**: Enable Copilot to propose common patching scenarios and method signatures for achieving specific mod functionalities.
- **Error Handling and Logging**: Implement automated suggestions for logging outputs to aid in debugging and mod optimization.
- **Code Optimization Tips**: Provide insights for efficient code practices and optimizations, especially when dealing with complex class interactions.

This comprehensive guide should empower contributors to leverage GitHub Copilot efficiently within the context of the Recovery Pod (Continued) mod, facilitating collaborative development and maintenance of this RimWorld modification.

## Project Solution Guidelines
- Relevant mod XML files are included as Solution Items under the solution folder named XML, these can be read and modified from within the solution.
- Use these in-solution XML files as the primary files for reference and modification.
- The `.github/copilot-instructions.md` file is included in the solution under the `.github` solution folder, so it should be read/modified from within the solution instead of using paths outside the solution. Update this file once only, as it and the parent-path solution reference point to the same file in this workspace.
- When making functional changes in this mod, ensure the documented features stay in sync with implementation; use the in-solution `.github` copy as the primary file.
- In the solution is also a project called Assembly-CSharp, containing a read-only version of the decompiled game source, for reference and debugging purposes.
- For any new documentation, update this copilot-instructions.md file rather than creating separate documentation files.


## Hard rules (must follow)
- Do NOT run commands that modify the repo (no git commit, git apply, dotnet format) unless explicitly asked.
- Prefer minimal reads: read only the smallest code region needed (around the suspicious lines).
- When mentioning SonarQube issues, automatically use the SonarQube MCP service to fetch and address issues instead of making inferred fixes without querying SonarQube first.
- When mentioning the rimworld log, automatically use the Rimworld MCP service to fetch the log.

