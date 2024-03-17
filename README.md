Projet Albion_ApiV2

Le projet Albion_ApiV2 est une application web en C# qui permet de visualiser et de manipuler des données de joueurs pour le jeu Albion. Il utilise le framework .NET.  

Fonctionnalités principales de l'application:

Graphique : Un graphique est affiché sur la page, montrant les statistiques de vie totales et la renommée de pêche des joueurs. Le graphique est mis à jour en appelant la méthode UpdateChart.  

GetJson(): Cette méthode récupère les données du joueur à partir du stockage local du navigateur. Si les données ne sont pas disponibles ou si elles sont obsolètes (c'est-à-dire si elles ont plus d'un jour), elle appelle la méthode GetApi() pour récupérer les données de l'API Albion.

GetAlbionPlayerData(): Cette méthode lit les données des joueurs à partir d'un fichier JSON local. Si le fichier n'existe pas ou si une erreur se produit lors de la lecture du fichier, elle initialise une nouvelle liste de joueurs. Si les données du joueur récupérées de l'API ne sont pas égales au dernier joueur de la liste, elle ajoute le joueur à la liste.

PutAlbionPlayerData(AlbionPlayerJsonString): Cette méthode écrit les données des joueurs dans un fichier JSON local. Cela permet de conserver les données des joueurs entre les sessions de navigation.  
