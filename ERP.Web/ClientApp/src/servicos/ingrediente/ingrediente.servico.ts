import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Ingrediente } from "../../app/modelo/ingrediente";

@Injectable({
  providedIn: "root"
})
export class IngredienteServico implements OnInit {

  public ingredientes: Ingrediente[];

  private _baseUrl: string;
  constructor(private http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this._baseUrl = baseUrl;
  }

  ngOnInit(): void {
    this.ingredientes = []; 
  }

  get headers(): HttpHeaders {
    return new HttpHeaders().set('content-type', 'applicaton/json')
  }

  public cadastrar(ingrediente: Ingrediente): Observable<Ingrediente> {
    return this.http.post<Ingrediente>(this._baseUrl + "api/ingrediente/cadastrar", JSON.stringify(ingrediente), { headers: this.headers });
  }

  public salvar(ingrediente: Ingrediente): Observable<Ingrediente> {

    return this.http.post<Ingrediente>(this._baseUrl + "api/ingrediente/salvar", JSON.stringify(ingrediente), { headers: this.headers });
  }

  public deletar(ingrediente: Ingrediente): Observable<Ingrediente> {

    return this.http.post<Ingrediente>(this._baseUrl + "api/ingrediente/deletar", JSON.stringify(ingrediente), { headers: this.headers });
  }

  public obterTodosIngredientes(): Observable<Ingrediente[]> {
    return this.http.get<Ingrediente[]>(this._baseUrl + "api/ingrediente");
  }

  public obterIngrediente(ingredienteId: number): Observable<Ingrediente> {
    return this.http.get<Ingrediente>(this._baseUrl + "api/ingrediente/obter");
  }

}
