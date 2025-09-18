# Désensacheuse Modernisée

Cette nouvelle version de l'application de désensachage a été entièrement réécrite en VB.NET afin d'offrir une expérience moderne et compatible avec Windows 11.

## Architecture

- **DesensacheuseModern.sln** : solution Visual Studio.
- **DesensacheuseModern.App** : projet WinForms VB.NET utilisant .NET 8.
- **data/formules.json** : jeu de données d'exemple permettant de simuler le chargement des recettes.
- **data/production-log.json** : fichier généré à l'enregistrement d'une production.

## Fonctionnalités principales

- Scan d'un OF et extraction automatique du numéro de couteau.
- Sélection du mode de fonctionnement (désensacheuse ou palette).
- Tableau moderne permettant de suivre les ingrédients, les lots et le nombre de sacs.
- Calcul dynamique des totaux et suivi des compléments.
- Enregistrement des sessions de production dans un journal JSON.

## Pré-requis

- Windows 11 avec le SDK .NET 8 installé.
- Visual Studio 2022 (ou supérieur) avec la charge de travail "Développement desktop .NET".

## Lancement

1. Ouvrir `DesensacheuseModern.sln` dans Visual Studio.
2. Exécuter l'application (`F5`).
3. Scanner (ou saisir) un code OF présent dans `data/formules.json`, par exemple `123456780001`.
4. Suivre les étapes de l'assistant.

> Remarque : le fichier `production-log.json` est créé automatiquement lors de l'enregistrement d'une session.
