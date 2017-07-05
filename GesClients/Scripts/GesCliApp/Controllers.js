app.controller("GesClientsCtrl", function ($scope, GesClientsService) {
    //Cadastro de Clientes
    $scope.AddClients = function () {
        alert("Teste");
        var cli = {
            NomeCli: $scope.nomeCli,
            NascimentoCli: $scope.nascimentoCli,
            CPFCli:$scope.cpfCli
        };
        var AddClients = GesClientsService.saveClientes(cli);
        AddClients.then(function (d) {
        }, function (error) {
            console.log('Oops! Something went wrong while saving the data.')
        })
    };
});