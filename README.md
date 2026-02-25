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
    Állítsunk fel egy sorrendet a tanulási források között, és szelektáljuk ki azokat, amik túl nagy részletességel taglalják a témát.Részesítsük előnyben a hands-on forrásokat, ahol lehetőség van gyakorlat közben megismerni a területet (pl.: rövidebb online kurzusok, max kb. 1 órás crash-course videók). A hatalmas, száraz, elméleti anyagokat hagyjuk meg a későbbi szakaszokra, amikor már van egy jó alapunk, és egy célzott probléma megoldására keresünk precíz választ (pl.: vastag könyvek, hatalmas technikai dokumentációk). Még soha senki nem sajátított el új készséget a dokumentáció végigolvasásával!
7. **Tanuljunk épp eleget, ami minimálisan elégséges ahhoz, hogy tudjunk csinálni valamit a gyakorlatban (önálló tevékenység).** <br />
    Fontos, hogy minél előbb billentyűzetet ragadjunk, és bepiszkoljuk a kezünket a témával. A tanulás nem egy passzív folyamat, hanem egy aktív, gyakorlati tevékenység. Minél előbb elkezdünk gyakorolni, annál gyorsabban fogunk fejlődni.
8. **Kezdjünk el játszani az új technológiával (önálló tevékenység).** <br />
    Szórakozzunk, kísérletezzünk, próbáljuk ki, hogy az elképzeléseink/feltételezéseink megállnak-e a gyakorlatban is. Hibázzunk, és tanuljunk a hibákból, mert a sikerekből biztosan nem fogunk! A játékosság segít fenntartani a motivációt, és lehetővé teszi, hogy kreatív módon fedezzük fel az új technológiát. Próbáljunk ki mindent, ami eszünkbe jut, és járjunk utána a váratlan eredményeknek.
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


### Container Orchestration - Kubernetes (K8s)

#### Kubernetes bevezetés
A Kubernetes egy nyílt forráskódú platform, amelyet a Google fejlesztett ki. Lehetővé teszi a konténerizált alkalmazások automatikus telepítését, skálázását és kezelését. A Kubernetes egy konténer orchestrációs rendszer, amely segít a fejlesztőknek és az üzemeltetőknek abban, hogy hatékonyan kezeljék a konténereket nagy léptékben, különböző környezetekben, miközben biztosítják a magas rendelkezésre állást és a hibatűrést. A Kubernetes egy komplex rendszer, amely számos komponensből áll, és sokféle funkciót kínál.

#### Kubernetes architektúra

