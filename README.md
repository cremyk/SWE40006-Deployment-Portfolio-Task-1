## Deployment Activity 1: Desktop Deployment using WiX Toolset & Microsoft Store Packaging

## Project Overview
This repository contains the complete implementation for Deployment Activity 1, demonstrating the deployment lifecycle of a Windows desktop application. The project showcases a custom C# Windows Forms application (BMI Health Tracker) modularized with multiple custom DLL dependencies, packaged into an enterprise Windows Installer (.msi) using the modern WiX Toolset, and containerized for modern Windows Store distribution using the Windows Application Packaging Project.

---

## Repository Directory Structure

```text
SWE40006-Deployment-Portfolio-Task-1/
│
├── Task1.1/                           # Task 1.1 (Pass Level)
│   └── ExampleDesktop/                # Sample Windows Desktop App & WiX MSI Setup
│
├── Task1.2/                           # Task 1.2 (Credit Level)
│   └── BMIHealthTracker/              # Custom C# Desktop Application (BMI & Health Tracker)
│       ├── BMIHealthTracker/          # Main WinForms Application Project
│       └── BMIHealthTrackerSetup/     # WiX v4 Installer Project
│
├── Task1.3/                           # Task 1.3 (Distinction Level)
│   └── BMIHealthTracker/              # Multi-DLL Modular Desktop Architecture
│       ├── BMIHealthTracker/          # Main WinForms UI Project
│       ├── BmiCalculatorLib/          # Custom DLL 1: Mathematical Calculation Library
│       ├── HealthAdviceLib/           # Custom DLL 2: Clinical Diagnostics Library
│       └── BMIHealthTrackerSetup/     # WiX Installer Bundling EXE + Both DLL Dependencies
│
├── Task1.4/                           # Task 1.4 (High Distinction Level)
│   └── BMIHealthTracker/              # Full Solution with Store Packaging
│       ├── BMIHealthTrackerPackage/   # Windows Application Packaging Project (MSIX/AppX)
│       └── ...                        # Multi-DLL Core Engine Projects
│
├── .gitignore                         # Visual Studio Standard Ignore File
└── README.md                          # Repository Documentation & Verification Index
```

---

## Technology Stack & Tools Used

| Category | Technology / Tool | Version / Specification | Purpose |
| :--- | :--- | :--- | :--- |
| **Language & Runtime** | C# / .NET Framework | .NET Framework 4.8 | Core application logic, GUI, and Class Libraries |
| **Development IDE** | Microsoft Visual Studio | 2022 Community (v17.x) | Solution management, compilation, and debugging |
| **Deployment Engine** | WiX Toolset & HeatWave | WiX v4.0 / HeatWave VS Extension | XML authoring (`.wxs`) and native `.msi` package creation |
| **Modern Packaging** | Windows App Packaging Project | Desktop Bridge (MSIX / AppX) | Modern Store containerization and local sideloading |
| **Security & Signing** | X.509 Digital Certificate | SHA-256 Self-Signed (`.cer`) | Package integrity validation and local certificate trust |
| **Target Platform** | Windows OS | Windows 10 / Windows 11 (`x64`) | Target deployment and execution environment |
| **Version Control** | Git & GitHub | Git / GitHub Desktop | Source code hosting and public deployment verification |
