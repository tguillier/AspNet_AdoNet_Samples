# Cours ASP.NET et ADO.NET

Ci-dessous l'ensemble des mini-projet réalisés dans le cadre du cours ASP.NET et ADO.NET pendant 3 jours.

Tous les points abordés (ADO, LINQ to DataSet, Dapper, ASP.NET MVC, Entity Framework et les migrations, le pattern Dependency Injection, ASP.NET Core, les tests unitaires d'un contrôleur, le pattern Repository) se trouvent "en vrac" dans le code de ce dépôt.

Pour une version plus organisée, veillez à ouvrir la solution dans **Visual Studio 2017** (il vous faudra le nécessaire pour développer aussi bien en **.NET Framework** qu'en **.NET Core**.

## 1. ADO.NET

Découverte d'ADO.NET et utilisation du mode connecté (Direct Data Access) et déconnecté (DataSet) de la librairie d'accès aux données du framework .NET.

Sont manipulés dans ce projet, les objets :
* SqlConnection
* SqlCommand
* SqlDataReader
* SqlDataAdapter
* DataSet/DataTable/DataRow

## 2. LINQ to DataSet

Ecriture d'une logique de mapping objet maison avec l'aide de LINQ to DataSet.

Manipulation des deux syntaxes LINQ :
* "SQL Like"
* "Fluent"

## 3. Dapper

Refactoring de notre code ADO.NET et LINQ to DataSet pour utiliser la librairie "micro-ORM" **Dapper**

Utilisation de la méthode "Query\<T>" et de la méthode "Execute" pour manipuler les données avec notre SqlConnection.

## 4. ASP.NET MVC

Premier projet ASP.NET MVC (.NET Framework), découverte de l'organisation d'un projet MVC et d'un certains nombre de concepts du framework :
* Moteur de vue **Razor**
* Objets **ViewData** et **ViewBag**
* Utilisation des **HTML Helpers** pour écrire des formulaires
* Passage d'informations entre vues et contrôleurs
* Typage fort des vues et **ViewModels**
* etc.

## 5. Dependency Injection

Découverte du principe d'injection de dépendance et des avantage de l'inversion de contrôle (IoC)

Mise en place de tests unitaires sur un mini-système respectant ce principe.

## 6. Stokotop (ASP.NET Core)

Premier projet ASP.NET Core MVC, mise en avant des différences avec ASP.NET MVC (non Core), mise en place de la sécurité avec **ASP.NET Identity** (Manipulation du **SignInManager**, enregistrement des utilisateurs, filtrage par autorisation avec l'attribut **[Authorize]**, etc.

Ecriture de tests unitaires sur les contrôleurs à l'aide du pattern Repository (découplage des contrôleurs et de l'accès aux données via Entity Framework).

# **Have Fun ! :-)**

N'hésitez surtout pas à cloner ou forker ce dépôt et **bidouillez un maximum !!! :D**
