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

Gra rozpoczyna się od nagrania zgłoszenia na policję.

Grupa nastolatków eksploruje opuszczoną fabrykę. Podają adres, mówią chaotycznie, że potrzebują pomocy, jeden z ich kolegów ma kłopoty i nie potrafią wydostać się z obiektu.

Po nagraniu akcja przenosi się do radiowozu.

Gracz wciela się w policjanta lub policjantkę jadącą na miejsce razem z partnerką. Radiowóz zatrzymuje się przed uszkodzoną bramą wjazdową, przez którą samochód nie przejedzie, ale policjanci mogą wejść pieszo.

Początek gry jest spokojny. Policjanci:

- oglądają teren fabryki,
- sprawdzają dok załadunkowy,
- obchodzą budynek i parking,
- szukają legalnego / możliwego wejścia,
- znajdują drzwi wejściowe zamknięte grubym łańcuchem,
- dostają się do środka przez wybite okno przy ustawionej obok drabinie.

Podczas przechodzenia przez okno partnerka gubi radio. Ma to fabularnie odciąć możliwość późniejszej łatwej komunikacji.

W środku policjanci eksplorują obiekt i znajdują pierwsze poszlaki po nastolatkach. W pewnym momencie pod graczem załamuje się stara drewniana podłoga.

Preferowany obecnie wariant:

- gracz spada na poziom niżej, a nie od razu do najgłębszej piwnicy,
- partnerka zostaje wyżej,
- podczas upadku gracz gubi własne radio i broń,
- pozostaje mu latarka i podstawowa apteczka,
- po upadku jest oszołomiony i musi się opatrzyć,
- świadomość, że pod aktualnym poziomem istnieje jeszcze głębsza piwnica, ma zwiększać napięcie.

Pierwszy cel po upadku:

> Spotkaj się z partnerką.

Gracz eksploruje ciemniejszy poziom, otwiera kolejne drzwi i słyszy niepokojące dźwięki. W pewnym momencie słyszy partnerkę wołającą z góry. Chwilę później z wyższego poziomu dochodzi ryk potwora oraz kroki zmierzające w stronę jej głosu.

Po odnalezieniu schodów gracz wraca piętro wyżej, w okolice magazynu / hali produkcyjnej. Widzi partnerkę uciekającą w panice. Następnie słyszy strzały, jej krzyk, wrzask potwora i nagłą ciszę.

Po dalszej eksploracji gracz:

- może znaleźć pierwsze ciało jednego z nastolatków,
- dociera do ciała partnerki,
- zabiera jej broń oraz kluczyki do radiowozu.

Od tego momentu priorytet fabularny zmienia się z akcji ratunkowej na ucieczkę z fabryki.

Pierwotna droga wejścia jest niedostępna z powodu ogromnej wyrwy w podłodze. Drugim realnym wyjściem staje się dok załadunkowy, ale jego brama jest zamknięta grubym łańcuchem.

Plan ucieczki:

- znaleźć narzędzie do przecięcia łańcucha,
- przywrócić część zasilania fabryki,
- uruchomić kątówkę,
- przeciąć łańcuch,
- otworzyć bramę doku,
- dobiec do radiowozu i odjechać.

Na hali produkcyjnej gracz znajduje kątówkę zasilaną przewodowo, więc potrzebuje prądu.

W jednym z biur znajduje ciało nastolatka, który najwyraźniej ukrywał się tam po odniesieniu ciężkich ran. Przy ciele leży telefon z nagraniem pożegnalnym. Nastolatek ostrzega, że w fabryce grasuje bardzo szybka, silna i inteligentna bestia, która poluje na ludzi i po zabiciu ofiar natychmiast zaczyna je pożerać.

W tym samym rejonie gracz znajduje dokument / fakturę dotyczącą paliwa do generatora znajdującego się na najniższym poziomie fabryki.

Gracz schodzi do głębokiej piwnicy. Panuje tam niemal całkowity mrok. Znajduje generator, ale okazuje się, że brakuje paliwa. Panel elektryczny sugeruje, że generator zasila między innymi magazyn.

Gracz wraca do magazynu i przeszukuje regały oraz pudła w poszukiwaniu kanistra. W trakcie przeszukiwania przypadkowo powoduje duży hałas — coś spada z półki albo stary regał częściowo się przewraca.

