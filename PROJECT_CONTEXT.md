# Factory Horror — Project Context

> Główny plik kontekstowy projektu.  
> Ten plik ma być czytany na początku każdej nowej sesji pracy nad grą.

---

## 1. Cel projektu

Tworzymy krótką, fabularną grę horror 3D w widoku pierwszoosobowym.

**Silnik:** Unity 6  
**Render pipeline:** URP  
**Platforma docelowa:** Windows PC  
**Język:** C#  
**Docelowa długość gry:** około 45–90 minut  
**Tryb:** single-player  
**Priorytet:** klimat, eksploracja, audio, napięcie, proste ale solidne mechaniki  
**Ograniczenie:** projekt ma działać również na słabszym komputerze deweloperskim.

Projekt ma być możliwy do ukończenia przez jedną osobę przy wsparciu ChatGPT.

---

## 2. Główna fabuła

Gra zaczyna się od nagrania rozmowy telefonicznej.

Grupa nastolatków eksploruje opuszczoną fabrykę. Dzwonią po pomoc. Jeden z ich kolegów zaginął, nie mogą znaleźć wyjścia i słyszą / widzą coś niepokojącego.

Po rozmowie gra przenosi się do radiowozu.

Gracz wciela się w policjanta lub policjantkę jadącą na miejsce razem z partnerką / partnerem.

Po wejściu do fabryki:

- początkowo nic wyraźnie nadnaturalnego się nie dzieje,
- policjanci eksplorują obiekt,
- znajdują ślady obecności nastolatków,
- w jednym z pomieszczeń pod graczem załamuje się stara drewniana podłoga,
- partner zostaje wyżej,
- gracz spada do głębokiej piwnicy,
- od tego momentu głównym celem jest wydostanie się z fabryki i odnalezienie partnera.

W trakcie gry gracz znajduje:

- ciała nastolatków,
- telefony,
- nagrania,
- notatki,
- ślady wydarzeń,
- informacje sugerujące, jak zachowywać się wobec istoty, która grasuje w fabryce.

Jedno z nagrań ma charakter pożegnalny i jednocześnie pełni funkcję ostrzeżenia / tutorialu dotyczącego zachowania przeciwnika.

Finał:

- gracz wydostaje się z fabryki,
- dociera do radiowozu,
- uruchamia samochód,
- odjeżdża z miejsca zdarzenia.

---

## 3. Ton gry

Inspiracje:

- survival horror,
- exploration horror,
- found footage / bodycam feeling,
- industrial horror.

Najważniejsze zasady:

- potwór nie powinien być cały czas widoczny,
- napięcie ma być budowane dźwiękiem, światłem i oczekiwaniem,
- pierwsza część gry powinna być stosunkowo spokojna,
- przeciwnik ma być pokazywany stopniowo,
- nie robimy gry akcji,
- nie robimy systemów, które nie są potrzebne do głównego doświadczenia.

---

## 4. Zakres gry

### Robimy

- FPS movement,
- kamera pierwszoosobowa,
- sprint,
- kucanie,
- latarka,
- interakcje przez raycast,
- otwierane drzwi,
- pickup / oglądanie ważnych przedmiotów,
- nagrania z telefonów,
- radio policyjne,
- system objectives,
- audio 3D,
- kroki zależne od powierzchni,
- proste cutscenki,
- triggerowane wydarzenia,
- przeciwnik AI,
- checkpoints,
- proste zapisywanie postępu,
- menu,
- ustawienia podstawowe,
- napisy,
- finał z ucieczką do radiowozu.

### Na ten moment NIE robimy

- craftingu,
- rozbudowanego ekwipunku,
- otwartego świata,
- pojazdów sterowanych przez gracza,
- wielu typów broni,
- wielu przeciwników,
- drzewka rozwoju,
- systemu handlu,
- multiplayera,
- proceduralnego świata,
- wielu zakończeń.

Jeżeli pojawi się pomysł na nową mechanikę, najpierw należy sprawdzić, czy naprawdę jest potrzebna.

---

## 5. Broń

Początkowo gracz nie powinien swobodnie korzystać z broni.

Preferowany wariant:

- policjant ma broń podczas przyjazdu,
- po upadku do piwnicy traci do niej dostęp,
- broń może pojawić się dopiero później,
- amunicja ma być bardzo ograniczona,
- broń nie może zamienić horroru w shooter.

Ten punkt może jeszcze ulec zmianie.

---

## 6. Układ fabryki

Fabryka ma cztery główne poziomy:

