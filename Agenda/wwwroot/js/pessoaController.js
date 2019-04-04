app.controller("pessoaController", function ($scope, $http) {

        // Lista de Pessoas
        $http.get("/PessoaApi/List").then(function(response) {
            $scope.pessoasList = response.data;
        });

        $scope.resetPessoas = function() {
            $scope.pessoasList = {};
            $http.get("/PessoaApi/List").then(function(response) {
            $scope.pessoasList = response.data;
        });
        }

        //Cria o Compromisso
        $scope.criarPessoa = function(novaPessoa) {
            $http.post("/PessoaApi/Create", novaPessoa).then(function (response) {
                $scope.novaPessoa = {};
                $scope.resetPessoas();
            });
        };
    });