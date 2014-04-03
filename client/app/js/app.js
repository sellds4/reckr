'use strict';


// Declare app level module which depends on filters, and services
angular.module('myApp', [
  'ngRoute',
  'myApp.filters',
  'myApp.services',
  'myApp.directives',
  'myApp.controllers'
]).
config(['$routeProvider', function($routeProvider) {
  $routeProvider.when('/', {templateUrl: 'partials/homecourt.html', controller: 'HomeCtrl'});
  $routeProvider.when('/', {templateUrl: 'partials/courts.html', controller: 'CourtCtrl'});
  $routeProvider.when('/', {templateUrl: 'partials/players.html', controller: 'PlayerCtrl'});
  $routeProvider.otherwise({redirectTo: '/'});
}]);


// // GETS
// app.get('/', function(req, res) {
//     // Go home
// });
// app.get('/player/alerts', function(req, res) {
//     // Get Player's alerts
// });
// app.get('/player/rating', function(req, res) {
//     // Get Player's rating
// });
// app.get('/player/homecourt', function(req, res) {
//     // Get Player's homecourt(s)
// });
// app.get('/player/players', function(req, res) {
//     // Get Player's followed Players
// });
// app.get('/player/players/ratings', function(req, res) {
//     // Get Player's followed Players rated with ratings
// });
// app.get('/player/players/status', function(req, res) {
//     // Get Player's followed Players current status
// });
// app.get('/court/players', function(req, res) {
//     // Get players checked into court
// });
// app.get('/court/status', function(req, res) {
//     // Get court status (may want to tie to check-ins)
// });
// app.get('/court/comments', function(req, res) {
//     // Get court comments
// });
// app.get('/court/media', function(req, res) {
//     // Obtain court pics/videos
// });
// app.get('/court/courts', function(req, res) {
//     // Obtain courts near location
// });
// // POSTS
// app.post('/player/register', function(req, res) {
//     // Register an account
// });
// app.post('/player/login', function(req, res) {
//     // Login
// });
// app.post('/player/alerts', function(req, res) {
//     // Set Player's alerts
// });
// app.post('/player/homecourt', function(req, res) {
//     // Set Player's homecourt(s)
// });
// app.post('/player/status', function(req, res) {
//     // Set Player's status
// });
// app.post('/player/players', function(req, res) {
//     // Set new followed Players
// });
// app.post('/player/court', function(req, res) {
//     // Check into court
// });
// app.post('/player/players/ratings', function(req, res) {
//     // Set other Players' ratings
// });
// app.post('/court/comments', function(req, res) {
//     // Post court comment
// });
// app.post('/court/media', function(req, res) {
//     // Post pic/video related to court (tag players)
// });