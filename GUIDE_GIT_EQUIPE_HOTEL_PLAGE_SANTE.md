# Guide Git de l'équipe — Hôtel Plage-Santé Inc.

Ce document sert d'aide-mémoire pour travailler avec **Git/GitHub** sur le projet dans **Visual Studio 2026**.

Le projet utilise une branche principale :

```text
main
```

et une branche `feature/...` pour chaque fonctionnalité.

> **Règle principale :** on ne développe pas directement dans `main`.
> Chaque membre travaille dans la branche associée à sa tâche, puis la branche terminée est fusionnée dans `main`.

---

# 1. Organisation des branches du projet

| Branche | Fonctionnalité | Responsable |
|---|---|---|
| `feature/menu` | Menu selon le rôle, déconnexion et fermeture | Gabriel |
| `feature/Gestion_utilisateurs` | Gestion des utilisateurs | Nesma |
| `feature/Gestion-clients-invités` | Gestion des clients et de leurs invités | Nesma |
| `feature/Gestion-assistants-soins` | Gestion des assistants et de leurs soins | Sarah |
| `feature/Gestion-soins` | Gestion des soins | Nesma |
| `feature/Planification-soins` | Planification des soins | Nesma |
| `feature/Gestion-chambres-typeChambres` | Gestion des chambres et de leurs types | Sarah |
| `feature/Réservation-chambres` | Réservation des chambres | Sarah |
| `feature/Rapport-soinsOfferts-clients-invités` | Rapport des soins offerts aux clients et invités | Nesma |
| `feature/Rapport-réservations-chambres` | Rapport des réservations de chambres | Sarah |
| `feature/Rapport-soins-journaliers-assistants` | Rapport des soins journaliers des assistants | Gabriel |
| `main` | Version intégrée et stable du projet | Toute l'équipe |

---

# 2. Fonctionnement général

Le fonctionnement recommandé est :

```text
main
  |
  +--> feature/ma-fonctionnalite
             |
             +--> développement
             +--> commits
             +--> push vers GitHub
             |
             +--> Pull Request
                      |
                      v
                    main
```

Chaque fonctionnalité doit être développée séparément.

## À éviter

Ne pas travailler directement dans `main`.

Ne pas fusionner une branche `feature` dans une autre branche `feature` sauf décision claire de l'équipe.

Éviter :

```bash
git push --force
```

Éviter également de faire un `pull` alors que des fichiers importants sont modifiés mais pas encore enregistrés/commités.

---

# PARTIE A — UTILISATION AVEC GIT BASH

# 3. Première installation du projet

Cette partie est faite **une seule fois** sur chaque ordinateur.

## 3.1 Vérifier que Git est installé

Dans Git Bash :

```bash
git --version
```

## 3.2 Configurer son nom et son courriel

À faire une seule fois :

```bash
git config --global user.name "Votre Nom"
git config --global user.email "votre@email.com"
```

## 3.3 Cloner le dépôt

```bash
git clone https://github.com/Sarah777-k/Hotel_Plage-Sant-Inc.git
```

Puis entrer dans le projet :

```bash
cd Hotel_Plage-Sant-Inc
```

## 3.4 Vérifier les branches disponibles

```bash
git branch
```

Pour voir également les branches présentes sur GitHub :

```bash
git branch -a
```

---

# 4. Routine au DÉBUT de chaque séance

Avant de commencer à programmer, vérifier l'état du dépôt :

```bash
git status
```

## 4.1 Mettre `main` à jour

```bash
git checkout main
git pull origin main
```

Ou avec la commande Git plus récente :

```bash
git switch main
git pull origin main
```

> `checkout` et `switch` peuvent tous les deux être utilisés pour changer de branche.

## 4.2 Aller sur sa branche

Exemple pour la gestion des utilisateurs :

```bash
git checkout feature/Gestion_utilisateurs
```

ou :

```bash
git switch feature/Gestion_utilisateurs
```

