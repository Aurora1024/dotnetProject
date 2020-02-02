document.write("<script src=\"../vendors/angular/angular.js\"></script>");
var utils = angular.module('Utils', []);
utils.config(['$httpProvider', config]);
function config($httpProvider) {
    $httpProvider.defaults.withCredentials = true;
}
