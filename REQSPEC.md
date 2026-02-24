# Követelmény specifikáció

A cél egy olyan automatizált, e2e megoldás létrehozása, fejlesztéstől a telepítésig, amely a következőket tartalmazza:

**Alapkövetelmény:**

1. Alkalmazás, egyszerűbb domain modellel.
2. Az alkalmazás modulok (frontend, backend) konténerizálása.
3. CI workflow létrehozása, amely automatikusan buildeli és feltölti az alkalmazásból készült docker image-eket egy registry-be (pl.: ghcr.io).
4. Kubernetes manifest fájlok létrehozása a konténerek futtatásához, melyek használják az előzőleg feltöltött image-eket.
5. Telepítési útmutató készítése, amely bemutatja, hogyan lehet a rendszert helyi Kubernetes klaszteren telepíteni.
6. Egyszerű user guide készítése, amely bemutatja, hogyan lehet használni a rendszert, és annak minden funkcióját.

A referencia architektúra a megfelelő draw.io fájlban található, amely részletesen bemutatja a rendszer javasolt komponenseit és azok kapcsolatait. 

<ins>A javaslatok:</ins>
- Frontend: Angular 21  - Typescript
- Backend: ASP.NET 10   - C#
- Adatbázis: MongoDB 8

A javaslatoktól eltérő technológiák használata is megengedett saját felelősségre, amennyiben azok a végső megoldásban jól dokumentáltak. <br />
Az alapkövetelmények betartása minden osztályzatnál kötelező! <br />
Ezek alapján az osztályzatok a következőképpen alakulnak:

**Kettes:**
- Egyetlen komponens elkészítése a következők szerint:
  - Vagy csak a frontend modul elkészítése mainstream framework használatával: benne 2 view szállítása pagination implementálásával, saját backend helyett a [The Rick and Morty API](https://rickandmortyapi.com/) OpenAPI integrációval. Csak azoknak akik a kettesre lőnek, itt kötelező egy CSS framework integráció is!
  - Vagy csak a backend modul elkészítése monolitként,  mainstream framework használatával: benne egy CRUD-os Restful API implementálásával, adatbázis kapcsolattal, amely egy egyszerű domain modellt használ (pl. könyvek, filmek, stb.), továbbá request minták készítése egy `.http` fájlban, lefedve minden CRUD műveletet. Telepítési útmutató kiegészítése adatbázis helm charttal.

**+1 jegy:**
- Mindkét fenti komponens elkészítése és összekötése.

**+1 jegy:**
- A backend microservice architektúrában történő megvalósítása, és kiegészítve saját MCP szerver implementációval, mint független backend komponens.

**+1 jegy:**
- CD workflow megvalósítása ArgoCD segítségével. Ezen a szinten a telepítési útmutatóban elegendő az ArgoCD manuális telepítését dokumentálni, a többi komponensnek automatikusan kell mennie.
