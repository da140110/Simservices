/// <reference path="../plugins/angular/angular.js" />
var myapp = angular.module('myModule', []);
myapp.controller("schoolController", schoolController);

//declare
function schoolController($scope) {
    $scope.message="This is message from School"
}
function Validator($windows) {
    function checkNumber(input) {
        if (input % 2 == 0) {
            $windows.alert('This is even');
        }
        else
            $windows.alert('This is even');
    }
}