Puis récupérer les éventuelles modifications déjà présentes sur GitHub :

```bash
git pull origin feature/Gestion_utilisateurs
```

## 4.3 Vérifier la branche actuelle

```bash
git branch
```

La branche actuelle possède une étoile `*`.

Exemple :

```text
* feature/Gestion_utilisateurs
  main
```

On peut aussi faire :

```bash
git status
```

---

# 5. Pendant le travail

Programmer normalement dans Visual Studio.

À tout moment, on peut vérifier les fichiers modifiés :

```bash
git status
```

Pour voir les modifications :

```bash
git diff
```

---

# 6. Enregistrer son travail avec un commit

Lorsque la fonctionnalité a atteint un état logique et fonctionnel :

## 6.1 Vérifier les changements

```bash
git status
```

## 6.2 Ajouter les fichiers

Pour tous les fichiers :

```bash
git add .
```

Ou pour un fichier précis :

```bash
git add NomDuFichier.cs
```

## 6.3 Créer le commit

```bash
git commit -m "Ajout de la gestion des utilisateurs"
```

Exemples de bons messages :

```text
Ajout du formulaire de gestion des utilisateurs
Ajout de la validation des données client
Correction de la suppression des invités
Ajout du rapport des réservations de chambres
Correction de la planification des soins
```

Éviter les messages peu descriptifs :

```text
update
test
fix
modif
```

---

# 7. Envoyer son travail sur GitHub — PUSH

Après le commit :

```bash
git push origin feature/Gestion_utilisateurs
```

Adapter le nom à votre branche.

Exemple Sarah :

```bash
git push origin feature/Gestion-chambres-typeChambres
```

Exemple Gabriel :

```bash
git push origin feature/Rapport-soins-journaliers-assistants
```

---

# 8. Routine complète d'une séance

Exemple : Nesma travaille sur `Gestion_utilisateurs`.

Au début :

```bash
git checkout main
git pull origin main

git checkout feature/Gestion_utilisateurs
git pull origin feature/Gestion_utilisateurs
```

Elle programme ensuite dans Visual Studio.

À la fin :

```bash
git status
git add .
git commit -m "Ajout de la gestion des utilisateurs"
git push origin feature/Gestion_utilisateurs
```

---

# 9. Mettre une branche `feature` à jour avec `main`

Cette opération est utile si d'autres fonctionnalités ont été ajoutées dans `main` pendant qu'on travaille encore sur notre branche.

Commencer par vérifier qu'il n'y a pas de travail non enregistré :

```bash
git status
```

Puis :

```bash
git checkout main
git pull origin main
```

Retourner dans sa branche :

```bash
git checkout feature/Gestion_utilisateurs
```

Fusionner `main` dans la branche :

```bash
git merge main
```

Puis tester le projet.

Si tout fonctionne :

```bash
git push origin feature/Gestion_utilisateurs
```

Schéma :

```text
main mis à jour
      |
      v
feature/Gestion_utilisateurs
```

---

# 10. Quand une fonctionnalité est terminée

Une fonctionnalité est considérée prête lorsqu'elle :

- compile;
- fonctionne;
- respecte les règles du cahier des charges;
- a été testée;
- ne contient pas d'erreurs évidentes;
- a été commitée;
- a été poussée sur GitHub.

Faire ensuite une **Pull Request** vers :

```text
main
```

Exemple :

```text
feature/Gestion_utilisateurs
              |
              v
            main
```

---

# 11. Fusionner dans `main`

## Méthode recommandée : Pull Request sur GitHub

1. Faire le dernier `push` de la branche.
2. Ouvrir GitHub.
3. Aller dans **Pull requests**.
4. Cliquer sur **New pull request**.
5. Choisir :

```text
base: main
compare: feature/nom-de-la-branche
```

6. Vérifier les fichiers modifiés.
7. Créer la Pull Request.
8. Un autre membre peut vérifier rapidement la fonctionnalité.
9. Cliquer sur **Merge pull request** lorsque tout est correct.
10. Confirmer la fusion.

