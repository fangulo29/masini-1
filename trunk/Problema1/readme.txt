Programul contine 7 clase, dintre care 2 abstracte (Persoana & Car). Cele doua sunt clase de baza pentru clasele 
Seller & Client, respectiv Sedan & Coupe (nu am implementat si clasa Mini). 
Clasa Seller contine o lista de obiecte de tipul Client pe care le gestioneaza. Astfel, un Client nou poate fi adaugat in lista,
sau unui Client vechi i se pot modifica datele. 
Clasa CarsPool contine o lista de obiecte de tipul Car care reprezinta totalitatea masinilor cerute.Daca doi clienti
vor solicita acelasi tip de masina, doar pentru prima masina se va apela constructorul de instantiere, iar instanta va fi 
adaugata in lista. 
Clasa Client contine o lista de obiecte de tipul Car, cu instante pentru fiecare masina detinuta de clientul respectiv.
 Daca un Client nou doreste sa cumpere o masina, modelul dorit este mai intai cautat in pool (instanta privata statica a 
clasei CarsPool), si, in functie de rezultat, creat sau doar referit. 