Hałas przyciąga potwora. Gracz musi się ukryć i przeczekać, obserwując jak stwór przeszukuje magazyn.

Po odnalezieniu paliwa gracz wraca do generatora, uzupełnia go i uruchamia. Generator pracuje bardzo głośno i maskuje dźwięki otoczenia.

W pobliskim korytarzu żarówki zaczynają migać. Na moment wszystkie gasną, a potem rozświetlają się, pokazując sylwetkę potwora na końcu korytarza. Po zauważeniu gracza potwór rusza do ataku.

Gracz musi uciekać, ewentualnie używając broni do chwilowego spowolnienia przeciwnika. Chroni się w pokoju technicznym i zatrzaskuje drzwi. Potwór zaczyna się przez nie dobijać.

Jedyną drogą ucieczki jest kanał wentylacyjny. Gracz wyrywa kratę, wchodzi do środka i czołga się szybem, słysząc za sobą wyważenie drzwi i ryk stworzenia.

Wentylacja prowadzi z powrotem w okolice magazynu / hali.

Po przywróceniu zasilania gracz może użyć kątówki, wraca do doku załadunkowego, podłącza narzędzie do gniazdka i przecina łańcuch.

Finał:

- otwarcie bramy doku,
- ucieczka z fabryki,
- sprint do radiowozu,
- użycie kluczyków partnerki,
- uruchomienie samochodu,
- odjazd z miejsca zdarzenia.

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
- finał z ucieczką do radiowozu,
- ograniczona broń służąca do spowalniania potwora,
- sprawdzanie amunicji przez animację magazynka zamiast klasycznego licznika HUD.

### Na ten moment NIE robimy

- skakania — świadoma decyzja gameplayowa; gracz nie ma mechaniki jump,
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

Broń ma pojawić się dopiero po śmierci partnerki i nie może zmienić gry w shooter.

Przebieg:

- gracz ma własną broń podczas przyjazdu,
- traci ją podczas upadku przez załamaną podłogę,
- przez pierwszą część właściwego horroru pozostaje bez broni,
- po odnalezieniu ciała partnerki zabiera jej pistolet,
- broń służy głównie do odstraszania / chwilowego spowalniania potwora,
- przeciwnika nie da się zabić.

Aktualne założenie amunicji:

- dwa magazynki,
- jeden częściowo zużyty — roboczo około 6 naboi,
- drugi pełny,
- brak klasycznego HUD-u z dokładną liczbą amunicji.

Planowana mechanika sprawdzania amunicji:

- przytrzymanie `G` powoduje wyjęcie magazynka i wizualne sprawdzenie pozostałych naboi,
- gracz ma oceniać zapas na podstawie animacji / wyglądu magazynka zamiast licznika na ekranie.

Dokładna pojemność magazynków, balans i zachowanie broni będą ustalane dopiero przy prototypowaniu combat / enemy interaction.

---

## 6. Układ fabryki

Fabryka ma cztery główne poziomy. Dokładny układ może się jeszcze zmienić podczas blockoutu, ale obecnie preferowany jest wariant, w którym po załamaniu podłogi gracz trafia na poziom -1, a dopiero później świadomie schodzi do najgłębszej piwnicy -2.

### +1 — piętro pod dachem

- stare biura,
- archiwum,
- magazyn,
- pomieszczenie socjalne,
- kładka nad halą,
- widok na główną halę.

### 0 — parter / hala produkcyjna

- wejście przez wybite okno,
- recepcja / portiernia,
- korytarze,
- biura,
- główna hala produkcyjna,
- magazyn,
- dok załadunkowy,
- miejsce załamania podłogi,
- obszar odnalezienia partnerki,
- kątówka potrzebna do finałowej ucieczki.

### -1 — poziom techniczny / poziom po upadku

- miejsce upadku,
- ciemne korytarze,
- warsztat,
- rozdzielnia,
- magazyn części,
- tunele techniczne,
- rury i zawory,
- droga prowadząca z powrotem na parter.

To tutaj rozpoczyna się właściwa samotna eksploracja po rozdzieleniu z partnerką.

### -2 — głęboka piwnica

Najciemniejszy i bardziej klaustrofobiczny poziom.

- generator awaryjny,
- panel bezpieczników,
- pomieszczenie generatora,
- pokój techniczny,
- korytarz prowadzący do sekwencji pościgu,
- kanał wentylacyjny będący drogą awaryjnej ucieczki.