> Pour ce projet d'équipe, cette méthode est préférable à un merge directement sur `main`, car les modifications restent faciles à vérifier.

---

# 12. Après un merge dans `main`

Tous les membres doivent récupérer la nouvelle version :

```bash
git checkout main
git pull origin main
```

Si vous devez continuer à travailler sur une branche existante :

```bash
git checkout feature/ma-branche
git merge main
```

Puis :

```bash
git push origin feature/ma-branche
```

---

# 13. En cas de conflit

Un conflit peut apparaître lorsque deux personnes modifient les mêmes lignes d'un fichier.

Git peut afficher :

```text
CONFLICT (content): Merge conflict in NomDuFichier.cs
```

Ne pas paniquer et ne pas supprimer le dépôt.

## 13.1 Voir les fichiers en conflit

```bash
git status
```

## 13.2 Ouvrir les fichiers dans Visual Studio

Git ajoute généralement des marqueurs ressemblant à :

```text
<<<<<<< HEAD
notre version
=======
autre version
>>>>>>> main
```

Il faut choisir ce qui doit être conservé ou combiner correctement les deux versions.

Supprimer ensuite tous les marqueurs :

```text
<<<<<<<
=======
>>>>>>>
```

## 13.3 Après avoir corrigé le conflit

```bash
git add .
git commit -m "Résolution du conflit avec main"
git push origin feature/ma-branche
```

Toujours compiler et tester après une résolution de conflit.

---

# 14. Commandes Git Bash à retenir

| Action | Commande |
|---|---|
| Voir l'état | `git status` |
| Voir la branche actuelle | `git branch` |
| Voir toutes les branches | `git branch -a` |
| Changer de branche | `git checkout nom-branche` |
| Changer de branche, version moderne | `git switch nom-branche` |
| Télécharger les changements | `git pull` |
| Ajouter les modifications | `git add .` |
| Créer un commit | `git commit -m "message"` |
| Envoyer vers GitHub | `git push` |
| Fusionner une branche | `git merge nom-branche` |
| Voir l'historique | `git log --oneline --graph --all` |
| Voir les modifications | `git diff` |

---

# PARTIE B — UTILISATION DANS VISUAL STUDIO 2026

Visual Studio 2026 permet de faire presque toutes les opérations Git sans écrire de commandes.

Les deux fenêtres les plus importantes sont :

```text
Git Changes / Modifications Git
Git Repository / Référentiel Git
```

---

# 15. Ouvrir les outils Git dans Visual Studio 2026

Dans Visual Studio :

```text
View / Affichage
    -> Git Changes / Modifications Git
```

et :

```text
View / Affichage
    -> Git Repository / Référentiel Git
```

La fenêtre **Modifications Git** sert surtout à :

- voir les fichiers modifiés;
- créer un commit;
- faire Pull;
- faire Push;
- synchroniser.

La fenêtre **Référentiel Git** sert surtout à :

- voir les branches;
- changer de branche;
- voir l'historique;
- effectuer des merges;
- comparer des branches.

---

# 16. Changer de branche dans Visual Studio

Ouvrir :

```text
Affichage
    -> Référentiel Git
```

Dans la liste des branches :

```text
Local
    main
    feature/Gestion_utilisateurs
    feature/Gestion-soins
    ...
```

Double-cliquer sur la branche désirée.

Exemple :

```text
feature/Gestion_utilisateurs
```

C'est l'équivalent de :

```bash
git checkout feature/Gestion_utilisateurs
```

Toujours vérifier le nom de la branche affichée dans Visual Studio avant de commencer à programmer.

---

# 17. Faire un PULL dans Visual Studio

Avant de commencer à travailler sur une branche :

1. Aller sur la bonne branche.
2. Ouvrir **Modifications Git**.
3. Utiliser **Pull / Tirer**.

Équivalent :

```bash
git pull
```

La routine du début devient donc :

