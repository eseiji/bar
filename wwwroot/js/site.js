// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
/*
let prosdutos = [];
function AdicionarProdsdasuto(a) {
  produdtos.push(a);
  //document.getElementById("btnAdd").disabled = true;
  document.querySelector("td").createElement("tr");
  //document.querySelector("td").createElement("tr");
  //document.createElement("tr");
  //document.createElement("td");
  //document.querySelector("td").innerHTML = produtos;
  /*
  let td = document.querySelector("td");
  let text = document.createTextNode("SADADASDADASDD");
  td.appendChild(text);
  //document.getElementById("teste").innerHTML = produtos;
}*/
/*
let produtos = [];
function AdicionarProduto(descricao, valor) {
  console.log(descricao);
  console.log(valor);
  produtos.push({ descricao: descricao, valor: valor });

  tbl = document.getElementById("tbody");
  for (var j = 0; j < 1; j++) {
    const tr = tbl.insertRow();
    const td = tr.insertCell();
    td.appendChild(document.createTextNode(descricao));
  }
}*/

/*
let produtos = [];
function AdicionarProduto(produto) {
  produtos.push(produto);
  function generateTable(table, data) {
    for (let element of data) {
      let row = table.insertRow();
      for (key in element) {
        let cell = row.insertCell();
        let text = document.createTextNode(element[key]);
        cell.appendChild(text);
      }
    }
  }
  let table = document.querySelector("table");
  generateTable(table, produtos);
}
/*
function generateTableHead(table, data) {
  let thead = table.createTHead();
  let row = thead.insertRow();
  for (let key of data) {
    let th = document.createElement("th");
    let text = document.createTextNode(key);
    th.appendChild(text);
    row.appendChild(th);
  }
}

function generateTable(table, data) {
  for (let element of data) {
    let row = table.insertRow();
    for (key in element) {
      let cell = row.insertCell();
      let text = document.createTextNode(element[key]);
      cell.appendChild(text);
    }
  }
}

let table = document.querySelector("table");
//let data = Object.keys(produtos);
//generateTableHead(table, data);
generateTable(table, produtos);*/

let produtos = [];
function AdicionarProduto1(descricao, valor) {
  produtos.push({ descricao: descricao, valor: valor });
  console.log(produtos);
  // get the reference for the body
  //var body = document.getElementsByTagName("body")[0];
  //let tb = document.getElementById("tabela");

  // creates a <table> element and a <tbody> element
  //var tbl = document.createElement("table");
  //var tblBody = document.createElement("tbody");

  var tbl = document.getElementById("tabela");
  var tblBody = document.getElementById("tbody");

  // creating all cells
  for (var i = 0; i < 1; i++) {
    // creates a table row
    var row = document.createElement("tr");

    for (var j = 0; j < 1; j++) {
      // Create a <td> element and a text node, make the text
      // node the contents of the <td>, and put the <td> at
      // the end of the table row
      var cell = document.createElement("td");
      var cellText = document.createTextNode(descricao);
      cell.appendChild(cellText);
      row.appendChild(cell);

      for (var k = 0; k < 1; k++) {
        // Create a <td> element and a text node, make the text
        // node the contents of the <td>, and put the <td> at
        // the end of the table row
        var cell = document.createElement("td");
        var cellText = document.createTextNode("R$ " + valor);
        cell.appendChild(cellText);
        row.appendChild(cell);

        for (var m = 0; m < 1; m++) {
          var td = document.createElement("td");
          var div = document.createElement("div");
          var cell = document.createElement("input");
          div.className = "div-qtd";
          cell.type = "text";
          cell.className = "input-qtd";
          td.appendChild(div);
          div.appendChild(cell);
          row.appendChild(td);

          for (var n = 0; n < 1; n++) {
            var td = document.createElement("td");
            var btn = document.createElement("button");
            var text = document.createTextNode("Editar");
            btn.className = "btn btn-secondary";
            btn.appendChild(text);
            td.appendChild(btn);
            row.appendChild(td);
          }
        }
      }
    }

    // add the row to the end of the table body
    tblBody.appendChild(row);
  }

  // put the <tbody> in the <table>
  tbl.appendChild(tblBody);
  // appends <table> into <body>
  //tb.appendChild(tbl);
  // sets the border attribute of tbl to 2;
}

function EnviarProdutos(id, descricao, valor) {
  $.ajax({
    type: "GET",
    URL: "https://localhost:5001/Produto/Create",
    data: { id: id, descricao: descricao, valor: valor },
    success: function (msg) {
      //$("#divResult").html("success");
      console.log(msg);
    },
    error: function (e) {
      console.log(e);
      //$("#divResult").html("Something Wrong.");
    },
  });
}
