
var helloApp = angular.module("helloApp", ["xeditable"]);

helloApp.run(function (editableOptions) {
    editableOptions.theme = 'bs3';
});
helloApp.controller("CompanyCtrl", ['myService', function (myService) {
    debugger;
    $scope.divEmployee = false;
    GetAllEmployee();
    //To Get All Records 
    function GetAllEmployee() {
        debugger;
        var getData = myService.getEmployees();
        debugger;
        getData.then(function (emp) {
            $scope.employees = emp.data;
        }, function () {
            alert('Error in getting records');
        })
    }
}]);
    
    //helloApp.controller("CompanyCtrl", function ($scope) {
    //    //debugger;
    //    $scope.companies = [
    //                        {
    //                            'name': 'ITC Infotech',
    //                            'salary': '45000',
    //                            'dob': '21/01/1988',
    //                            'employees': 'Ghanshyam Jha',
    //                            'headoffice': 'Bangalore'
    //                        },
    //                            {
    //                                'name': 'Cognizant Technologies',
    //                                'salary': 45000,
    //                                'dob': '21/01/1988',
    //                                'employees': 'Alen Donald',
    //                                'headoffice': 'Bangalore'
    //                            },
    //                                {
    //                                    'name': 'Wipro',
    //                                    'salary': 38000,
    //                                    'dob': '21/01/1988',
    //                                    'employees': 'Veerendra',
    //                                    'headoffice': 'Bangalore'
    //                                },
    //                                    {
    //                                        'name': 'ITC Infotech Ltd',
    //                                        'salary': 65000,
    //                                        'dob': '21/01/1988',
    //                                        'employees': 'Sharmistha',
    //                                        'headoffice': 'Bangalore'
    //                                    },
    //                                        {
    //                                            'name': 'Facebook Technologies',
    //                                            'salary': 95000,
    //                                            'dob': '21/01/1988',
    //                                            'employees': 'MArks Jukerburg',
    //                                            'headoffice': 'Noida'
    //                                        },
    //    ];
    //$scope.addRow = function () {
    //    //debugger;
    //    $scope.companies.push({ 'name': $scope.name, 'salary': $scope.salary, 'dob': $scope.dob, 'employees': $scope.employees, 'headoffice': $scope.headoffice });
    //    $scope.name = '';
    //    $scope.salary = '';
    //    $scope.dob = '';
    //    $scope.employees = '';
    //    $scope.headoffice = '';
    //};
    //$scope.removeRow = function (name) {
    //    var index = -1;
    //    var comArr = eval($scope.companies);
    //    for (var i = 0; i < comArr.length; i++) {
    //        if (comArr[i].name === name) {
    //            index = i;
    //            break;
    //        }
    //    }
    //    if (index === -1) {
    //        alert("Something gone wrong");
    //    }
    //    $scope.companies.splice(index, 1);
    //};









