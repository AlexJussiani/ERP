import { Component, OnInit } from "@angular/core"
import { Ingrediente } from "../modelo/ingrediente";
import { IngredienteServico } from "../../servicos/ingrediente/ingrediente.servico";

@Component({
  selector: "app-ingrediente",
  templateUrl: "./ingrediente.component.html",
  styleUrls: ["./ingrediente.component.css"]
})

export class IngredienteComponent implements OnInit {
  public ingrediente: Ingrediente;
  public ativar_spinner: boolean;

  constructor(private ingredienteServico: IngredienteServico) {

  }

  ngOnInit(): void {
    this.ingrediente = new Ingrediente();
     
  }
  public cadastrar() {
    this.ativar_spinner = true;
    this.ingredienteServico.cadastrar(this.ingrediente)
      .subscribe(
        retorno => {
          this.ativar_spinner = false;
          alert("teste2");
        },
        e => {
          alert("teste1");
          this.ativar_spinner = false;
        }
    );
  }
}
