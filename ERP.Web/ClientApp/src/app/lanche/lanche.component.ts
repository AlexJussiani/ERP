import { Component, OnInit } from "@angular/core"
import { Lanche } from "../modelo/lanche";
import { LancheServico } from "../../servicos/lanche/lanche.servico";

@Component({
  selector: "app-lanche",
  templateUrl: "./lanche.component.html",
  styleUrls: ["./lanche.component.css"]
})

export class LancheComponent implements OnInit {
  public lanche: Lanche

  constructor(private lancheServico: LancheServico) {

  }

  ngOnInit(): void {
    this.lanche = new Lanche();

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