```text
1. Aller sur main
2. Pull
3. Aller sur sa branche feature
4. Pull
5. Commencer à programmer
```

---

# 18. Faire un COMMIT dans Visual Studio

Après avoir programmé :

1. Ouvrir **Modifications Git**.
2. Vérifier la liste des fichiers modifiés.
3. Cliquer sur un fichier pour examiner les changements si nécessaire.
4. Écrire un message de commit.

Exemple :

```text
Ajout du formulaire de gestion des soins
```

5. Choisir **Commit All / Valider tout**.

Cela correspond approximativement à :

```bash
git add .
git commit -m "Ajout du formulaire de gestion des soins"
```

---

# 19. Faire un PUSH dans Visual Studio

Après le commit :

1. Ouvrir **Modifications Git**.
2. Cliquer sur **Push / Envoyer**.

Équivalent :

```bash
git push
```

Les modifications sont alors envoyées vers la branche correspondante sur GitHub.

---

# 20. Routine Visual Studio 2026 — début de séance

Exemple pour Sarah sur les chambres :

```text
Référentiel Git
    -> double-cliquer sur main

Modifications Git
    -> Pull

Référentiel Git
    -> double-cliquer sur
       feature/Gestion-chambres-typeChambres

Modifications Git
    -> Pull
```

Ensuite seulement, commencer le développement.

---

# 21. Routine Visual Studio 2026 — fin de séance

```text
1. Enregistrer tous les fichiers.
2. Compiler le projet.
3. Tester la fonctionnalité.
4. Ouvrir Modifications Git.
5. Vérifier les fichiers modifiés.
6. Écrire un message de commit.
7. Commit All / Valider tout.
8. Push / Envoyer.
```

---

# 22. Mettre sa branche à jour avec `main` dans Visual Studio

Supposons que la branche courante est :

```text
feature/Gestion_utilisateurs
```

et qu'on souhaite récupérer les changements récents de `main`.

## Étape 1

Aller sur :

```text
main
```

puis faire :

```text
Pull
```

## Étape 2

Retourner sur :

```text
feature/Gestion_utilisateurs
```

## Étape 3

Dans **Référentiel Git** :

1. vérifier que `feature/Gestion_utilisateurs` est bien la branche active;
2. clic droit sur `main`;
3. choisir l'option de fusion de `main` dans la branche actuelle.

Le résultat doit être :

```text
main
  |
  +----> feature/Gestion_utilisateurs
```

et NON l'inverse.

Compiler et tester immédiatement après le merge.

Puis faire :

```text
Commit, si Visual Studio en demande un
Push
```

---

# 23. Résoudre un conflit avec Visual Studio

Visual Studio possède une interface de résolution de conflits.

Lorsqu'un conflit apparaît :

1. Ouvrir **Modifications Git**.
2. Repérer **Conflicts / Conflits**.
3. Ouvrir le fichier en conflit.
4. Visual Studio présente les versions concernées.
5. Choisir les changements à conserver ou combiner les deux versions.
6. Valider la résolution.
7. Compiler.
8. Tester.
9. Commit.
10. Push.

Ne jamais choisir une version automatiquement sans vérifier son contenu.

---

# 24. Pull Request depuis Visual Studio / GitHub

Une fois une fonctionnalité terminée :

```text
feature/...
    |
    v
main
```

La branche doit d'abord avoir été poussée sur GitHub.

Visual Studio 2026 peut proposer des fonctions liées aux Pull Requests selon la version et les fonctionnalités activées. Si l'option n'est pas visible, utiliser directement GitHub dans le navigateur.

Sur GitHub :

```text
Pull requests
    -> New pull request
```

Choisir :

```text
base: main
compare: feature/ma-branche
```

Puis vérifier et fusionner.

---

# 25. Qui doit faire quoi ?

## Pendant le développement

Chaque membre travaille seulement sur sa branche.

### Nesma

```text
feature/Gestion_utilisateurs
feature/Gestion-clients-invités
feature/Gestion-soins
feature/Planification-soins
feature/Rapport-soinsOfferts-clients-invités
```

