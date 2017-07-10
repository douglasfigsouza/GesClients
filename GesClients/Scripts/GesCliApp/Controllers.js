app.controller("GesClientsCtrl", function ($scope, GesClientsService) {
    getAll();
    function getAll() {
        var servCall = GesClientsService.getClientes();
        servCall.then(function (d) {
            $scope.clientes = d;
        }, function (error) {
            console.log('Opa! Algo deu errado enquanto buscava os dados.')
        });
    }
    //Cadastro de Clientes
    $scope.AddClients = function () {
        var cli = {
            NomeCli: $scope.nomeCli,
            DataNascimentoCli: $scope.nascimentoCli,
            CPFCli:$scope.cpfCli
        };
        var AddClients = GesClientsService.saveClientes(cli);
        AddClients.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Opa! Algo deu errado ao salvar os dados.')
        })
    };
    $scope.makeEditable = function (obj) {
        obj.target.setAttribute("contenteditable", true);
        obj.target.focus();
    };
    $scope.updClientes = function (cli, eve) {
        cli.NomeCli = eve.currentTarget.innerText;
        var upd = GesClientsService.updateCliente(cli);
        upd.then(function (d) {
            getAll();
        }, function (error) {
            console.log('Opss! Algo deu errado ao atualizar os dados.')
        })
    };
    $scope.DelCliente = function (id) {
        var dltCli = GesClientsService.DeleteCliente(id);
        dltCli.then(function (d) {
            getAll();
        }, function (error) {
            console.log("Opss! Algo deu errado ao criar os dados.");
        });
    };
});