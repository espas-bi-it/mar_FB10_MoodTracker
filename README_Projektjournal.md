# Projektjournal

Das Projektjournal enthält die Dokumentation zum Fachblock.

**Richtlinie für das Projektjournal:**

- Logbuchname: `README_Projektjournal.md`  
- Bearbeitete Themen  
- Screenshots vom Fortschritt  
- Notizen zu Herausforderungen und Blockaden  
- Code / Library / Funktion Erklärungen *(Code-Kommentare)*  
- Vorstellung des relevanten Quellcodes  
- Reflexion: Diskussion zentraler Herausforderungen und Lösungsansätze
- Datum der Einträge (zeitlichen Verlauf nachvollziehbar)

---

# FW 10.1 API 2025 – Android-App erstellen 19.06.2025

## Phase 1: Setup & Initialisierung 

## 1. Visual Studio & Emulator installieren und einrichten

![Bild 2](https://github.com/user-attachments/assets/20d99aa0-6a65-486f-ae74-329d37133e86)  
![Bild 1](https://github.com/user-attachments/assets/89d5fd13-c6db-4312-beb9-c5706390c5c1)

## 2. Android-App erstellen 20.06.2025

### Erste Applikation: Hello World

![Bild 3](https://github.com/user-attachments/assets/36651b75-e03d-4522-99f6-ddd191c5791a)

---

# FW 10.1 API 2025 – Mockup erstellen 25.06.2025

## Phase 2: Planung

- Projektname angepasst

  ![image](https://github.com/user-attachments/assets/659e3803-0f65-40c8-894a-0bb0861cabb4)


- Seite erstellt (Angebote + Feedbackbereich) - Input von Herr Kienast (Effizienz) 26.06.2025
  
![image](https://github.com/user-attachments/assets/81d40352-2390-44bd-a8f7-c97d6679a196)

- Wireframe der Seite

![image](https://github.com/user-attachments/assets/47fafa55-168b-4913-a78c-04e09149253c)

- Wireframe --> Mockup: 1. Kurs erstellt (provisorisch als Vorlage) so oft kopiert und eingefügt dass die Anzahl der Kurse abgedeckt ist 27.06.2025

![image](https://github.com/user-attachments/assets/0867db64-baf5-4b7c-801c-93c713b5ea77)

- Gruppe erstellt um eine bessere Übersicht zu haben

![image](https://github.com/user-attachments/assets/49e8503e-e7bd-4632-a04c-e977e938a15c)

- Bei allen Vorlagen bereits die Gruppe erstellt mit passendem Namen

![image](https://github.com/user-attachments/assets/63b6ae9f-e131-42e0-bcba-a4a689cf63fe)

- Über Prototype "Andoid Compact" hinzugefügt (Frame) und den vorhandenen Content der Grösse angepasst

![image](https://github.com/user-attachments/assets/8ff18337-12b3-476b-9ead-a72c7690e688)

- Auf "Starten" gedrückt

  ![image](https://github.com/user-attachments/assets/cb47d625-b2f2-42f3-9558-4cae8216fb2d)

- Button bei den vorhandenen Workshops hinzugefügt (es steht drauf "Bewerten"), dieser soll auf der gleichen Seite zum Feedbackbereich führen (mit Scroll-Effekt) wo der Workshop mit den Infos steht wann er stattgefunden hat

![image](https://github.com/user-attachments/assets/9cd858c0-7601-41d8-8fd5-67b410460aaa)

- Feedbackbereich mit den Infos wann der Workshop/Kurs stattgefunden hat mit Möglichkeit zur Bewertung (in welcher Form muss ich noch entscheiden) und einem "Zurück" Button welcher mit Scroll-Effekt zurück führt (Ursprung vom gedrückten Button)

![image](https://github.com/user-attachments/assets/c67c403a-45a4-4810-b7fc-c258ba654923)

---

### Zwischenstand: Noch Beschreibung der jeweiligen Kurse vervollständigen, Infos wann der Kurs stattgefunden hat beim Feedbackbereich einfügen und für die Bewertungsform entscheiden (vllt noch Feld wo man Feedback schreiben kann)

## UML Klassendiagramm 03.07.2025

![image](https://github.com/user-attachments/assets/8c325ebc-73c3-4b31-83d0-4472c6dcd2cc)

## Formular/Validationen 03.07.2025

# Formular

- Name (name) (Textfeld)
- Bewertung (rating); (Punkte Auswahl (Farbspektrum dunkel rot - dunkel grün))
- Kommentar (comment); optional

# Validationen (Überprüfungen)

- Name = Pflichtfeld - Darf nicht leer sein
- Bewertung = Pflichtfeld - Nur Werte von 1 bis 5 erlaubt
- Kommentar = Optional - Maximal 400 Zeichen
- Feedback = enabled == true, dann darf hint nicht leer sein

## Phase 3: Umsetzung 04.07.2025

- ChatGPT nach Schritt für Schritt Anleitung gefragt

1. Visual Studio 2022 geöffnet
2. Neues Projekt erstellt .NET MAUI
3. Speicheort = C: (Lokal)  <-- Empfehlung von Ihnen

---

### Programmierstart 10.07.2025

1. Mit Hilfe von Benjamin Smith habe ich die Grundlage der Werbseite erstellt, und die Datei MoodTrackerDaten.json implementiert (im Verzeichnis Raw)
2. Benjamin Smith hat mir gezeigt wie ich mit Hilfe von GitHub Copilot arbeiten kann;

- GitHub Copilot öffnen und bei der Auswahl auf "Lösung" klicken und dann die gewünschte Anweisung schreiben; Bei der Antwort (Code) auf "Anwenden" klicken und zum den Code effektiv zu übernehmen auf die TAB-Taste klicken

3. Ich habe dann mit Hilfe von Copilot versucht mein Mockup bestmöglich zu programmieren

<img width="362" height="937" alt="image" src="https://github.com/user-attachments/assets/ef1abb16-02ff-4af1-9614-6f973c44b928" />

<img width="356" height="518" alt="image" src="https://github.com/user-attachments/assets/b9f02298-973c-4de2-a254-64769d74dc83" />

<img width="342" height="521" alt="image" src="https://github.com/user-attachments/assets/ae8b93fb-c88c-497d-8535-51ecea878a66" />

<img width="348" height="529" alt="image" src="https://github.com/user-attachments/assets/fcf62fba-c2ae-4b72-b60b-9941b4f2b62b" />

<img width="334" height="524" alt="image" src="https://github.com/user-attachments/assets/b184b1d0-9cf5-443d-8433-520a66f55372" />

<img width="370" height="529" alt="image" src="https://github.com/user-attachments/assets/20c89c09-9396-46cc-bbac-594984642897" />

<img width="352" height="519" alt="image" src="https://github.com/user-attachments/assets/1b26f5f3-2d26-40d8-b0fa-8aa257c9b6f2" />

<img width="350" height="524" alt="image" src="https://github.com/user-attachments/assets/42a6737e-0e4f-4cae-bd86-7f87475d502d" />

# Schwierigkeiten

Beim programmieren des Buttons hat plötzlich mein ganzer Code nicht mehr funktioniert und ich habe es noch nicht geschafft das erfolgreich umzusetzen



