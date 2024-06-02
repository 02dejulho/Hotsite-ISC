// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

function Cadastrar() {
  let parameters = {
    Nome: $("#nome").val(),
    Email: $("#email").val(),
    Mensagem: $("#mensagem").val(),
  };

  $.post("/Home/Cadastrar", parameters)

    .done(function (data) {
      if (data.status == "OK") {
        $("#form").after("<h3>Cadastro efetuado com sucesso!</h3>");
        $("#form").hide();
      } else {
        $("#form").after("<h3>Erro. Tente novamente mais tarde.</h3>");
        $("#form").hide();
      }
    })
    .fail(function () {
      alert("Erro no Servidor.");
    });
}

$(document).ready(function () {
  $("#formCad").submit(function (e) {
    e.preventDefault();
    Cadastrar();
  });
});
