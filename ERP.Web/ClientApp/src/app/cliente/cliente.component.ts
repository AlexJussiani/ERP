import { Component, OnInit } from "@angular/core"
import { Cliente } from "../modelo/cliente";
import { ClienteServico } from "../../servicos/cliente/cliente.servico";

@Component({
  selector: "app-cliente",
  templateUrl: "./cliente.component.html",
  styleUrls: ["./cliente.component.css"]
})

export class ClienteComponent implements OnInit {
  public cliente: Cliente

  constructor(private clienteServico: ClienteServico) {

  }

  ngOnInit(): void {
    this.cliente = new Cliente();

  }
  public cadastrar() {
    //this.produto
    //this.produtoServico.cadastrar(this.produto)
    //  .subscribe(
    //    produtoJson => {
    //      console.log(produtoJson);

    //    },
    //    e => {
    //      console.log(e.error);
    //    }
    //  );
  }
}