![Kubernetes Cluster Architektúra](https://kubernetes.io/images/docs/kubernetes-cluster-architecture.svg)

Egy Cluster fő építőeleme a Node, amely egy fizikai vagy virtuális gépet jelent. A cluster futhat egy vagy több Node-on. A Node-ok két fő típusa a Master aka. Control Plane Node és a Worker Node. A Control Plane felelős a cluster irányításáért, ezen futnak a Kubernetes rendszer komponensei. A Worker Node-ok futtatják az általunk meghatározott workload-okat.
Single Node cluster esetén a Control Plane és a Worker Node ugyanaz. Ebben az esetben a cluster minden komponense ugyanazon a gépen fut. Ez ideális fejlesztéshez és teszteléshez, de nem ajánlott éles környezetben, mivel nem biztosítja a magas rendelkezésre állást és a hibatűrést.
Multi Node cluster esetén a Control Plane és a Worker Node-ok külön gépeken futnak. Ez lehetővé teszi a magas rendelkezésre állást és a hibatűrést, mivel ha egy Node meghibásodik, a többi Node továbbra is működik, és a cluster képes fenntartani az alkalmazások elérhetőségét.

Főbb rendszer komponensek:
- **kube API server**: A központi kompnens, amin keresztül kapcsolódik a többi rendszer komponens. Mi is ehhez csatlakozunk `kubectl` vagy egyéb kliens használatával. Ezen egy REST API fut, amivel mTLS kapcsolaton keresztül lehet kommunikálni.
- **controller manager**: Felelős a cluster állapotának fenntartásáért. Folyamatosan figyeli a cluster állapotát, és ha eltérést észlel a kívánt állapot és a tényleges állapot között, akkor megteszi a szükséges lépéseket az eltérés korrigálására.
- **scheduler**: Felelős a Podok ütemezéséért a Worker Node-okra. Amikor egy új Pod jön létre, a Scheduler meghatározza, hogy melyik Node-on fog futni, figyelembe véve a Node erőforrásait, a Pod követelményeit és egyéb tényezőket.
- **etcd**: Egy kulcs-érték adatbázis, amely a Kubernetes cluster állapotát tárolja elosztott módon.
- **kubelet**: Minden Worker Node-on fut, és felelős a Podok futtatásáért és karbantartásáért a Node-on. A Kubelet folyamatosan kommunikál az API Server-rel, hogy jelentse a Node állapotát és a rajta futó Podok állapotát. Ez tartja a kapcsolatot az azonos Node-on lévő container runtime-mal (by-default containerd).
- **kube proxy**: Minden Worker Node-on fut, és felelős a hálózati forgalom irányításáért a Podok között, valamint a Podok és a külvilág között. A kube proxy biztosítja, hogy a Podok elérhetőek legyenek a cluster-en belül és (adott esetben) kívül is.
- **cloud controller manager**: Opcionális komponens, amely a Kubernetes cluster és a cloud szolgáltató közötti integrációt biztosítja. Ez a komponens felelős a cloud-specifikus műveletekért, mint például új node-ok vagy load balancer-ek létrehozása, storage provisioning, stb.

A kubernetes erőforrásoknak két nagy csoportja van:
- **Namespaced**: Csak a megadott névtérben lehet létrehozni.
- **Cluster-wide**: Nem névterekhez kötött, a cluster egészére vonatkozik.

Főbb **Cluster-wide** erőforrás típusok:
- **Node**: A Node bár az infrastruktúra része, mégis mint lekérdezhető erőforrás is megjelenik a Clusterben, és ezen keresztül tudunk róla információkat lekérdezni, konfigurálni, vagy akár módosítani az állapotát.
- **Namespace**: Mechanizmust biztosítanak az erőforrások csoportjainak elkülönítésére egyetlen Cluster-en belül. A Namespaced erőforrások neveinek egyedinek kell lenniük egy névtéren belül, viszont a névterek között már nem.
- **CustomResourceDefinition**: Lehetővé teszi, hogy saját erőforrás típusokat definiáljunk a Kubernetes-ben, amiket aztán ugyanúgy használhatunk, mint a beépített erőforrásokat. Ez egy nagyon hasznos eszköz, amivel a Kubernetes funkcionalitását ki tudjuk terjeszteni a saját igényeink szerint.

Főbb **Namespaced** erőforrás típusok:
- **Pod**: A Kubernetes legkisebb egysége, amely egy vagy több konténert futtat, amelyek megosztják egymással a Node erőforrásainak egy részét. A Pod egy logikai egységet képez, aminek a konténerei mindig ugyanazon a Node-on futnak. Podokat standalone módon is létrehozhatunk, viszont ez nem egy perzisztens megoldás, ezért általában magasabb szintű erőforrások (pl.: ReplicaSet, Deployment, stb...) kezelik őket. A managelt Podok nevei egyedi, de nem perzisztens azonosítóval végződnek, ami a manager ReplicaSet és a Pod azonosítóiból áll össze.
- **ReplicaSet**: Manager erőforrás, amely Podokat kezel. Biztosítja, hogy egy adott számú Pod mindig fusson a cluster-en. Ha egy Pod eltűnik, a ReplicaSet automatikusan létrehoz helyette egy újat, hogy fenntartsa a futó Podok kívánt számát. A neve egyedi, de nem perzisztens azonosítóval végződik, amelyet a managelt Podok is megörökölnek.
- **Deployment**: Manager erőforrás, amely egy ReplicaSet-et kezel. A Deployment rolling-update és rollback funkciót biztosít egyazon ReplicaSet különböző verziói között.
- **StatefulSet**: Manager erőforrás, amely egy vagy több Podot kezel, amelyek nevei egyedi, PERZISZTENS azonosítóval rendelkeznek (inkrementális zero-based index). Ahogy a neve is mutatja, ez a típus olyan alkalmazásokhoz optimális, amelyek állapotot tárolnak, és szükségük van egyedi azonosítókra a Podok között (pl.: adatbázisok). Itt is meg lehet határozni Replica számot, de a StatefulSet nem ReplicaSet-et használ, hanem közvetlenül kezeli a Podokat.
- **DaemonSet**: Manager erőforrás, amely pontosan egy Podot futtat minden Node-on, mindenkor. Ez olyan alkalmazásokhoz optimális, amelyeknek minden Node-on futniuk kell (pl.: loggyűjtők, monitoring ügynökök, stb...).
- **Service**: Több típusa van:
    - **ClusterIP**: Ez a default típus, amely egy virtuális IP címet biztosít, és ezen keresztül load balancing szolgáltatást végez a mögöttes Podok között.
    - **NodePort**: Ez a típus egy portot nyit meg a clusteren egy előre meghatározott tartományból (by-default: 30000-32767), amelyen keresztül elérhetővé teszi a mögöttes Podokat kívülről is. Ezen túlmenően úgy működik, mint egy ClusterIP.
    - **Headless Service**: Ez a típus nem biztosít virtuális IP címet, és nem végez load balancing szolgáltatást a Podok között. Ezzel a típussal közvetlenül egy Pod IP címére lehet hivatkozni, ami hasznos pl.: StatefulSet esetén, ahol szükség van a Podok egyedi elérésére (pl.: [leader election](https://en.wikipedia.org/wiki/Leader_election) miatt).
    - **LoadBalancer**: Ez a típus egy külső load balancer-t hoz létre a cloud szolgáltatónál, amelyen keresztül elérhetővé teszi a Service-t a Clusteren kívülről is.
    - **ExternalName**: Különleges típus, amely nem IP címre, hanem egy CNAME DNS rekordra oldódik fel. Ezzel egy absztrakciós réteget tudunk felhúzni egy külső szolgáltatás köré. Arra jó, hogy elég egy helyen kezelni egy külső erőforrás elérését, egy stabil Service cím mögé rejtve.
Minden Service címezhető a következő szabály szerint: `<service-neve>.<névtér-neve>.svc.cluster.local`.
- **Secret**: Olyan erőforrás, amely érzékeny adatokat tárol, mint például jelszavak, tokenek, vagy kulcsok. A Secret-eket általában a Podok használják a konfigurációjukhoz, anélkül, hogy az érzékeny adatok közvetlenül a Pod definíciójában szerepelnének. A Secret-ek az adatokat base64 kódolással tárolják, ami nem jelent valós védelmet, ezért fontos, hogy megfelelően kezeljük és korlátozzuk a hozzáférést ezekhez az erőforrásokhoz! Lehetőség van arra is, hogy külső titkosító megoldásokat integráljunk, hogy valódi védelmet biztosítsunk a Secret-ek számára (pl.: Sealed Secrets, KeyVault).
- **ConfigMap**: Olyan erőforrás, amely nem érzékeny konfigurációs adatokat tárol, mint például környezeti változók, konfigurációs fájlok, parancssori argumentumok, scriptek, stb... A ConfigMap-ek lehetővé teszik, hogy a konfigurációt elkülönítsük az alkalmazás kódjától, így könnyebben kezelhetjük és frissíthetjük a konfigurációt anélkül, hogy újra kellene buildelni miattuk alkalmazás image-ket, vagy újra kellene indítani a Podokat. (A gyakorlatban ennél azért kicsit bonyolultabb a helyzet, de ez a fő koncepció.)

#### Kubernetes használata

Az interakció valamilyen kliens alkalmazás használatával lehetséges, amely képes kommunikálni a kube API szerverrel. A leggyakrabban használt kliens a `kubectl`, amely lehetővé teszi a Kubernetes erőforrások létrehozását, lekérdezését, frissítését és törlését, így könnyen kezelhetjük a Kubernetes clustert.

**Gyakori `kubectl` parancsok:**
- `kubectl run`: Egy új, standalone Pod létrehozása egy adott image-ből. Jellemzően nem használjuk, mert manifest alapján szoktuk létrehozni az erőforrásokat, de teszteléshez hasznos lehet.
- `kubectl expose`: Egy meglévő Podhoz új Service kapcsolása. Jellemzően nem használjuk, mert manifest alapján szoktuk létrehozni az erőforrásokat, de teszteléshez hasznos lehet.
- `kubectl get`: Kubernetes erőforrások listázása.
- `kubectl describe`: Egy erőforrás részletes információinak megtekintése.
- `kubectl apply`: Egy erőforrás létrehozása vagy frissítése egy YAML fájl alapján.
- `kubectl create`: Egy erőforrás létrehozása egy YAML manifest fájl alapján. Az `apply`-hoz képest kevésbé érzékeny az időtúllépésre nagy méretű manifest fájlok esetén.
- `kubectl edit`: Egy erőforrás szerkesztése "menet közben" a default szövegszerkesztőnkben.
- `kubectl delete`: Egy erőforrás törlése.
- `kubectl logs`: Egy Podon futó konténer logjainak megtekintése.
- `kubectl exec`: Parancs futtatása egy Podon futó konténerben.
- `kubectl port-forward`: Port forwarding egy erőforráshoz, hogy elérhetővé tegyük a szolgáltatásait a helyi gépünkön keresztül.

**Kubernetes manifest fájlok** YAML formátumban vannak, és tartalmazzák a létrehozandó erőforrások specifikációját. A manifest fájlok segítségével deklaratív módon definiálhatjuk (verzió kezelhetjük) a Kubernetes erőforrásokat, és pl. a `kubectl apply` parancs segítségével létrehozhatjuk vagy frissíthetjük ezeket az erőforrásokat a clusterben. A manifest fájlokban meg kell adni az erőforrás típusát, nevét, névterét (ha szükséges), valamint a specifikációt (spec szekció), amely tartalmazza az erőforrás konfigurációját és működését meghatározó részleteket.

**Néhány példa a hivatalos Kubernetes dokumentációból:**
- [Pod dokumentáció minimal manifest példával.](https://kubernetes.io/docs/concepts/workloads/pods/)
- [Deployment dokumentáció minimal manifest példával.](https://kubernetes.io/docs/concepts/workloads/controllers/deployment/)
- [Service dokumentáció minimal manifest példával.](https://kubernetes.io/docs/concepts/services-networking/service/)
- [Secret dokumentáció minimal manifest példával.](https://kubernetes.io/docs/concepts/configuration/secret/)
