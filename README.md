# Simple Store Simulator

A small virtual store written in **F#** with a **Windows Forms** interface. Users can browse a product catalog, add items to a cart, remove them, view the cart, and check out. It is an academic project meant to demonstrate functional programming in F#.

## Features

- Predefined catalog of 6 products (name, price, description), shown in a sorted `ListView`
- Add products to the cart by name (duplicates allowed)
- Remove one occurrence of a product at a time
- View the cart as a receipt (grouped by product, with quantities and line totals)
- Checkout: shows the purchase summary and total, then clears the cart
- Status messages at the bottom of the window

## Technologies

- F# on .NET 8 (`net8.0-windows`)
- Windows Forms
- Git / GitHub

## Project Structure

```text
SimpleStoreSimulator/
├── Domain.fs                  Product, Cart, CartError types
├── Store.fs                   Catalog and cart logic (no GUI code)
├── MainForm.fs                Windows Forms interface
├── Program.fs                 Application entry point
├── SimpleStoreSimulator.fsproj
├── .gitignore
└── README.md
```

The files are compiled in this order: `Domain.fs` → `Store.fs` → `MainForm.fs` → `Program.fs`.

## Prerequisites

- Windows
- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- Optional: Visual Studio 2022 with the ".NET desktop development" workload

## Clone and Run

```bash
git clone https://github.com/Moaz-Hassanein/Store-Simulator
cd Store-Simulator
dotnet restore
dotnet build
dotnet run
```

## Functional Programming Concepts

- **Immutability:** `Product` is an immutable record, the catalog is an immutable `Map`, and the cart is an immutable `string list`. `addToCart` and `removeFromCart` return a *new* cart. The GUI keeps the latest cart in a single reference cell (`cartState`).
- **First-class functions:** `applyCartOp` receives a cart operation (`Cart -> Result<Cart, CartError>`) as an argument, e.g. `applyCartOp (Store.addToCart name) "..."`.
- **Pattern matching:** used on `Result`, `Option`, empty vs. non-empty carts, and the selected item in the GUI.
- **Collection functions:** `List.map`, `List.choose`, `List.sumBy`, `List.countBy`, `List.tryFindIndex`, `List.removeAt`.



Repository: `https://github.com/Moaz-Hassanein/Store-Simulator`
