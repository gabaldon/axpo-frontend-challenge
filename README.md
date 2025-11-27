# Axpo Contract Onboarding

Blazor WebAssembly project with Tailwind CSS for styling. This project demonstrates a responsive "Contract Onboarding" page with reusable components, dynamic data loading from JSON, and smooth UI interactions.

## Features

- **Blazor WebAssembly** SPA
- **Tailwind CSS** 4 for styling
- Responsive layout (desktop, tablet, mobile)
- Reusable Accordion component (`ContractInfo`)
- Dynamic rendering from JSON (emulates API)
- Icon support in components
- Smooth slide animations (CSS-based)


## Getting Started

### Prerequisites

- .NET 10 SDK
- Node.js (for Tailwind)
- pnpm, npm or yarn

### Setup

#### 1. Install dependencies:

```
pnpm install
```

#### 2. Development:

This runs Tailwind in watch mode and Blazor WebAssembly in watch mode concurrently:

```
pnpm dev
```

* Tailwind rebuilds CSS automatically on changes.
* Blazor reloads pages automatically on changes.

#### 3. Production Build:

Build Tailwind CSS minified and Blazor WebAssembly in Release mode:

```
pnpm build
```

* Tailwind CSS output: wwwroot/css/app.css
* Blazor WebAssembly published output: publish/
* Ready to deploy to any static web server or cloud hosting.