### Sarah

```text
feature/Gestion-assistants-soins
feature/Gestion-chambres-typeChambres
feature/Réservation-chambres
feature/Rapport-réservations-chambres
```

### Gabriel

```text
feature/menu
feature/Rapport-soins-journaliers-assistants
```

La connexion/vérification des identifiants doit également être développée sur une branche dédiée si ce travail n'est pas déjà inclus dans une branche existante.

Exemple conseillé :

```text
feature/connexion
```

---

# 26. Exemple complet — Nesma

Début :

```bash
git checkout main
git pull origin main

git checkout feature/Planification-soins
git pull origin feature/Planification-soins
```

Travail dans Visual Studio.

Fin :

```bash
git status
git add .
git commit -m "Ajout de la planification des soins"
git push origin feature/Planification-soins
```

Fonctionnalité terminée :

```text
Pull Request

feature/Planification-soins
        ->
main
```

---

# 27. Exemple complet — Sarah

Début :

```bash
git checkout main
git pull origin main

git checkout feature/Réservation-chambres
git pull origin feature/Réservation-chambres
```

Fin :

```bash
git add .
git commit -m "Ajout de la réservation des chambres"
git push origin feature/Réservation-chambres
```

---

# 28. Exemple complet — Gabriel

Début :

```bash
git checkout main
git pull origin main

git checkout feature/menu
git pull origin feature/menu
```

Fin :

```bash
git add .
git commit -m "Ajout du menu selon le rôle"
git push origin feature/menu
```

---

# 29. Règles de l'équipe

1. **Ne jamais programmer directement dans `main`.**
2. **Toujours vérifier la branche actuelle avant de modifier du code.**
3. **Faire un Pull avant de commencer une séance.**
4. **Faire des commits régulièrement.**
5. **Utiliser des messages de commit descriptifs.**
6. **Faire un Push après les commits importants et à la fin de la séance.**
7. **Compiler et tester avant une Pull Request.**
8. **Faire la Pull Request d'une branche `feature` vers `main`.**
9. **Ne pas faire `git push --force`.**
10. **Ne pas supprimer ou écraser le travail d'un autre membre lors d'un conflit.**
11. **Après un merge important dans `main`, prévenir l'équipe afin que tout le monde fasse un Pull.**
12. **Toujours vérifier le code après une résolution de conflit.**

---

# 30. Aide-mémoire ultra rapide

## Début de séance — Git Bash

```bash
git checkout main
git pull origin main

git checkout feature/MA-BRANCHE
git pull origin feature/MA-BRANCHE
```

## Fin de séance — Git Bash

```bash
git status
git add .
git commit -m "Description du travail"
git push origin feature/MA-BRANCHE
```

## Début de séance — Visual Studio

```text
main
 -> Pull
 -> changer vers feature/MA-BRANCHE
 -> Pull
 -> programmer
```

## Fin de séance — Visual Studio

```text
Enregistrer
 -> Compiler
 -> Tester
 -> Modifications Git
 -> Commit All
 -> Push
```

## Fonctionnalité terminée

```text
feature/MA-BRANCHE
        |
        v
   Pull Request
        |
        v
      main
```

---

# 31. Vérification avant de quitter

Avant de fermer Visual Studio :

```bash
git status
```

L'idéal est d'obtenir :

```text
nothing to commit, working tree clean
```

Si du travail doit être conservé sur GitHub, vérifier également qu'il a bien été poussé.

---

# Résumé

Pour ce projet, la méthode la plus simple et sécuritaire est :

```text
1. main -> Pull
2. feature personnelle -> Pull
3. travailler
4. tester
5. commit
6. push
7. Pull Request lorsque la fonctionnalité est terminée
8. merge dans main
9. toute l'équipe récupère le nouveau main
```

Cette routine doit être utilisée par **Nesma, Sarah et Gabriel** pendant toute la durée du projet.