### +1 — piętro pod dachem

- stare biura,
- archiwum,
- magazyn,
- pomieszczenie socjalne,
- kładka nad halą,
- widok na główną halę.

### 0 — parter

- wejście,
- recepcja,
- portiernia / ochrona,
- korytarze,
- biura,
- szatnia,
- toalety,
- główna hala produkcyjna,
- magazyn,
- miejsce załamania podłogi.

### -1 — poziom techniczny

- kotłownia,
- warsztat,
- rozdzielnia,
- magazyn części,
- tunele techniczne,
- rury,
- zawory,
- betonowe korytarze.

### -2 — głęboka piwnica

To tutaj spada gracz.

- miejsce upadku,
- stary magazyn,
- archiwum,
- stary warsztat,
- pompownia,
- generator,
- szyb techniczny,
- pierwsze ważne ciało,
- telefon z nagraniem,
- pierwsze wyraźne informacje o zagrożeniu.

---

## 7. Progres gry

### Akt I — przyjazd

- rozmowa alarmowa / nagranie,
- przejazd radiowozem,
- rozmowa policjantów,
- wejście do fabryki,
- spokojna eksploracja,
- pierwsze ślady nastolatków,
- załamanie podłogi.

### Akt II — piwnica

- gracz budzi się po upadku,
- odzyskuje latarkę,
- próbuje skontaktować się przez radio,
- znajduje pierwsze ciało,
- znajduje telefon,
- poznaje pierwsze zasady zagrożenia,
- uruchamia generator,
- szuka wyjścia.

### Akt III — poziom techniczny

- bardziej klaustrofobiczna eksploracja,
- pierwsze prawdziwe spotkanie z przeciwnikiem,
- przejście z -1 na parter.

### Akt IV — ponowny parter

- partnera nie ma,
- pojawiają się nowe ślady,
- część wcześniej znanych miejsc wygląda inaczej,
- prowadzenie gracza na +1.

### Akt V — piętro +1

- dalsze informacje fabularne,
- odnalezienie partnera lub informacji o nim,
- sekwencja kulminacyjna,
- ucieczka przez fabrykę.

### Finał

- sprint do wyjścia,
- parking,
- radiowóz,
- odpalenie silnika,
- odjazd,
- zakończenie.

---

## 8. Zasady level designu

- Każde piętro ma mieć kilka charakterystycznych miejsc.
- Nie budujemy gigantycznego labiryntu.
- Gracz powinien po czasie rozpoznawać miejsca.
- Część lokacji ma być odwiedzana więcej niż raz.
- W trakcie gry otwieramy skróty.
- Fabryka ma wydawać się większa, niż faktycznie jest.
- Poziomy początkowo budujemy jako blockout z prostych brył.
- Nie modelujemy szczegółów przed zatwierdzeniem układu poziomu.

---

## 9. Pipeline artystyczny

### Unity

Używamy Unity głównie do:

- budowy poziomów,
- ProBuildera / prostych brył,
- materiałów,
- oświetlenia,
- prefabs,
- gameplayu,
- audio,
- AI,
- triggerów,
- cutscenek.

### Blender

Blender będzie używany tylko wtedy, gdy potrzebny jest konkretny model:

- zniszczona brama,
- nietypowy komin,
- rury,
- maszyny,
- uszkodzone ściany,
- charakterystyczne elementy fabryki.

Nie modelujemy wszystkiego od zera.

---

## 10. Optymalizacja

Projekt ma być lekki.

Preferowane:

- URP,
- baked lighting tam, gdzie ma sens,
- ograniczona liczba świateł realtime,
- occlusion culling,
- LOD-y,
- rozsądne rozdzielczości tekstur,
- modularne assety,
- unikanie ciężkich efektów post-process,
- profilowanie dopiero wtedy, gdy coś faktycznie działa wolno.

---

## 11. Główne systemy

Planowane systemy:

- `PlayerController`
- `CameraController`
- `InteractionSystem`
- `FlashlightController`
- `DoorController`
- `PickupSystem`
- `AudioManager`
- `FootstepSystem`
- `RadioSystem`
- `PhoneRecordingSystem`
- `ObjectiveSystem`
- `CheckpointSystem`
- `SaveSystem`
- `TriggerSystem`
- `CutsceneManager`
- `EnemyAI`
- `EnemyVision`
- `EnemyHearing`

Nie wszystkie muszą być osobnymi klasami. Architektura może być uproszczona w trakcie pracy.

---

# 12. PLAN PRODUKCJI

## MILESTONE 0 — konfiguracja projektu