Wejście na -2 powinno być świadomą decyzją gracza podjętą później w fabule, tak aby odkrycie jeszcze głębszego poziomu zwiększało poczucie zagrożenia.

---

## 7. Progres gry

### Akt I — przyjazd i wejście

- nagranie zgłoszenia nastolatków,
- przyjazd radiowozu pod uszkodzoną bramę,
- wejście na teren fabryki pieszo,
- oględziny zamkniętego doku załadunkowego,
- obejście fabryki i parkingu,
- odnalezienie drzwi wejściowych zamkniętych łańcuchem,
- wejście przez wybite okno przy drabinie,
- partnerka gubi radio podczas przechodzenia,
- spokojna eksploracja,
- pierwsze poszlaki po nastolatkach,
- załamanie podłogi pod graczem.

### Akt II — rozdzielenie

- gracz budzi się / dochodzi do siebie po upadku na poziomie -1,
- traci własną broń i radio,
- zostaje mu latarka,
- używa apteczki i opatruje obrażenia,
- otrzymuje cel: spotkać się z partnerką,
- eksploruje ciemny poziom,
- słyszy partnerkę nawołującą z góry,
- słyszy ryk i kroki potwora zmierzającego w jej stronę,
- odnajduje drogę z powrotem na parter.

### Akt III — śmierć partnerki i zmiana celu

- gracz trafia w okolice magazynu / hali produkcyjnej,
- widzi partnerkę uciekającą,
- słyszy strzały, krzyk i odgłosy potwora,
- po drodze może znaleźć pierwsze ciało nastolatka,
- znajduje ciało partnerki,
- zabiera jej pistolet oraz kluczyki do radiowozu,
- droga do pierwotnego wejścia jest odcięta przez zawaloną podłogę,
- nowym głównym celem staje się ucieczka z fabryki.

### Akt IV — plan ucieczki

- gracz dociera do doku załadunkowego,
- stwierdza, że bramę blokuje gruby łańcuch,
- szuka narzędzia do przecięcia łańcucha,
- znajduje przewodową kątówkę na hali produkcyjnej,
- odkrywa, że w fabryce nie ma zasilania,
- dalsza eksploracja prowadzi do biura,
- w biurze znajduje martwego nastolatka i jego telefon,
- odtwarza nagranie pożegnalne / ostrzeżenie o potworze,
- znajduje dokument dotyczący paliwa do generatora,
- dowiaduje się o generatorze na najniższym poziomie.

### Akt V — generator i magazyn

- gracz schodzi do poziomu -2,
- znajduje generator,
- odkrywa brak paliwa,
- panel elektryczny sugeruje powiązanie z magazynem,
- wraca do magazynu,
- przeszukuje regały i pudła w poszukiwaniu kanistra,
- przypadkowo generuje bardzo duży hałas,
- hałas przyciąga potwora,
- gracz musi się ukryć i przeczekać,
- po odejściu stworzenia odnajduje paliwo,
- wraca do generatora,
- uzupełnia paliwo i uruchamia zasilanie.

### Akt VI — pościg i wentylacja

- generator maskuje część dźwięków otoczenia,
- oświetlenie w pobliskim korytarzu zaczyna migać,
- chwilowe rozświetlenie ujawnia potwora na końcu korytarza,
- rozpoczyna się pościg,
- gracz może używać broni do chwilowego spowalniania przeciwnika,
- ucieka do pokoju technicznego i zatrzaskuje drzwi,
- potwór zaczyna się dobijać,
- gracz wyrywa kratę wentylacyjną,
- ucieka szybem,
- słyszy wyważenie drzwi i ryk stwora,
- wychodzi z wentylacji w okolice magazynu / hali.

### Finał — dok i radiowóz

- gracz wraca po kątówkę,
- podłącza ją do działającego gniazdka,
- przecina łańcuch przy bramie doku,
- wydostaje się z fabryki,
- biegnie do radiowozu,
- używa kluczyków partnerki,
- uruchamia samochód,
- odjeżdża.

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

- [x] utworzyć nowy projekt Unity 6 URP
- [x] ustawić repozytorium Git
- [x] dodać `.gitignore` dla Unity
- [x] ustawić `Visible Meta Files`
- [x] ustawić `Asset Serialization = Force Text`
- [x] utworzyć podstawową strukturę folderów
- [x] zrobić pierwszy commit

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

