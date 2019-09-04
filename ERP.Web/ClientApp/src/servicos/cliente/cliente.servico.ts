import { Injectable, Inject, OnInit } from "@angular/core";
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { Observable } from "rxjs";
import { Cliente } from "../../app/modelo/cliente";

@Injectable({
  providedIn: "root"
})
export class ClienteServico implements OnInit {
   
  public ingredientes: Cliente[];

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

  public cadastrar(cliente: Cliente): Observable<Cliente> {
    return this.http.post<Cliente>(this._baseUrl + "api/cliente/cadastrar", JSON.stringify(cliente), { headers: this.headers });
  }

  public salvar(cliente: Cliente): Observable<Cliente> {

    return this.http.post<Cliente>(this._baseUrl + "api/cliente/salvar", JSON.stringify(cliente), { headers: this.headers });
  }

  public deletar(cliente: Cliente): Observable<Cliente> {

    return this.http.post<Cliente>(this._baseUrl + "api/cliente/deletar", JSON.stringify(cliente), { headers: this.headers });
  }

  public obterTodosIngredientes(): Observable<Cliente[]> {
    return this.http.get<Cliente[]>(this._baseUrl + "api/cliente");
  }

  public obterIngrediente(clienteId: number): Observable<Cliente> {
    return this.http.get<Cliente>(this._baseUrl + "api/cliente/obter");
  }

}
