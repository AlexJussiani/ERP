import { Component, OnInit } from "@angular/core"
import { Ingrediente } from "../modelo/ingrediente";
import { IngredienteServico } from "../../servicos/ingrediente/ingrediente.servico";

@Component({
  selector: "app-ingrediente",
  templateUrl: "./ingrediente.component.html",
  styleUrls: ["./ingrediente.component.css"]
})

export class IngredienteComponent implements OnInit {
  public ingrediente: Ingrediente

  constructor(private ingredienteServico: IngredienteServico) {

  }

  ngOnInit(): void {
    this.ingrediente = new Ingrediente();

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
