app.controller("compromissoController", function ($scope, $http) {

        // Lista de Compromissos
        $http.get("/CompromissoApi/List").then(function (response) {
            $scope.compromissosList = response.data;
        });

        // Lista de Pessoas
        $http.get("/PessoaApi/List").then(function(response) {
            $scope.pessoasList = response.data;
        });

        $scope.resetCompromissos = function() {
            $scope.compromissosList = {};
            $http.get("/CompromissoApi/List").then(function (response) {
                $scope.compromissosList = response.data;
            });
        }

        //Cria o Compromisso
        $scope.criarCompromisso = function(novoCompromisso) {

            //Tratando Compromisso
            $scope.compromisso = {
                nome: novoCompromisso.nome,
                dataCompromisso: novoCompromisso.dataCompromisso,
                pessoaId: novoCompromisso.pessoa.id
            };

            $http.post("/CompromissoApi/Create", $scope.compromisso).then(function (response) {
                $scope.novoCompromisso = {};
                $scope.resetCompromissos();
            });
        };

    });