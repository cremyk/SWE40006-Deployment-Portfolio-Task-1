# SWE40006 Software Deployment and Evolution
## Deployment Activity 1: Desktop Deployment using WiX Toolset & Microsoft Store Packaging

## 📁 Repository Directory Structure

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
