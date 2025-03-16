# **User Authentication System v C#**

Tento projekt je hodně jednoduchá aplikace pro správu uživatelů s přihlašováním, správou účtů a administrací. Data uživatelů jsou ukládána do XML souboru.

Funkce aplikace
- Přihlášení uživatele (ověřování hesla)
- Různá rozhraní pro uživatele a admina
  - Uživatel: Může si pouze změnit heslo
  - Admin: Může spravovat uživatele (přidávat, mazat, resetovat hesla)
- Ukládání a načítání uživatelů z XML
- Hashování hesel pro vyšší bezpečnost

Struktura aplikace
Aplikace obsahuje následující formuláře:
- Form1.cs – Přihlašovací okno
- Form2.cs – Uživatel: změna hesla
- Form3.cs – Admin: správa uživatelů
- Form4.cs – Dialog pro změnu hesla

A hlavní třídy:
- User.cs – Definice uživatele
- UserManager.cs – Správa uživatelů, práce s XML

Jak spustit projekt
1. Otevřete projekt v Visual Studio 2022
2. Sestavte a spusťte projekt pomocí klávesy F5
3. Přihlaste se jako uživatel nebo admin.
4. Admin může spravovat účty v admin panelu.

Přidání nového uživatele
1. Admin přejde do svého panelu
2. Vyplní uživatelské jméno, heslo a zaškrtne, zda jde o admina
3. Klikne na Přidat uživatele

Resetování hesla
1. Admin vybere uživatele ze seznamu
2. Klikne na Resetovat heslo – nové heslo bude newpassword
