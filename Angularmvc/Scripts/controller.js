var app = angular.module('myApp', []);
app.controller('HomeCtrl', ['$scope', '$http', function ($scope, $http) {
    //$scope.message = "Welcome to Angular .NET MVC 4";
    $http({
        method: 'GET',
        url: 'http://localhost:54994/Account/GetEmployees'
    }).then(function successCallback(response) {
        $scope.employees = response.data;

      
    }, function errorCallback(response) {
        
    })
.then(function (response) {
   
    angular.forEach($scope.employees, function (obj) {
        obj["showEdit"] = true;
    })
   
    $scope.toggleEdit = function (emp) {
        emp.showEdit = emp.showEdit ? false : true;
    }
    //debugger;

    $scope.toggleSave = function (emp) {
        //debugger;
        $http.post('CreateEmployees', emp)
           .then(function (emp, status, headers, config) {
               debugger;
               $scope.ServerResponse = emp;
           });
        $scope.FirstName = '';
        $scope.LastName = '';
        $scope.Country = '';
        //$.ajax({
        //    url: "CreateEmployees",
        //    type: "POST",
        //data: JSON.stringify(emp),
        //contentType: "application/json; charset=utf-8",
        //dataType: "json",
        //error: function (response) {
        //    alert(response.responseText);
        //},
        //success: function (response) {
        //    alert(response);
        //}
        //});
        //$.ajax({
        //    type: 'POST',
        //    url: 'CreateEmployees',
        //    data: { FirstName: FirstName, LastName: LastName, Country: Country },
        //    success: success,
        //    error: function (x) {


        //        console.log(data);
        //        $('#snc').html("Error:" + x);
        //    }
        //});
        //$.ajax({
        //    type: "GET",
        //    url: 'CreateEmployees',
        //    success: success,
        //}).done(function (data) {
        //    var items = [];

        //    $.each(data.tata.entities.q142.labels.fr.value, function (key, val) {
        //        items.push('<li id="' + key + '">Test 2:' + val + '</li>');
        //    });

        //    $('<ul/>', {
        //        'class': 'my-new-list',
        //        html: items.join('')
        //    }).appendTo('body');
        //});
        //$http.post('CreateEmployees', data, config)
        //    .success(function (data, status, headers, config) {
        //        $scope.employees = response.data;
        //    })
        //$http({
        //    method: 'POST',
        //    url: 'CreateEmployees',
        //    data: emp,
        //    success: function (data) { alert('data: ' + data); },
        //    contentType: "application/json",
        //    dataType: JSON

        //})
        //emp.showEdit = emp.showEdit ? false : true;
        //$http.post("CreateEmployees", { routineId: data }).error(function (responseData) {
        //    console.log("Error !" + responseData);
        //});

    }
}, function (error) {
    console.log(error);
});

    $scope.addRow = function () {
        //debugger;
        $scope.employees.push({ 'FirstName': $scope.FirstName, 'LastName': $scope.LastName, 'Country': $scope.Country });
        $scope.FirstName = '';
        $scope.LastName = '';
        $scope.Country = '';

    };


}]);