- [x] utworzyć `Prototype.unity`
- [x] podłoga
- [x] ściany
- [x] kamera FPS
- [x] movement
- [x] mouse look
- [x] sprint
- [x] podstawowe kolizje
- [ ] testowy build gry — profil Windows skonfigurowany, ale lokalny build jest obecnie blokowany przez Windows Application Control / Burst

---

## MILESTONE 2 — interakcje

Cel:

> Można wejść do prostego pomieszczenia i wejść w interakcję z obiektami.

- [x] raycast z kamery
- [x] interfejs obiektów interaktywnych
- [x] prompt interakcji
- [x] otwieranie drzwi
- [x] prosty przycisk / przełącznik
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

- [ ] nagranie zgłoszenia nastolatków
- [ ] przyjazd radiowozu pod uszkodzoną bramę
- [ ] partnerka policjantka
- [ ] oględziny doku załadunkowego
- [ ] obejście fabryki i parkingu
- [ ] odnalezienie wejścia przez wybite okno
- [ ] utrata radia przez partnerkę przy wejściu
- [ ] pierwszy dialog / spokojna eksploracja
- [ ] ślady nastolatków
- [ ] event załamania podłogi
- [ ] upadek gracza na poziom -1
- [ ] utrata własnego radia i broni
- [ ] użycie apteczki po upadku
- [ ] objective: spotkaj się z partnerką

Po tym milestone powinna istnieć pierwsza grywalna sekwencja około 5–10 minut.

---

## MILESTONE 6 — rozdzielenie i ponowny parter

- [ ] blockout poziomu -1
- [ ] samotna eksploracja po upadku
- [ ] dźwięki / nawoływanie partnerki
- [ ] pierwszy sygnał obecności potwora
- [ ] droga z -1 na parter
- [ ] sekwencja ucieczki partnerki
- [ ] strzały i śmierć partnerki
- [ ] odnalezienie pierwszego ciała nastolatka
- [ ] odnalezienie ciała partnerki
- [ ] przejęcie broni i kluczyków
- [ ] zmiana głównego celu na ucieczkę z fabryki

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
- [ ] reakcja przeciwnika na postrzał / chwilowe spowolnienie
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
- [ ] dok załadunkowy i łańcuch
- [ ] kątówka
- [ ] biuro z telefonem nastolatka
- [ ] generator i paliwo
- [ ] przeszukiwanie magazynu + hałas
- [ ] pościg przy generatorze
- [ ] ucieczka wentylacją
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
**Ostatnia aktualizacja:** 20.09.2026  
**Aktywny branch produkcyjny:** `feature/interactions`

### Zakończone

- [x] MILESTONE 0 — konfiguracja projektu
- [x] podstawowa scena `Prototype.unity`
- [x] FPS movement
- [x] mouse look
- [x] sprint
- [x] podstawowe kolizje
- [x] konfiguracja profilu builda Windows
- [x] podstawowy system interakcji przez raycast
- [x] interfejs `IInteractable`
- [x] testowy obiekt interaktywny
- [x] prompt interakcji TextMeshPro
- [x] interaktywne drzwi
- [x] interaktywny przełącznik światła
- [x] natychmiastowe odświeżanie promptu po zmianie stanu obiektu

### MILESTONE 1 — stan

Gameplay milestone'u działa w edytorze. Pozostaje ponowić testowy build Windows po rozwiązaniu lokalnego problemu z Burst / Windows Application Control.

### Aktualny milestone

**MILESTONE 2 — interakcje**

Gotowe:

- [x] raycast z kamery
- [x] `IInteractable`
- [x] prompt `[E] ...`
- [x] prompt pojawia się tylko dla aktualnie wykrytego obiektu
- [x] prompt odświeża się po interakcji bez konieczności odwracania wzroku
- [x] `DoorController` — płynne otwieranie i zamykanie drzwi
- [x] `LightSwitch` — przełącznik sterujący innym obiektem `Light`

Do zrobienia:

- [ ] podnoszenie przedmiotu
- [ ] testowy telefon

### Aktualna architektura interakcji

```text
Player
├── CharacterController
├── PlayerInput
├── PlayerController
├── PlayerInteraction
│
└── CameraHolder
    └── Main Camera

Canvas
└── InteractionPrompt
```

