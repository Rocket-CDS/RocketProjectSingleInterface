# RocketProjectSingleInterface

## Introduction

Provides a working template for creating VS projects for a Rocket Single Interface.   (RocketContent wrapper) 

RocketContent has been designed to be a "low code" tool, with different usage dependant on the AppThemes used.  

However, it is sometimes useful to create a plugin system that is seperate from RocketContent, by using a different systemkey.  This then allows the project to have some bespoke functionality that is not included in RocketContent.

## Creating a new Project

- Copy the template to you working environment.  This is usually "/DesktopModules/DNNrocketModules/\<new project>"
- Rename the project folder to be the new project name, if not already done.

- Replace "rocketprojectsingleinterface" with "newprojectname" case-sensitive in Project
- Replace "RocketProjectSingleInterface" with "NewProjectName" case-sensitive in Project
- Rename Project files
- Rename Solution files
- Rename Resx File.
- Rename DNN manifest.
- Ensure all projects in the solution are loaded.  The project uses project references and expects the source code, but you can also add a reference to the assemblies.  External assemblies are usually added to a "_external" folder underneath the project root.


This project should be able to be compiled.