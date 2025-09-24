# Bibliotekssystem2

Bibliotekssystem2 är ett konsolbaserat bibliotekssystem utvecklat i C# (.NET 8) som hanterar böcker, låntagare och bibliotekarier. 
Systemet erbjuder grundläggande funktioner för att logga in som bibliotekarie eller låntagare, hantera böcker och utföra sökningar.

## Funktioner

- Inloggning som bibliotekarie eller låntagare
- Hantering av böcker (lägg till, ta bort, sök)
- Låna och återlämna böcker
- Sökfunktion för böcker
- Konsolbaserat användargränssnitt

## Installation

1. Klona repot: git clone https://github.com/JackGriph/Bibliotekssystem2.git
2. Öppna projektet i Visual Studio 2022.
3. Säkerställ att .NET 8 är installerat.
4. Bygg och kör projektet.

## Användning

Starta programmet och välj roll:
- **Bibliotekarie**: Hantera böcker och användare.
- **Låntagare**: Sök, låna och återlämna böcker.

Följ instruktionerna i konsolen för att navigera i systemet.

## Struktur

- `Program.cs` – Startpunkt och huvudmeny
- `Book.cs` – Bokklass
- `User.cs` – Basklass för användare
- `Librarian.cs` – Bibliotekarieklass
- `Borrower.cs` – Låntagarklass
- `Helpers.cs` – Hjälpfunktioner
- `Searchable.cs` – Sökfunktionalitet

## Krav

- .NET 8
- Visual Studio 2022 (eller kompatibel IDE)

## Licens

Projektet är open source och distribueras under MIT-licensen.

---

För frågor eller förbättringsförslag, vänligen skapa ett issue eller kontakta repoägaren.