Przepływ interakcji:

```text
PlayerInput
    ↓
OnInteract()
    ↓
PlayerInteraction
    ↓
raycast z Main Camera
    ↓
IInteractable
    ↓
Interact()
```

Obecne implementacje `IInteractable`:

```text
TestInteractable
DoorController
LightSwitch
```

Każdy obiekt interaktywny udostępnia własny `InteractionPrompt`.

### Eksperyment — ciemność i latarka

Poza kolejnością milestone'ów wykonano szybki prototyp poruszania się w ciemności z latarką.

Sprawdzone:

- bardzo ciemne `Environment Lighting`,
- wyłączone / ograniczone `Environment Reflections`,
- latarka jako `Spot Light` przypięta do `Main Camera`,
- `FlashlightController`,
- akcja `Flashlight` w Unity Input System,
- przełączanie latarki klawiszem `F`,
- chodzenie po ciemnej scenie z latarką jako głównym źródłem widoczności.

Wniosek:

> Kierunek gameplayowy działa i warto go zachować. Finalne strojenie zasięgu, kąta, intensywności, audio i zachowania latarki zostanie wykonane w MILESTONE 3.

Eksperyment nie oznacza jeszcze ukończenia punktów MILESTONE 3.

### Ustalone decyzje

- gracz nie ma mechaniki skoku,
- ruch gracza używa `CharacterController`,
- input korzysta z Unity Input System i `PlayerInput`,
- `PlayerInput` działa w trybie `Send Messages`,
- interakcje są oparte o wspólny interfejs `IInteractable`,
- raycast interakcji wychodzi z `Main Camera`,
- bazowy zasięg interakcji to 3 m,
- prompt jest UI na `Canvas`, a nie tekstem 3D w świecie,
- prompt TextMeshPro nie jest przepisywany co klatkę,
- po wykonaniu interakcji prompt jest wymuszanie odświeżany, aby od razu pokazać nowy stan obiektu,
- drzwi obracają się przez osobny obiekt pełniący rolę zawiasu,
- przełącznik może sterować innym GameObjectem przez referencję ustawioną w Inspectorze,
- finalna gra ma wykorzystywać ciemność i latarkę jako ważny element eksploracji i napięcia,
- planowany jest set piece w magazynie, w którym hałas wywołany podczas przeszukiwania regałów przyciąga potwora; ma on wykorzystać przyszłe systemy audio triggerów i `EnemyHearing`.
- upadek po załamaniu podłogi ma obecnie prowadzić na poziom -1; najgłębsza piwnica -2 zostaje odkryta później,
- partnerka ginie przed połową / w środkowej części gry, a gracz przejmuje jej broń i kluczyki do radiowozu,
- broń nie zabija potwora — służy tylko do jego chwilowego spowalniania,
- brak klasycznego licznika amunicji w HUD; planowane jest sprawdzanie magazynka po przytrzymaniu `G`,
- finałowa droga ucieczki prowadzi przez dok załadunkowy, którego łańcuch trzeba przeciąć przewodową kątówką po przywróceniu zasilania,
- telefon z nagraniem pojawia się dopiero później w fabule, przy ciele nastolatka ukrywającego się w biurze.

### Znane problemy

- lokalny build Windows był blokowany przez Windows Application Control podczas ładowania `Burst.Compiler.IL`,
- błąd dotyczy środowiska / Burst, a nie kodu gameplayowego,
- do ponownego sprawdzenia po naprawie środowiska.

### Następne zadanie

Wrócić do MILESTONE 2 i dodać proste podnoszenie przedmiotu, a następnie testowy telefon z nagraniem.

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

---

## 2026-09-19

### Zrobione

- zakończono MILESTONE 0,
- zbudowano grywalny prototyp ruchu FPS,
- dodano chodzenie, mouse look i sprint,
- skonfigurowano profil builda Windows,
- utworzono branch `feature/interactions`,
- dodano `IInteractable`,
- dodano `PlayerInteraction`,
- dodano raycast interakcji z kamery,
- dodano testowy obiekt `Test_Interactable`,
- dodano prompt interakcji w TextMeshPro,
- zoptymalizowano prompt tak, aby UI aktualizowało się tylko po zmianie wykrytego obiektu.

### Zmienione decyzje