- [ ] utworzyć nowy projekt Unity 6 URP
- [ ] ustawić repozytorium Git
- [ ] dodać `.gitignore` dla Unity
- [ ] ustawić `Visible Meta Files`
- [ ] ustawić `Asset Serialization = Force Text`
- [ ] utworzyć podstawową strukturę folderów
- [ ] zrobić pierwszy commit

### Proponowana struktura

```text
Assets/
├── _Project/
│   ├── Animations/
│   ├── Audio/
│   ├── Materials/
│   ├── Models/
│   ├── Prefabs/
│   ├── Scenes/
│   ├── Scripts/
│   │   ├── Player/
│   │   ├── Interaction/
│   │   ├── AI/
│   │   ├── Audio/
│   │   ├── Systems/
│   │   └── UI/
│   ├── Textures/
│   └── UI/
docs/
```

---

## MILESTONE 1 — pierwsza grywalna scena

Cel:

> Gracz może chodzić po prostej testowej scenie 3D.

- [ ] utworzyć `Prototype.unity`
- [ ] podłoga
- [ ] ściany
- [ ] kamera FPS
- [ ] movement
- [ ] mouse look
- [ ] sprint
- [ ] podstawowe kolizje
- [ ] testowy build gry

---

## MILESTONE 2 — interakcje

Cel:

> Można wejść do prostego pomieszczenia i wejść w interakcję z obiektami.

- [ ] raycast z kamery
- [ ] interfejs obiektów interaktywnych
- [ ] prompt interakcji
- [ ] otwieranie drzwi
- [ ] prosty przycisk / przełącznik
- [ ] podnoszenie przedmiotu
- [ ] testowy telefon

---

## MILESTONE 3 — latarka i audio

- [ ] latarka
- [ ] włączanie / wyłączanie
- [ ] AudioSource 3D
- [ ] ambient fabryki
- [ ] kroki gracza
- [ ] różne powierzchnie kroków
- [ ] drzwi z dźwiękiem
- [ ] pierwszy trigger audio

---

## MILESTONE 4 — blockout parteru

Cel:

> Można wejść z zewnątrz do fabryki i przejść całą planowaną trasę aktu I.

- [ ] exterior fabryki
- [ ] parking
- [ ] wejście
- [ ] recepcja
- [ ] korytarz
- [ ] biuro
- [ ] główna hala
- [ ] magazyn
- [ ] miejsce załamania podłogi
- [ ] schody na +1
- [ ] przejście na -1

Bez szczegółowych modeli.

---

## MILESTONE 5 — sekwencja początku gry

- [ ] nagranie rozmowy alarmowej
- [ ] przyjazd radiowozu
- [ ] partner policjant
- [ ] wejście do fabryki
- [ ] pierwszy dialog
- [ ] ślady nastolatków
- [ ] event załamania podłogi
- [ ] upadek do -2
- [ ] utrata kontaktu z partnerem

Po tym milestone powinna istnieć pierwsza grywalna sekwencja około 5–10 minut.

---

## MILESTONE 6 — piwnica

- [ ] blockout poziomu -2
- [ ] odzyskanie latarki
- [ ] radio
- [ ] pierwsze ciało
- [ ] telefon z nagraniem
- [ ] generator
- [ ] prosty objective
- [ ] wyjście na -1

---

## MILESTONE 7 — przeciwnik

Najpierw prototyp.

- [ ] model zastępczy przeciwnika
- [ ] NavMesh
- [ ] patrol
- [ ] wykrywanie gracza
- [ ] słuch
- [ ] pościg
- [ ] utrata gracza
- [ ] reakcja na latarkę lub dźwięk — do ustalenia
- [ ] death / fail state
- [ ] checkpoint restart

---

## MILESTONE 8 — pełny blockout gry

Cel:

> Grę można przejść od początku do napisów końcowych.

- [ ] poziom -2
- [ ] poziom -1
- [ ] parter
- [ ] poziom +1
- [ ] skróty
- [ ] wszystkie objectives
- [ ] kluczowe wydarzenia fabularne
- [ ] zakończenie
- [ ] radiowóz
- [ ] credits

Grafika nadal może być bardzo surowa.

---

## MILESTONE 9 — vertical slice

Wybrać około 10–15 minut gry i doprowadzić je prawie do jakości finalnej.

- [ ] finalne materiały
- [ ] finalne oświetlenie
- [ ] finalne audio
- [ ] lepsze animacje
- [ ] modele
- [ ] post-processing
- [ ] dialogi
- [ ] UI
- [ ] optymalizacja

