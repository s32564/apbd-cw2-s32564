# apbd-cw2-s32564

## Opis
Projekt przedstawia aplikację konsolową w języku C#, służącą do obsługi uczelnianej wypożyczalni sprzętu. System umożliwia zarządzanie użytkownikami, sprzętem oraz procesem wypożyczania i zwrotów.

## Decyzje projectowe
Main - zawiera wszystkie encji jak Gadgets (urządzenia), Users (użytkownicy), oraz Rents (dane wyporzyczeń).
Container - miejsce do przechowywania urządzeń, użytkowników i wyporzyczeń.
Service - zawiera logikę pracy projektu.

W taki sposób w projekcie można łatwo dodać nowe typy urządzeń i użytkowników, zmieniać karę za opóżnienie. Umożliwia łatwą zmianę implementacji projektu. Poprawia czytelność kodu.
