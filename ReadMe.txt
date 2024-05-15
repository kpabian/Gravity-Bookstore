1.Utwórz metodê kontrolera zwracaj¹c¹ ksi¹¿ki w danym jêzyku:
/api/orders/books?language=<value>
Ka¿da ksi¹¿ka powinna byæ zwracana w postaci JSON:
{
    "id": 0,
    "title": "string",
    "isbn": "string",
    "copiesSold": 0
  }
gdzie copiesSold jest liczb¹ sprzedanych egzemplarzy danej ksi¹¿ki (informacja znajduje siê w tabeli order_line).
2. Zdefiniuj metodê pracuj¹c¹ pod œcie¿k¹: /api/orders/{id}, któr¹ mo¿na zmieniaæ status zamówienia o podanym id:
{
    "status": string
}
Lista poprawnych nazw statusów znajduje siê w tabeli order-status. Zmiana statusu odbywa siê wg regu³:
dla statusów o id od 1 do 3, mo¿na zmieniæ na status o numerze wy¿szym. np. 1 na 2, 2 na 3, 3 na 4.
Przejœcie do statusu 5 i 6 jest mo¿liwe tylko dla zamówienia o statusie 3.
Ka¿da zmiana statusu zamówienia wymaga automatycznego dodania dok³adnego czasu zmiany (kolumna status_date).
Ka¿da inna zmiana powoduje zwrócenie odpowiedzi z b³êdem ¿¹dania.
3. Utwórz projekt testu integracyjnego, podmieñ rzeczywist¹ bazê na bazê InMemory i zdefiniuj metodê testow¹ do poprzedniego zadania. Przetestuj dwa przypadki: przes³anie poprawnej zmiany statusu i b³êdnej zmiany statusu.
 
 