Po tym etapie można rozpocząć sensowną promocję gry.

---

## MILESTONE 10 — produkcja pełnej wersji

- [ ] finalizacja wszystkich pomieszczeń
- [ ] finalne assety
- [ ] finalne audio
- [ ] finalne animacje
- [ ] AI tuning
- [ ] checkpointy
- [ ] menu
- [ ] opcje
- [ ] napisy
- [ ] save system

---

## MILESTONE 11 — demo

Cel: publiczne demo około 15–25 minut.

- [ ] wybrać zakres dema
- [ ] poprawić onboarding
- [ ] QA
- [ ] performance test
- [ ] build demo
- [ ] materiały promocyjne

---

## MILESTONE 12 — beta

- [ ] pełna gra grywalna
- [ ] testerzy zewnętrzni
- [ ] bug fixing
- [ ] balans horroru
- [ ] poprawki level designu
- [ ] poprawki audio
- [ ] optymalizacja

Od tego momentu nie dodajemy dużych nowych systemów.

---

## MILESTONE 13 — release

- [ ] Release Candidate 1
- [ ] test pełnego przejścia
- [ ] poprawki
- [ ] Release Candidate 2
- [ ] finalny build
- [ ] publikacja

---

# 13. AKTUALNY STAN

**Data startu:** 16.09.2026

### Gotowe

- [x] ogólny pomysł fabularny
- [x] wybrany silnik: Unity
- [x] Unity zainstalowane
- [x] ustalony gatunek
- [x] ustalony przybliżony układ fabryki
- [x] ustalone główne piętra
- [x] ustalony główny przebieg historii

### Aktualny milestone

**MILESTONE 0 — konfiguracja projektu**

### Następne zadanie

1. Utworzyć projekt Unity 6 w URP.
2. Utworzyć repozytorium Git.
3. Dodać projekt do GitHuba.
4. Skonfigurować `.gitignore`.
5. Ustawić `Visible Meta Files`.
6. Ustawić `Force Text`.
7. Utworzyć foldery projektu.
8. Wykonać pierwszy commit.

Po zakończeniu przejść do:

**MILESTONE 1 — pierwsza grywalna scena.**

---

# 14. Zasady pracy z ChatGPT

ChatGPT ma pełnić rolę:

- drugiego developera,
- mentora Unity,
- osoby pomagającej w architekturze,
- debuggera,
- pomocnika level designera,
- wsparcia przy audio,
- wsparcia przy fabule.

ChatGPT powinien:

1. Najpierw sprawdzać aktualny stan projektu.
2. Nie zakładać, że istnieją systemy, których nie ma.
3. Prowadzić użytkownika krok po kroku.
4. Wyjaśniać dlaczego dana rzecz jest robiona.
5. Nie dodawać zbędnych systemów.
6. Pilnować scope'u projektu.
7. Preferować proste i stabilne rozwiązania.
8. Uwzględniać słabszy komputer użytkownika.
9. Aktualizować ten plik po większych zmianach.
10. Przy nowych decyzjach zaznaczać, czy wpływają na istniejącą architekturę.

---

# 15. Instrukcja dla NOWEGO CZATU

Na początku nowej rozmowy użytkownik może napisać:

> Pracujemy dalej nad projektem Factory Horror.  
> Przeczytaj `PROJECT_CONTEXT.md` w repozytorium i na jego podstawie ustal aktualny stan projektu.  
> Sprawdź sekcję `AKTUALNY STAN` oraz checklistę milestone'ów.  
> Następnie poprowadź mnie od kolejnego niezakończonego zadania.  
> Nie projektuj projektu od nowa, chyba że wykryjesz konkretny problem z obecną architekturą.

Nowy czat powinien najpierw:

1. przeczytać ten plik,
2. sprawdzić repozytorium,
3. określić, które zadania są zakończone,
4. wskazać następne zadanie,
5. kontynuować istniejący projekt.

---

# 16. DEV LOG

Po każdej większej sesji dopisuj wpis.

## Szablon

```text
## YYYY-MM-DD

### Zrobione
- ...

### Zmienione decyzje
- ...

### Problemy
- ...

### Następne zadanie
- ...
```

---

## 2026-09-16

### Zrobione

- utworzono główny dokument projektu,
- zdefiniowano fabułę,
- zapisano plan milestone'ów,
- ustalono strukturę pracy.

### Następne zadanie

Rozpocząć MILESTONE 0 i utworzyć projekt Unity 6 URP.
