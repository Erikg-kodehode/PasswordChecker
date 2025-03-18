# Password Strength Checker

## Beskrivelse

Dette er et C#-program som sjekker hvor sterkt et passord er basert på lengde og innhold. Programmet bruker `if/else if/else`-blokker for å evaluere passordet.

## Hvordan bruke programmet

1. Kjør programmet med:
   ```
   dotnet run
   ```
2. Skriv inn et passord når du blir bedt om det.
3. Programmet vil fortelle deg om passordet er:

- **Svakt** (mindre enn 8 tegn)
- **Middels sterkt** (8-11 tegn)
- **Sterkt** (12 eller flere tegn)
- **Ekstra sterkt** hvis det inneholder tall eller spesialtegn.

## Pseudokode

Pseudokoden som beskriver programlogikken finnes i [pseudokode.txt](pseudokode.txt).

## Krav

- .NET SDK installert
- C# 8+ støttet

## Hvordan bygge og kjøre

1. Bygg prosjektet:
   ```
   dotnet build
   ```
2. Kjør prosjektet:
   ```
   dotnet run
   ```

## Lisens

Dette prosjektet er fritt å bruke og endre.
