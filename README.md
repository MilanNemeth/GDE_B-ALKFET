# B-ALKFET - Alkalmazásfejlesztési technológiák
A mindenkori legfrissebb verzió elérhető [GitHub](https://github.com/MilanNemeth/GDE_B-ALKFET)-on.

## Tanulási segédlet
A világ és az IT szektor is gyorsan változik. Kulcsfontosságú tehát, hogy gyorsan és hatékonyan tanuljunk. Kellő tapasztalattal, fejlesztőként, egy új technológiát gyorsan el kell tudni  sajátítani.

Javasolt a következő módszertan alkalmazása, az alkalmas eszközök megjelölésével:
1. **Álljon össze a "big picture" (jegyzet, kurzus, önálló tevékenység).** <br />
    Alkalmazásfejlesztési technológiák esetén meg kell határozni annak minden alterületét, hogy le tudjuk szűkíteni a scope-ot, amivel foglalkozni szeretnénk.
2. **Vegyük a nagy témát, és szűkítsük le egy kisebb, racionális méretű területre, ami még érdekel is (jegyzet, kurzus, önálló tevékenység).** <br />
    Például: Játékfejlesztés, webfejlesztés, IoT fejlesztés, stb.
3. **Határozzuk meg a siker definícióját (kurzus, önálló tevékenység).** <br />
    Ennek a végére meg kell fogalmazódjon egy viszonylag rövid és tömör állítás arról, hogy hova szeretnénk eljutni. Pl.: "High-end single-player FPS játék készítése Unreal Engine használatával."
4. **Keressünk forrásokat, amelyek segíthetnek elérni a kitűzött célt (jegyzet, kurzus, önálló tevékenység).** <br />
    Ezek lehetnek: könyvek, blogok, online kurzusok, YouTube videók, podcast adások, stb. Fontos, hogy megbízható és releváns forrásokat válasszunk, amik jól illeszkednek a tanulási stílusunkhoz. Nézzük meg a rendelkezésre álló visszajelzéseket (lájkok, review-k, hozzászólások), hogy meg tudjuk ítélni a forrás minőségét objektíven, de mérlegeljük a szubjektív benyomásainkat is.
5. **Készítsünk tanulási tervet, ami igazodik az aktuális tudásszintünkhöz (önálló tevékenység).** <br />
    Fontos, hogy a tanulási terv reális és megvalósítható legyen. Osszuk fel a tanulási folyamatot kisebb, kezelhető részekre, és határozzunk meg konkrét időkereteket a tanulásra. 
6. **Szűrjük meg a forrásokat úgy, hogy azok a legjobban igazodjanak a tanulási tervhez (önálló tevékenység).** <br />
    Állítsunk fel egy sorrendet a tanulási források között, és szelektáljuk ki azokat, amik túl nagy részletességel taglalják a témát.Részesítsük előnyben a hands-on forrásokat, ahol lehetőség van gyakorlat közben megismerni a területet (pl.: rövidebb online kurzusok, kb. 1-1,5 órás crash-course videók). A hatalmas, száraz, elméleti anyagokat hagyjuk meg a későbbi szakaszokra, amikor már van egy jó alapunk, és egy célzott probléma megoldására keresünk precíz választ (pl.: vastag könyvek, hatalmas technikai dokumentációk). Még soha senki nem sajátított el új készséget a dokumentáció végigolvasásával!
7. **Tanuljunk épp eleget, ami minimálisan elégséges ahhoz, hogy tudjunk csinálni valamit a gyakorlatban (önálló tevékenység).** <br />
    Fontos, hogy minél előbb billentyűzetet ragadjunk, és bepiszkoljuk a kezünket. A tanulás nem egy passzív folyamat, hanem egy aktív, gyakorlati tevékenység. Minél előbb elkezdünk gyakorolni, annál gyorsabban fogunk fejlődni.
8. **Kezdjünk el játszani az új technológiával (önálló tevékenység).** <br />
    Szórakozzunk, kísérletezzünk, próbáljuk ki, hogy az elképzeléseink/feltételezéseink megállnak-e a gyakorlatban is. Hibázzunk, és tanuljunk a hibákból, mert a sikerekből biztosan nem fogunk! A játékosság segít fenntartani a motivációt, és lehetővé teszi, hogy kreatív módon fedezzük fel az új technológiát. Próbáljunk ki mindent ami eszünkbe jut, és járunk utána a váratlan eredményeknek.
9. **Folytassuk a tanulást azzal a fókusszal, hogy valami hasznosat tudjunk csinálni (önálló tevékenység).** <br />
    Ha kijátszottuk magunkat, erősítsük meg az így megszerzett gyakorlati tudást még egy kis elmélettel, amit így már lesz hova tenni. Amint elég tudásunk van ahhoz, hogy valami hasznosat csináljunk, kezdjünk el dolgozni egy projekten, ami érdekel minket. Ez lehet egy személyes projekt, egy open-source hozzájárulás, vagy akár egy munkahelyi feladat. A lényeg, hogy alkalmazzuk a tanultakat a gyakorlatban, és folyamatosan fejlesszük a készségeinket.
10. **Tanítsunk! Adjuk tovább a tudást (kurzus, önálló tevékenység).** <br />
    A tanítás az egyik leghatékonyabb módja annak, hogy elmélyítsük a saját tudásunkat. Amikor megpróbáljuk elmagyarázni egy másik embernek, hogy hogyan működik valami, akkor kénytelenek vagyunk rendszerezni a tudásunkat, és tisztázni a fogalmakat. Ez segít abban, hogy jobban megértsük a témát, és észrevegyük az esetleges vakfoltjainkat. Emellett a tanítás lehetőséget ad arra is, hogy kapcsolatba lépjünk másokkal, akik hasonló érdeklődésűek, és hogy közösen tanuljunk és fejlődjünk.

## Container technológiák

### Docker

#### Bevezetés
A Docker egy nyílt forráskódú platform, amely lehetővé teszi a fejlesztők számára, hogy alkalmazásokat és szolgáltatásokat konténerekben csomagoljanak, szállítsanak és futtassanak. A Docker konténerek könnyűek, hordozhatóak és gyorsan indíthatóak, ami megkönnyíti az alkalmazások fejlesztését, tesztelését és üzemeltetését különböző környezetekben. A Docker használatával a fejlesztők biztosíthatják, hogy az alkalmazásuk ugyanúgy működjön a fejlesztői gépen, a tesztkörnyezetben és a gyártási környezetben is, minimalizálva a "works on my machine" problémákat.
A [nyílt konténer specifikációknak](https://notes.kodekloud.com/docs/Kubernetes-and-Cloud-Native-Associate-KCNA/Cloud-Native-Architecture/Open-Standards/page) köszönhetően, mára számos alternatíva létezik. 
Ezek közül néhány a teljesség igénye nélkül:
 - [Podman](https://docs.podman.io/en/latest/): egy démon nélküli konténer runtime, ahol K8s mintájára, podokba csomagolhatók a konténerek.
 - [Containerd](https://containerd.io/): konténer runtime névtér támogatással.
 - [gVisor](https://gvisor.dev/): egy konténer runtime, amely kernel funkciók helyett virtualizációval biztosít szigorúbb process izolációt.
 Egyenlőre nem érdemes a fentiekben túlzottan elmélyedni, de érdemes tudni, hogy léteznek, és hogy a Docker nem az egyetlen megoldás a konténerizációra.

#### Konténerizáció vs Virtualizáció
A konténerizáció és a virtualizáció két különböző technológia, amelyek célja az alkalmazások izolálása és futtatása különböző környezetekben, de [eltérő módon működnek](https://www.atlassian.com/microservices/cloud-computing/containers-vs-vms).
- **Virtualizáció**: A virtualizáció során egy fizikai gépen több virtuális gépet (VM) hozunk létre, amelyek mindegyike saját operációs rendszert futtat. Minden VM egy teljes operációs rendszer példányt tartalmaz, ami jelentős erőforrásokat igényel. A virtualizáció lehetővé teszi, hogy különböző operációs rendszereket futtassunk ugyanazon a fizikai gépen, de a VM-ek közötti kommunikáció és erőforrásmegosztás lassabb, mint konténerizáció esetén. Fő komponense a hypervisor, amely a VM-eket kezeli és izolálja egymástól.
- **Konténerizáció**: A konténerizáció során az alkalmazásokat és azok függőségeit egy konténerbe csomagoljuk, amely ugyanazt az operációs rendszert használja, mint a host gép. A konténerek könnyűek, hordozhatóak és gyorsan indíthatóak, mivel nem futnak teljes operációs rendszer példányt, hanem közvetlenül a host gép operációs rendszerére építenek. Fő komponense a konténer runtime, amely a konténerek létrehozásáért, futtatásáért és kezeléséért felelős.

#### Docker komponensek
- **Docker Engine**: Ez a Docker alapja, amely egy kliens-szerver architektúrában működik. A Docker Engine egy démon (dockerd), ami a háttérben futó backend, és kezeli a konténereket. A CLI (docker) pedig a frontend, amely lehetővé teszi a felhasználók számára, hogy parancsokat küldjenek a démonnak. Ezt használjuk imagek létrehozására, konténerek indítására, leállítására, stb.
- **Docker Hub**: Nyilvános container registry, ahol a fejlesztők megoszthatják egymással és letölthetik a Docker imageket. A Docker Hub lehetővé teszi a felhasználók számára, hogy könnyen hozzáférjenek előre elkészített imagekhez, vagy megosszák sajátjaikat a közösséggel.

#### Konténer komponensek
- **Dockerfile**: Egy Dockerfile egy szöveges fájl, vagy image blueprint, amely jól verziókezelhető, és tartalmazza a lépéseket, amelyek szükségesek egy Docker image létrehozásához. A Dockerfile-ban meghatározhatjuk az alap image-t, a szükséges csomagokat, a környezeti változókat, a parancsokat, amelyek futtatásra kerülnek a konténer indításakor, és egyéb konfigurációkat. Docker image készítése Dockerfile használatával a legegyszerűbb. [Dockerfile reference](https://docs.docker.com/reference/dockerfile/)
- **Image**: Egy image egy statikus fájlrendszer, vagy container blueprint, amely tartalmazza az alkalmazást és annak összes függőségét. Az image egy előre definiált állapotot képvisel, amelyből konténereket lehet létrehozni.
- **Container registry**: Egy remote tárolóhely (pl.: Docker Hub, GHCR, ACR, stb...), ahol a Docker image-eket tárolják és osztják meg. Docker esetén Docker Hub a default container registry.
- **Container**: Egy konténer egy futó példánya egy adott image-nek.

#### Gyakori Docker parancsok

##### docker build
Docker image létrehozása egy Dockerfile alapján.
`docker build -t <image-név:tag> -f <dockerfile-útvonala> <egyéb-argumentumok> <build-context>`
- image-név:tag: Az image neve és opcionális tag-je (pl.: "myapp:latest"). Ha a tag-et nem adjuk meg, akkor "latest" lesz az alapértelmezett.
- dockerfile-útvonala: A Dockerfile helye a fájlrendszeren. Ez lehet egy relatív vagy abszolút útvonal. Elhagyható, amennyiben az aktív working directory-ben van egy "Dockerfile" nevű fájl. Ez az alapértelmezett viselkedés.
- egyéb-argumentumok: Opcionális argumentumok, amelyek a build folyamatot befolyásolják. Például:
  - `--no-cache`: Nem használ cache-t a build során, így minden réteget újra létrehoz.
  - `--build-arg`: Build argumentumokat adhatunk át a Dockerfile-nak, amelyeket a Dockerfile-ban `ARG` utasítással használhatunk.
- build-context: Az az útvonal, amely a Dockerfile-ban megadott fájlokhoz és könyvtárakhoz való hozzáférést biztosít. Ez általában a Dockerfile helye, de lehet egy másik könyvtár is, ha a Dockerfile-ban megadott fájlok ott találhatók.
Példák: 
- `docker build -t myapp:latest -f ./Dockerfile .`
- `docker build -t myapp:latest .` (a `.` jelzi az aktuális könyvtárat)
- `docker build -t myapp:latest ..` (a `..` jelzi a parent könyvtárat)
- `docker build -t myapp:latest ./my-service`
- `docker build -t myapp:latest ../my-service`

[Docker build reference](https://docs.docker.com/build/)

##### docker run
Egy új konténer indítása egy adott image-ből.
`docker run <egyéb-argumentumok> <image-név:tag> <opcionális-parancs>`
- egyéb-argumentumok: Opcionális argumentumok, amelyek a konténer futtatását befolyásolják. Például:
  - `-d` vagy `--detach`: A konténert háttérben futtatja, és visszaadja a konténer ID-jét.
  - `-p` vagy `--publish`: Portokat mappel a host gép és a konténer között (pl.: `-p 8080:80`). Lehetővé teszi, hogy a konténerben futó szolgáltatások elérhetőek legyenek a host gépen, vagy akár a helyi hálózaton keresztül.
  - `-v` vagy `--volume`: Könyvtárakat vagy fájlokat csatol a host gépről a konténerbe, vagy docker volume-ot mountol a konténerbe (pl.: `-v /host/path:/container/path`). [Volume reference](https://docs.docker.com/engine/storage/volumes/) vs [Bind mounts reference](https://docs.docker.com/engine/storage/bind-mounts/)
  - `-e` vagy `--env`: Környezeti változókat adhatunk át a konténernek (pl.: `-e ENV_VAR=value`).
  - `--name`: Nevet adhatunk a konténernek, ami megkönnyíti a későbbi hivatkozást rá (pl.: `--name my-container`).
  - `--rm`: A konténer automatikusan törlődik, amikor leáll.
- image-név:tag: Az image neve és opcionális tag-je, amelyből a konténert létrehozzuk (pl.: "myapp:latest").
- opcionális-parancs: Opcionális parancs, amelyet a konténer indításakor futtatni szeretnénk. Ha nem adunk meg parancsot, akkor a konténer az image-ben definiált alapértelmezett parancsot fogja futtatni.
Példák:
- `docker run -d -p 8080:80 --name my-container myapp:latest`
- `docker run -e ENV_VAR=value myapp:latest`

[Docker run reference](https://docs.docker.com/reference/cli/docker/run/)

##### Egyéb hasznos Docker parancsok
- `docker ps`: Futó konténerek listázása.
- `docker start`|`docker restart`|`docker stop`: Konténer indítása, újraindítása vagy leállítása.
- `docker rm`: Egy konténer törlése.
- `docker rmi` vagy `docker image rm`: Egy Docker image törlése.
- `docker pull`: Egy Docker image letöltése egy container registry-ből.
- `docker push`: Egy Docker image feltöltése egy container registry-be.
- `docker logs`: Egy konténer logjainak megtekintése.
- `docker exec`: Parancs futtatása egy futó konténerben.
- `docker inspect`: Egy konténer vagy image részletes információinak megtekintése.
- `docker save`: Egy Docker image mentése `.tar` fájlba, ha mondjuk nem registry-ben szeretnénk megoszatni.
- `docker load`: Egy Docker image betöltése egy `.tar` fájlból.
- `docker commit`: Egy futó konténer állapotának mentése egy új Docker image-ként.
- `docker tag`: Egy Docker image új címkézése, ami hasznos lehet a registry-kbe való feltöltés előtt.
- `docker network`: Docker hálózatok kezelése.
- `docker volume`: Docker kötetek kezelése.

### Container Orchestration - Kubernetes (k8s)