- gracz nie będzie posiadał mechaniki skoku,
- wszystkie standardowe interakcje mają korzystać ze wspólnego interfejsu `IInteractable`,
- tekst promptu jest dostarczany przez konkretny obiekt interaktywny,
- UI promptu działa w `Screen Space - Overlay`.

### Problemy

- pierwszy build Windows został zablokowany przez Windows Application Control podczas ładowania biblioteki `Burst.Compiler.IL`,
- problem pozostaje do ponownego przetestowania po naprawie środowiska.

### Następne zadanie

Dodać `DoorController` implementujący `IInteractable` i stworzyć pierwsze drzwi otwierane / zamykane klawiszem `E`.

---

## 2026-09-19 — sesja 2

### Zrobione

- dodano `DoorController` implementujący `IInteractable`,
- dodano płynne otwieranie i zamykanie drzwi,
- dodano dynamiczny prompt `Otwórz drzwi / Zamknij drzwi`,
- dodano `LightSwitch` sterujący komponentem `Light`,
- dodano dynamiczny prompt `Włącz światło / Wyłącz światło`,
- poprawiono odświeżanie promptu po zmianie stanu interaktywnego obiektu,
- wykonano eksperymentalny test bardzo ciemnego wnętrza,
- wykonano prototyp latarki jako `Spot Light` przy `Main Camera`,
- dodano testowe sterowanie latarką klawiszem `F`,
- potwierdzono, że eksploracja ciemnej sceny z latarką jest właściwym kierunkiem dla gry.

### Zmienione decyzje

- przed dokończeniem MILESTONE 2 wykonano celowy, krótki eksperyment z latarką,
- eksperyment nie zmienia kolejności produkcji: wracamy do MILESTONE 2,
- finalne strojenie latarki zostaje na MILESTONE 3.

### Problemy

- brak nowych problemów blokujących gameplay,
- eksperymentalny branch latarki nie jest jeszcze widoczny w zdalnym repozytorium GitHub.

### Następne zadanie

Dodać proste podnoszenie przedmiotu, a potem testowy telefon z nagraniem i zamknąć MILESTONE 2.

### Nowy pomysł fabularno-gameplayowy

- zaplanowano sekwencję w magazynie: gracz przeszukuje regały i pudła w poszukiwaniu konkretnego przedmiotu,
- podczas przeszukiwania przypadkowo strąca coś z półki i generuje duży hałas,
- hałas przyciąga potwora i rozpoczyna dynamiczną sekwencję napięcia,
- dokładne umiejscowienie w akcie gry zostanie ustalone później.

---

## 2026-09-20 — aktualizacja fabuły

### Zmieniono przebieg historii

- doprecyzowano wejście na teren fabryki i pierwszą eksplorację,
- dok załadunkowy jest pokazany graczowi już na początku jako potencjalne wyjście,
- wejście do fabryki prowadzi przez wybite okno obok zamkniętych łańcuchem drzwi,
- partnerka gubi radio podczas wejścia,
- po załamaniu podłogi gracz trafia preferencyjnie na poziom -1 zamiast od razu do najgłębszej piwnicy,
- gracz podczas upadku traci własne radio i broń,
- po śmierci partnerki przejmuje jej pistolet i kluczyki do radiowozu,
- główny cel zmienia się z odnalezienia partnerki na ucieczkę z fabryki,
- droga ucieczki prowadzi przez zamknięty dok załadunkowy,
- do przecięcia łańcucha potrzebna jest przewodowa kątówka,
- przywrócenie prądu wymaga generatora i paliwa,
- telefon z nagraniem pożegnalnym nastolatka pojawia się dopiero w późniejszej części gry,
- przeszukiwanie magazynu w poszukiwaniu paliwa powoduje hałas przyciągający potwora,
- po uruchomieniu generatora następuje sekwencja ujawnienia potwora, pościgu i ucieczki wentylacją,
- finał prowadzi przez dok do radiowozu.

### Broń

- przeciwnika nie da się zabić,
- broń służy do chwilowego spowalniania potwora,
- planowane są dwa magazynki,
- brak dokładnego licznika amunicji w HUD,
- przytrzymanie `G` ma służyć do wizualnego sprawdzenia stanu magazynka.

### Następne zadanie produkcyjne

Kontynuować odbudowę minimalnej sceny testowej i domknąć MILESTONE 2 przez działający system podnoszenia przedmiotów.
